using System.Reflection;

namespace Engrana.Domain.Configuration;

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

        return entityValue is not null && (string)entityValue == Value;
    }

    public override void TransferState(EntityBase entity, PropertyInfo[] entityProperties)
    {
        object? entityProperty = null;
        if (IsCustomProperty && entity is ConfigurableEntity configurableEntity)
        {
            entityProperty = configurableEntity
                .AdditionalStringProperties.FirstOrDefault(p => p.Name == PropertyName)
                ?.Entries.First();
            if (entityProperty is not null && entityProperty is StringEntry stringEntry)
            {
                stringEntry.Value = Value;
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

        // if (entityProperty is not null && (string)entityProperty == Value)
        // {
        //     return true;
        // }
        // return false;
    }
}
