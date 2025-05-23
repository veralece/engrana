using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Engrana.Infrastructure.Models;

public class ConditionStatement : EntityBase
{
    [NotMapped]
    public bool IsSatisfied { get; private set; } = false;
    public IList<StringPropertyState> StringPropertyStateConditions { get; init; } = [];
    public IList<DatePropertyState> DatePropertyStateConditions { get; init; } = [];
    public IList<BooleanPropertyState> BooleanPropertyStateConditions { get; init; } = [];
    public IList<NumberPropertyState> NumberPropertyStateConditions { get; init; } = [];

    // public IList<EntityPropertyState> EntityPropertyStateConditions { get; init; } = [];

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
        if (PropertyStateConditions.Count > 0)
        {
            foreach (var condition in PropertyStateConditions)
            {
                if (condition.Compare(entity, entityPropertyInfo))
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
