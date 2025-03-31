using System.Reflection;

namespace Engrana.Domain.Configuration;

public abstract class PropertyState : EntityBase
{
    public bool IsCustomProperty { get; set; } = false;
    public required string PropertyName { get; set; }
    public abstract bool Compare(EntityBase entity, PropertyInfo[] entityProperties);
    //todo work on transferring state once condittion is satisfied
    // public abstract bool TransferState(EntityBase entity);
}

public class StringPropertyState : PropertyState, IValueType<string>
{
    public required string Value { get; set; }

    public override bool Compare(EntityBase entity, PropertyInfo[] entityProperties)
    {
        object? entityValue = null;
        if (IsCustomProperty && entity is ConfigurableEntity configurableEntity)
        {
            entityValue = configurableEntity
                .AdditionalStringProperties.FirstOrDefault(p => p.Name == PropertyName)
                ?.Entries.First()
                .Value;
        }
        else
        {
            entityValue = entityProperties
                .FirstOrDefault(p => p.Name == PropertyName)
                ?.GetValue(entity);
        }
        if (entityValue is not null && (string)entityValue == Value)
        {
            return true;
        }
        return false;
    }

    // public override bool TransferState(EntityBase entity)
    // {
    //     object? entityValue = null;
    //     if (IsCustomProperty && entity is ConfigurableEntity configurableEntity)
    //     {
    //         entityValue = configurableEntity
    //             .AdditionalStringProperties.FirstOrDefault(p => p.Name == PropertyName)
    //             ?.Entries.First()
    //             .Value;
    //     }
    //     else
    //     {
    //         entityValue = entityProperties
    //             .FirstOrDefault(p => p.Name == PropertyName)
    //             ?.GetValue(entity);
    //     }
    //     if (entityValue is not null && (string)entityValue == Value)
    //     {
    //         return true;
    //     }
    //     return false;
    // }
}

public class EntityPropertyState : PropertyState, IValueType<Guid>
{
    public required Guid Value { get; set; }

    public override bool Compare(EntityBase entity, PropertyInfo[] entityProperties)
    {
        object? entityValue = entityProperties.First(p => p.Name == PropertyName).GetValue(entity);
        if (entityValue is not null && entityValue is EntityBase entityRecord)
        {
            return entityRecord.Id == Value;
        }
        return false;
    }
}

public class DatePropertyState : PropertyState, IValueType<DateTime>
{
    public required DateTime Value { get; set; }

    public override bool Compare(EntityBase entity, PropertyInfo[] entityProperties)
    {
        object? entityValue = null;
        if (IsCustomProperty && entity is ConfigurableEntity configurableEntity)
        {
            entityValue = configurableEntity
                .AdditionalDateProperties.FirstOrDefault(p => p.Name == PropertyName)
                ?.Entries.First()
                .Value;
        }
        else
        {
            entityValue = entityProperties
                .FirstOrDefault(p => p.Name == PropertyName)
                ?.GetValue(entity);
        }
        if (entityValue is not null && (DateTime)entityValue == Value)
        {
            return true;
        }
        return false;
    }
}

public class BooleanPropertyState : PropertyState, IValueType<bool>
{
    public required bool Value { get; set; }

    public override bool Compare(EntityBase entity, PropertyInfo[] entityProperties)
    {
        object? entityValue = null;
        if (IsCustomProperty && entity is ConfigurableEntity configurableEntity)
        {
            entityValue = configurableEntity
                .AdditionalBooleanProperties.FirstOrDefault(p => p.Name == PropertyName)
                ?.Entries.First()
                .Value;
        }
        else
        {
            entityValue = entityProperties
                .FirstOrDefault(p => p.Name == PropertyName)
                ?.GetValue(entity);
        }
        if (entityValue is not null && (bool)entityValue == Value)
        {
            return true;
        }
        return false;
    }
}

public class NumberPropertyState : PropertyState, IValueType<int>
{
    public required int Value { get; set; }

    public override bool Compare(EntityBase entity, PropertyInfo[] entityProperties)
    {
        object? entityValue = null;
        if (IsCustomProperty && entity is ConfigurableEntity configurableEntity)
        {
            entityValue = configurableEntity
                .AdditionalNumberProperties.FirstOrDefault(p => p.Name == PropertyName)
                ?.Entries.First()
                .Value;
        }
        else
        {
            entityValue = entityProperties
                .FirstOrDefault(p => p.Name == PropertyName)
                ?.GetValue(entity);
        }
        if (entityValue is not null && (int)entityValue == Value)
        {
            return true;
        }
        return false;
    }
}

// public class NumberArrayPropertyState : PropertyState, IValueType<int[]>
// {
//     public required int[] Value { get; set; }
// }

// public class DateArrayPropertyState : PropertyState, IValueType<DateTime[]>
// {
//     public required DateTime[] Value { get; set; }
// }

// public class StringArrayPropertyState : PropertyState, IValueType<string[]>
// {
//     public required string[] Value { get; set; }
// }
