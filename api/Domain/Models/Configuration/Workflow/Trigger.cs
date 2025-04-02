using System.Reflection;

namespace Engrana.Domain.Configuration;

public class Trigger : EntityBase
{
    public EntityType TriggerEntity { get; init; }
    public TriggerType TriggerType { get; init; }
    public IList<CompareStatement> CompareStatements { get; init; } = [];
    public Guid WorkflowId { get; init; }
    public string? Message { get; init; }
    public bool ShowMessage { get; init; }
    private bool _shouldTriggerWorkflow = true;

    public void CheckTrigger(EntityBase entity)
    {
        if (entity is not null)
        {
            PropertyInfo[] entityProperties = entity.GetType().GetProperties();
            foreach (var statement in CompareStatements)
            {
                statement.Evaluate(entity, entityProperties);

                if (statement.IsSatisfied == false)
                {
                    _shouldTriggerWorkflow = false;
                    break;
                }
            }

            if (_shouldTriggerWorkflow == true)
            {
                //todo load Workflow and queue it
            }
        }
    }
}
