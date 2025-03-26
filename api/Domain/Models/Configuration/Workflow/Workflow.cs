namespace Engrana.Domain.Configuration;

public class Workflow : EntityBase
{
    //todo work on what triggers a workflow
    //? should there be a trigger entity and trigger conditions?
    //? TriggerCondition<T>() where T: EntityBase {Entity: EntityBase; CompareStatements: CompareStatement<T>[]; Results: bool[]; EvaluationConstraint: ComparisonConstraint.ANY | ComparisonConstraint.ALL}
    //? CheckConditions(ICondition TriggerConditions)
    //CompareStatement<T> where T : EntityBase {EntityPropertyName: string; ValueToCompare: string; Compare(T entity); }
    //Compare(entity)=> entity[CompareStatement.EntityPropertyName] = CompareStatement.ValueToCompare;
    public IList<WorkflowStep> WorkflowSteps { get; set; } = [];
}
