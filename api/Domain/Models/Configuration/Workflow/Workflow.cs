namespace Engrana.Domain.Configuration;

public class Workflow : EntityBase
{
    public IList<WorkflowStep> WorkflowSteps { get; set; } = [];
    //todo see if constraint is needed or how it could be used.
    // public ComparisonConstraint ComparisonConstraint { get; set; } = ComparisonConstraint.ALL_PASS;
}
