using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Engrana.Domain.Configuration;

public class CompareStatement : EntityBase
{
    [NotMapped]
    public bool IsSatisfied { get; private set; } = false;
    public IList<StringPropertyState> StringPropertyStates { get; init; } = [];
    public IList<DatePropertyState> DatePropertyStates { get; init; } = [];
    public IList<BooleanPropertyState> BooleanPropertyStates { get; init; } = [];
    public IList<NumberPropertyState> NumberPropertyStates { get; init; } = [];

    // public IList<EntityPropertyState> EntityPropertyStates { get; init; } = [];
    // public IList<NumberArrayPropertyState> IntegerArrayPropertiesToCompare { get; init; } = [];
    // public IList<DateArrayPropertyState> DateArrayPropertiesToCompare { get; init; } = [];
    // public IList<StringArrayPropertyState> StringArrayPropertiesToCompare { get; init; } = [];

    [NotMapped]
    public IList<PropertyState> SatisfiedConditions { get; set; } = [];

    [NotMapped]
    public IList<PropertyState> UnsatisfiedConditions { get; set; } = [];
    private int ConditionCount
    {
        get =>
            StringPropertyStates.Count
            + DatePropertyStates.Count
            + BooleanPropertyStates.Count
            + NumberPropertyStates.Count;
        // + EntityPropertyStates.Count;
        // + IntegerArrayPropertiesToCompare.Count
        // + StringArrayPropertiesToCompare.Count
        // + DateArrayPropertiesToCompare.Count;
    }

    //todo maybe add operators such as EqualTo, Contains, GreaterThan, LessThan, etc
    public void Evaluate(EntityBase entity, PropertyInfo[] entityProperties)
    {
        bool _satisfied;
        if (BooleanPropertyStates.Any())
        {
            foreach (var condition in BooleanPropertyStates)
            {
                _satisfied = condition.Compare(entity, entityProperties);
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

        if (NumberPropertyStates.Any())
        {
            foreach (var condition in NumberPropertyStates)
            {
                _satisfied = condition.Compare(entity, entityProperties);
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

        if (DatePropertyStates.Any())
        {
            foreach (var condition in DatePropertyStates)
            {
                _satisfied = condition.Compare(entity, entityProperties);
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

        if (StringPropertyStates.Any())
        {
            foreach (var condition in StringPropertyStates)
            {
                _satisfied = condition.Compare(entity, entityProperties);
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

        // if (EntityPropertyStates.Any())
        // {
        //     foreach (var condition in EntityPropertyStates)
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

        //todo old code to clean up, but leaving for historical purposes for now
        // foreach (var property in PropertiesToCompare)
        // {
        //     object? entityValue = null;
        //     if (property.IsCustomProperty && entity is ConfigurableEntity configurableEntity)
        //     {
        //         CustomProperty? entityProperty =
        //             configurableEntity?.CustomProperties?.FirstOrDefault(f =>
        //                 f.Name == property.Name
        //             );

        //         if (entityProperty is not null && entityProperty.Entries.Any())
        //         {
        //             entityValue = CustomPropertyConverter.ConvertFromString(
        //                 entityProperty.Entries.First()
        //             );
        //         }
        //     }
        //     else
        //     {
        //         var entityPropertyValue = entityProperties
        //             .First(p => p.Name == property.Name)
        //             .GetValue(entity);
        //         if (
        //             entityPropertyValue is not null
        //             && entityPropertyValue is EntityBase entityRecord
        //         )
        //         {
        //             entityValue = entityRecord.Id;
        //         }
        //         else
        //         {
        //             entityValue = entityPropertyValue;
        //         }
        //     }

        //     if (
        //         entityValue is not null
        //         && CustomPropertyConverter.ConvertFromString(property) == entityValue
        //     )
        //     {
        //         SatisfiedConditions.Add(property);
        //     }
        //     else
        //     {
        //         UnsatisfiedConditions.Add(property);
        //     }
        // }

        if (ConditionCount == SatisfiedConditions.Count)
        {
            IsSatisfied = true;
        }
    }
}
