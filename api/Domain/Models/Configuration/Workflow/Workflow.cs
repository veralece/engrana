using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Domain.Configuration;

public class Workflow : EntityBase
{
    public WorkflowType WorkflowType { get; set; } = WorkflowType.Manual;
    public IList<DataStep> DataSteps { get; set; } = [];
    public IList<ConditionStep> ConditionSteps { get; set; } = [];

    [NotMapped]
    public IList<StepBase> WorkflowSteps => [.. DataSteps, .. ConditionSteps];

    public async Task<bool> Execute(
        EntityBase entity,
        PropertyInfo[] entityPropertyInfo,
        IDbContextFactory<EngranaContext> contextFactory
    )
    {
        bool executedSuccessfully = true;
        int result = 0;
        using var context = contextFactory.CreateDbContext();
        foreach (var wf_step in WorkflowSteps.OrderBy(e => e.Order))
        {
            if (wf_step.Step(entity, entityPropertyInfo) is false)
            {
                executedSuccessfully = false;
                break;
            }
        }

        if (executedSuccessfully)
        {
            result = await context.SaveChangesAsync();
        }
        return result > 0;
    }
    //todo see if constraint is needed or how it could be used.
    // public ComparisonConstraint ComparisonConstraint { get; set; } = ComparisonConstraint.ALL_PASS;
}
