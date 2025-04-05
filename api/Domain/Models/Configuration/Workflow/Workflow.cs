using System.Reflection;
using Engrana.Infrastructure;

namespace Engrana.Domain.Configuration;

public class Workflow : EntityBase
{
    public IList<WorkflowStep> WorkflowSteps { get; set; } = [];

    public async Task<bool> Execute(
        EntityBase contextEntity,
        PropertyInfo[] entityPropertyInfo,
        EngranaContext context
    )
    {
        bool executedSuccessfully = true;
        int result = 0;
        foreach (var wf_step in WorkflowSteps)
        {
            if (wf_step.Step(contextEntity, entityPropertyInfo) is false)
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
