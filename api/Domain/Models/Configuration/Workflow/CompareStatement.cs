using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Engrana.Domain.Configuration;

public class CompareStatement : EntityBase
{
    [NotMapped]
    public bool IsSatisfied { get; private set; } = false;
    public IList<StringPropertyState> StringPropertyConditions { get; init; } = [];
    public IList<DatePropertyState> DatePropertyConditions { get; init; } = [];
    public IList<BooleanPropertyState> BooleanPropertyConditions { get; init; } = [];
    public IList<NumberPropertyState> NumberPropertyConditions { get; init; } = [];

    // public IList<EntityPropertyState> EntityPropertyConditions { get; init; } = [];
    // public IList<NumberArrayPropertyState> IntegerArrayPropertiesToCompare { get; init; } = [];
    // public IList<DateArrayPropertyState> DateArrayPropertiesToCompare { get; init; } = [];
    // public IList<StringArrayPropertyState> StringArrayPropertiesToCompare { get; init; } = [];

    //todo test this functionality
    [NotMapped]
    public IList<IPropertyState> PropertyConditions
    {
        get =>
            [
                .. StringPropertyConditions,
                .. DatePropertyConditions,
                .. BooleanPropertyConditions,
                .. NumberPropertyConditions
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
        if (PropertyConditions.Count > 0)
        {
            foreach (var condition in PropertyConditions)
            {
                _satisfied = condition.Equals(entity, entityPropertyInfo);
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
        //todo test new code and delete this if it works fine
        // if (BooleanPropertyConditions.Any())
        // {
        //     foreach (var condition in BooleanPropertyConditions)
        //     {
        //         _satisfied = condition.Compare(entity, entityProperties);
        //         if (_satisfied)
        //         {
        //             SatisfiedConditions.Add(condition);
        //         }
        //         else
        //         {
        //             UnsatisfiedConditions.Add(condition);
        //         }
        //     }
        // }

        // if (NumberPropertyConditions.Any())
        // {
        //     foreach (var condition in NumberPropertyConditions)
        //     {
        //         _satisfied = condition.Compare(entity, entityProperties);
        //         if (_satisfied)
        //         {
        //             SatisfiedConditions.Add(condition);
        //         }
        //         else
        //         {
        //             UnsatisfiedConditions.Add(condition);
        //         }
        //     }
        // }

        // if (DatePropertyConditions.Any())
        // {
        //     foreach (var condition in DatePropertyConditions)
        //     {
        //         _satisfied = condition.Compare(entity, entityProperties);
        //         if (_satisfied)
        //         {
        //             SatisfiedConditions.Add(condition);
        //         }
        //         else
        //         {
        //             UnsatisfiedConditions.Add(condition);
        //         }
        //     }
        // }

        // if (StringPropertyConditions.Any())
        // {
        //     foreach (var condition in StringPropertyConditions)
        //     {
        //         _satisfied = condition.Compare(entity, entityProperties);
        //         if (_satisfied)
        //         {
        //             SatisfiedConditions.Add(condition);
        //         }
        //         else
        //         {
        //             UnsatisfiedConditions.Add(condition);
        //         }
        //     }
        // }

        // if (EntityPropertyConditions.Any())
        // {
        //     foreach (var condition in EntityPropertyConditions)
        //     {
        //         _satisfied = condition.Compare(entity, entityProperties);
        //         if (_satisfied)
        //         {
        //             SatisfiedConditions.Add(condition);
        //         }
        //         else
        //         {
        //             UnsatisfiedConditions.Add(condition);
        //         }
        //     }
        // }


        if (PropertyConditions.Count == SatisfiedConditions.Count)
        {
            IsSatisfied = true;
        }
    }
}
