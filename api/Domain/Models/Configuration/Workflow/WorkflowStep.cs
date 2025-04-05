using System.Reflection;

namespace Engrana.Domain.Configuration;

public class WorkflowStep : EntityBase
{
    public int Order { get; set; }
    public IList<StringPropertyState> StringPropertyToUpdate { get; set; } = [];
    public IList<BooleanPropertyState> BooleanPropertyToUpdate { get; set; } = [];
    public IList<DatePropertyState> DatePropertyToUpdate { get; set; } = [];
    public IList<NumberPropertyState> NumberPropertyToUpdate { get; set; } = [];
    public required CompareStatement CompareStatement { get; set; }
    private IList<PropertyStateBase> PropertiesToEvaulate =>
        [
            .. BooleanPropertyToUpdate,
            .. StringPropertyToUpdate,
            .. DatePropertyToUpdate,
            .. NumberPropertyToUpdate
        ];
    public IList<IPropertyState> FailedProperties { get; set; } = [];

    public bool Step(EntityBase entity, PropertyInfo[] entityProperties)
    {
        CompareStatement.Evaluate(entity, entityProperties);
        if (CompareStatement.IsSatisfied)
        {
            foreach (var property in PropertiesToEvaulate)
            {
                if (property.TransferState(entity, entityProperties) is false)
                    FailedProperties.Add(property);
            }
            if (!FailedProperties.Any())
            {
                return true;
            }
        }
        return false;
    }
}
