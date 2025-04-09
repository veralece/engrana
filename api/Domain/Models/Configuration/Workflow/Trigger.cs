using System.Reflection;

namespace Engrana.Domain.Configuration;

public class Trigger : EntityBase
{
    public required EntityType TriggerEntity { get; init; }
    public required ActionType ActionType { get; init; }
    public required ConditionStatement ConditionStatement { get; init; }
    public required Guid WorkflowId { get; init; }
    public string? Message { get; init; }
    public bool ShowMessage { get; init; }

    public Guid? Check(EntityBase entity, PropertyInfo[] entityPropertyInfo)
    {
        ConditionStatement.Evaluate(entity, entityPropertyInfo);
        if (ConditionStatement.IsSatisfied)
            return WorkflowId;

        return default;
    }
}
