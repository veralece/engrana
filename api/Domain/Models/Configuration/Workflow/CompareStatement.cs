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

    [NotMapped]
    public IList<IPropertyState> SatisfiedConditions { get; set; } = [];

    [NotMapped]
    public IList<IPropertyState> UnsatisfiedConditions { get; set; } = [];
    private int ConditionCount
    {
        get =>
            StringPropertyConditions.Count
            + DatePropertyConditions.Count
            + BooleanPropertyConditions.Count
            + NumberPropertyConditions.Count;
        // + EntityPropertyConditions.Count;
        // + IntegerArrayPropertiesToCompare.Count
        // + StringArrayPropertiesToCompare.Count
        // + DateArrayPropertiesToCompare.Count;
    }

    //todo maybe add operators such as EqualTo, Contains, GreaterThan, LessThan, etc
    public void Evaluate(EntityBase entity, PropertyInfo[] entityProperties)
    {
        bool _satisfied;
        if (BooleanPropertyConditions.Any())
        {
            foreach (var condition in BooleanPropertyConditions)
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

        if (NumberPropertyConditions.Any())
        {
            foreach (var condition in NumberPropertyConditions)
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

        if (DatePropertyConditions.Any())
        {
            foreach (var condition in DatePropertyConditions)
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

        if (StringPropertyConditions.Any())
        {
            foreach (var condition in StringPropertyConditions)
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
