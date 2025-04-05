using Engrana.Domain;
using Engrana.Domain.Configuration;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Service;

//todo consider other generic operations
/// <summary>
/// Generic service that performs basic CRUD operations
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="context"></param>
public abstract class ServiceBase<T>(IDbContextFactory<EngranaContext> contextFactory) : IService<T>
    where T : EntityBase
{
    protected readonly IDbContextFactory<EngranaContext> _contextFactory = contextFactory;

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
    public async Task CheckTrigger(T entity, TriggerType triggerType)
    {
        using var context = _contextFactory.CreateDbContext();
        IList<Guid> workflowIds = [];
        var triggers = await context
            .Trigger.Where(t => t.TriggerType == triggerType && t.TriggerEntity == entity.Type)
            .Include(t => t.CompareStatement)
            .ThenInclude(c => c.BooleanPropertyConditions)
            .Include(t => t.CompareStatement)
            .ThenInclude(c => c.NumberPropertyConditions)
            .Include(t => t.CompareStatement)
            .ThenInclude(c => c.DatePropertyConditions)
            .Include(t => t.CompareStatement)
            .ThenInclude(c => c.StringPropertyConditions)
            .ToListAsync();

        if (triggers.Count > 0)
        {
            Guid? guid = null;
            var entityPropertyInfo = entity.GetType().GetProperties();
            foreach (var trigger in triggers)
            {
                guid = trigger.Check(entity, entityPropertyInfo);
                if (guid is not null && !workflowIds.Contains((Guid)guid))
                {
                    workflowIds.Add((Guid)guid);
                }
            }

            if (workflowIds.Count > 0)
            {
                var workflows = await context
                    .Workflow.Where(wf => workflowIds.Contains(wf.Id))
                    .ToListAsync();

                if (workflows.Count > 0)
                {
                    foreach (var workflow in workflows)
                    {
                        //todo determine how to save after workflow is performed
                        var entityCopy = entity.ShallowCopy<T>();
                        await workflow.Execute(entityCopy, entityPropertyInfo, context);
                        //? save after each workflow?
                    }
                }
            }
        }
    }
}
