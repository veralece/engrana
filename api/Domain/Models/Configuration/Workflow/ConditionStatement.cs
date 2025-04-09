using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Engrana.Domain.Configuration;

public class ConditionStatement : EntityBase
{
    [NotMapped]
    public bool IsSatisfied { get; private set; } = false;
    public IList<StringPropertyState> StringPropertyStateConditions { get; init; } = [];
    public IList<DatePropertyState> DatePropertyStateConditions { get; init; } = [];
    public IList<BooleanPropertyState> BooleanPropertyStateConditions { get; init; } = [];
    public IList<NumberPropertyState> NumberPropertyStateConditions { get; init; } = [];

    // public IList<EntityPropertyState> EntityPropertyStateConditions { get; init; } = [];

    //todo test this functionality
    [NotMapped]
    public IList<IPropertyState> PropertyStateConditions
    {
        get =>
            [
                .. StringPropertyStateConditions,
                .. DatePropertyStateConditions,
                .. BooleanPropertyStateConditions,
                .. NumberPropertyStateConditions
            ];
    }

    [NotMapped]
    public IList<IPropertyState> SatisfiedConditions { get; set; } = [];

    [NotMapped]
    public IList<IPropertyState> UnsatisfiedConditions { get; set; } = [];

    //todo maybe add operators such as EqualTo, Contains, GreaterThan, LessThan, etc
    public void Evaluate(EntityBase entity, PropertyInfo[] entityPropertyInfo)
    {
        bool _satisfied;
        if (PropertyStateConditions.Count > 0)
        {
            foreach (var condition in PropertyStateConditions)
            {
                _satisfied = condition.Compare(entity, entityPropertyInfo);
                if (_satisfied)
                {
                    SatisfiedConditions.Add(condition);
                }
                else
                {
                    UnsatisfiedConditions.Add(condition);
                }
            }
        }

        if (PropertyStateConditions.Count == SatisfiedConditions.Count)
        {
            IsSatisfied = true;
        }
    }
}
