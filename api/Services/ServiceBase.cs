using System.Net;
using System.Reflection;
using Engrana.Domain;
using Engrana.Domain.Configuration;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Services;

//todo consider other generic operations
/// <summary>
/// Generic service that performs basic CRUD operations
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="context"></param>
public abstract class ServiceBase<T>(
    IDbContextFactory<EngranaContext> contextFactory,
    IBackgroundTaskQueue taskQueue
) : IService<T>
    where T : EntityBase
{
    protected readonly IDbContextFactory<EngranaContext> _contextFactory = contextFactory;
    protected readonly IBackgroundTaskQueue _taskQueue = taskQueue;

    public async Task<T?> AddAsync(T entity)
    {
        using var context = _contextFactory.CreateDbContext();
        DbSet<T> dbSet = context.Set<T>();
        var entry = await dbSet.AddAsync(entity);
        int result = await context.SaveChangesAsync();
        if (result > 0)
            return entry.Entity;
        return default;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        using var context = _contextFactory.CreateDbContext();
        DbSet<T> dbSet = context.Set<T>();

        return await dbSet
            .Where(e => e.Id == id)
            .ExecuteUpdateAsync(setters => setters.SetProperty(e => e.IsDeleted, true));
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        using var context = _contextFactory.CreateDbContext();
        DbSet<T> dbSet = context.Set<T>();
        return await dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        using var context = _contextFactory.CreateDbContext();
        DbSet<T> dbSet = context.Set<T>();
        return await dbSet.FindAsync(id);
    }

    public async Task<int> UpdateAsync(T entity)
    {
        using var context = _contextFactory.CreateDbContext();
        DbSet<T> dbSet = context.Set<T>();
        dbSet.Attach(entity);
        context.Entry(entity).State = EntityState.Modified;
        return await context.SaveChangesAsync();
    }

    //todo develop the trigger to queue a workflow with the entity
    //pull all triggers for the affected entity type and run the trigger conditions.
    public async Task CheckEntityWorkflows(T entity, ActionType ActionType)
    {
        IList<Workflow>? workflows;
        var entityProperties = entity.GetType().GetProperties();

        using (var _context = _contextFactory.CreateDbContext())
        {
            var triggers = await GetTriggersAsync(entity, ActionType, _context);
            workflows = await EvaluateTriggers(entity, entityProperties, triggers, _context);
        }

        if (workflows is not null && workflows.Count > 0)
        {
            foreach (var workflow in workflows)
            {
                //let's sequentially run workflows for now
                await workflow.Execute(entity.ShallowCopy<T>(), entityProperties, _contextFactory);
                // await _taskQueue.QueueBackgroundWorkItemAsync(
                //     async (serviceProvider, token) =>
                //     {
                //?        var scopedService = serviceProvider.GetRequiredService<IService<T>>();
                //?         await scopedService.ExecuteWorkflow(workflow, entity);
                //?         would queuing the workflows into their own separate thread be worth it?
                //     }
                // );
            }
        }
        // if (triggers.Count > 0)
        // {
        //     Guid? workflowGuid = null;
        //     var entityPropertyInfo = entity.GetType().GetProperties();
        //     foreach (var trigger in triggers)
        //     {
        //         workflowGuid = trigger.Check(entity, entityPropertyInfo);
        //         if (workflowGuid is not null && !workflowIds.Contains((Guid)workflowGuid))
        //         {
        //             workflowIds.Add((Guid)workflowGuid);
        //         }
        //     }

        //     if (workflowIds.Count > 0)
        //     {
        //         var workflows = await context
        //             .Workflow.Where(wf => workflowIds.Contains(wf.Id))
        //             .ToListAsync();

        //         if (workflows.Count > 0)
        //         {
        //             foreach (var workflow in workflows)
        //             {
        //                 //todo determine how to save after workflow is performed
        //                 var entityCopy = entity.ShallowCopy<T>();
        //                 await workflow.Execute(entityCopy, entityPropertyInfo, context);
        //                 //? save after each workflow?
        //             }
        //         }
        //     }
        // }
    }

    public async Task CheckEntityWorkflows(Guid guid, ActionType actionType)
    {
        T? entity;
        using (var context = _contextFactory.CreateDbContext())
        {
            entity = context.Set<T>().FirstOrDefault(e => e.Id == guid);
        }
        if (entity is not null)
        {
            await CheckEntityWorkflows(entity, actionType);
        }
    }

    protected async Task<IEnumerable<Trigger>> GetTriggersAsync(
        EntityBase entity,
        ActionType ActionType,
        EngranaContext context
    ) =>
        await context
            .Trigger.Where(t => t.ActionType == ActionType && t.TriggerEntity == entity.EntityType)
            .Include(t => t.ConditionStatement)
            .ThenInclude(c => c.BooleanPropertyStateConditions)
            .Include(t => t.ConditionStatement)
            .ThenInclude(c => c.NumberPropertyStateConditions)
            .Include(t => t.ConditionStatement)
            .ThenInclude(c => c.DatePropertyStateConditions)
            .Include(t => t.ConditionStatement)
            .ThenInclude(c => c.StringPropertyStateConditions)
            .ToListAsync();

    protected async Task<IList<Workflow>> EvaluateTriggers(
        EntityBase entity,
        PropertyInfo[] entityProperties,
        IEnumerable<Trigger> triggers,
        EngranaContext context
    )
    {
        IList<Guid> workflowIds = [];
        Guid? workflowGuid;
        foreach (var trigger in triggers)
        {
            workflowGuid = trigger.Check(entity, entityProperties);
            if (workflowGuid is not null)
            {
                workflowIds.Add((Guid)workflowGuid);
                //todo clean up? workflowGuid = null;
            }
        }

        if (workflowIds.Count > 0)
        {
            //getting workflow and steps
            var query = context
                .Workflow.Where(wf =>
                    workflowIds.Contains(wf.Id) && wf.WorkflowType == WorkflowType.Triggered
                )
                //grabs data steps
                .Include(wf => wf.DataSteps)
                .ThenInclude(step => step.BooleanPropertyToUpdate)
                .Include(wf => wf.DataSteps)
                .ThenInclude(step => step.DatePropertyToUpdate)
                .Include(wf => wf.DataSteps)
                .ThenInclude(step => step.NumberPropertyToUpdate)
                .Include(wf => wf.DataSteps)
                .ThenInclude(step => step.StringPropertyToUpdate)
                //getting condition steps
                .Include(wf => wf.ConditionSteps)
                .ThenInclude(step => step.ConditionStatement)
                .ThenInclude(compare => compare.BooleanPropertyStateConditions)
                .Include(wf => wf.ConditionSteps)
                .ThenInclude(step => step.ConditionStatement)
                .ThenInclude(compare => compare.DatePropertyStateConditions)
                .Include(wf => wf.ConditionSteps)
                .ThenInclude(step => step.ConditionStatement)
                .ThenInclude(compare => compare.NumberPropertyStateConditions)
                .Include(wf => wf.ConditionSteps)
                .ThenInclude(step => step.ConditionStatement)
                .ThenInclude(compare => compare.StringPropertyStateConditions);

            return await query.ToListAsync();
        }
        return [];
    }
}
