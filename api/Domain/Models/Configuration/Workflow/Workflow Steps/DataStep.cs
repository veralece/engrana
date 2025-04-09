using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Engrana.Domain.Configuration;

public class DataStep : StepBase
{
    public IList<StringPropertyState> StringPropertyToUpdate { get; set; } = [];
    public IList<BooleanPropertyState> BooleanPropertyToUpdate { get; set; } = [];
    public IList<DatePropertyState> DatePropertyToUpdate { get; set; } = [];
    public IList<NumberPropertyState> NumberPropertyToUpdate { get; set; } = [];
    private IList<PropertyStateBase> PropertiesToUpdate =>
        [
            .. BooleanPropertyToUpdate,
            .. StringPropertyToUpdate,
            .. DatePropertyToUpdate,
            .. NumberPropertyToUpdate
        ];

    [NotMapped]
    public IList<IPropertyState> FailedProperties { get; set; } = [];

    public override bool Step(EntityBase entity, PropertyInfo[] entityProperties)
    {
        foreach (var property in PropertiesToUpdate)
        {
            if (property.TransferState(entity, entityProperties) is false)
                FailedProperties.Add(property);
        }
        if (!FailedProperties.Any())
        {
            return true;
        }

        return false;
    }
}
