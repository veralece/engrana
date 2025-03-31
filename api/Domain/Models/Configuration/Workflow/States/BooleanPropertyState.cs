using System.Reflection;

namespace Engrana.Domain.Configuration;

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

        return entityValue is not null && (bool)entityValue == Value;
    }

    public override void TransferState(EntityBase entity, PropertyInfo[] entityProperties)
    {
        object? entityProperty = null;
        if (IsCustomProperty && entity is ConfigurableEntity configurableEntity)
        {
            entityProperty = configurableEntity
                .AdditionalBooleanProperties.FirstOrDefault(p => p.Name == PropertyName)
                ?.Entries.First();
            if (entityProperty is not null && entityProperty is BooleanEntry booleanEntry)
            {
                booleanEntry.Value = Value;
            }
        }
        else
        {
            entityProperty = entityProperties.FirstOrDefault(p => p.Name == PropertyName);
            if (entityProperty is not null && entityProperty is PropertyInfo propertyInfo)
            {
                propertyInfo.SetValue(entity, Value);
            }
        }

        // if (entityProperty is not null && (bool)entityProperty == Value)
        // {
        //     return true;
        // }
        // return false;
    }
}
