using System.Reflection;

namespace Engrana.Domain.Configuration;

public class Trigger : EntityBase
{
    public required EntityType TriggerEntity { get; init; }
    public required TriggerType TriggerType { get; init; }
    public required CompareStatement CompareStatement { get; init; }
    public required Guid WorkflowId { get; init; }
    public string? Message { get; init; }
    public bool ShowMessage { get; init; }

    public Guid? Check(EntityBase entity, PropertyInfo[] entityPropertyInfo)
    {
        CompareStatement.Evaluate(entity, entityPropertyInfo);
        if (CompareStatement.IsSatisfied)
            return WorkflowId;

        return default;
    }
}
