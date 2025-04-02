namespace Engrana.Domain.Configuration;

public class WorkflowStep : EntityBase
{
    public int Order { get; set; }
    public IList<StringPropertyState> StringPropertyToUpdate { get; set; } = [];
    public IList<BooleanPropertyState> BooleanPropertyToUpdate { get; set; } = [];
    public IList<DatePropertyState> DatePropertyToUpdate { get; set; } = [];
    public IList<NumberPropertyState> NumberPropertyToUpdate { get; set; } = [];
    public required CompareStatement CompareStatement { get; set; }

    public void Step(EntityBase entity)
    {
        var entityProperties = entity.GetType().GetProperties();
        CompareStatement.Evaluate(entity, entityProperties);
        if (CompareStatement.IsSatisfied)
        {
            if (StringPropertyToUpdate.Any())
            {
                foreach (var property in StringPropertyToUpdate)
                {
                    property.TransferState(entity, entityProperties);
                }
            }
            if (BooleanPropertyToUpdate.Any())
            {
                foreach (var property in BooleanPropertyToUpdate)
                {
                    property.TransferState(entity, entityProperties);
                }
            }
            if (DatePropertyToUpdate.Any())
            {
                foreach (var property in DatePropertyToUpdate)
                {
                    property.TransferState(entity, entityProperties);
                }
            }
            if (NumberPropertyToUpdate.Any())
            {
                foreach (var property in NumberPropertyToUpdate)
                {
                    property.TransferState(entity, entityProperties);
                }
            }
        }
    }
}
