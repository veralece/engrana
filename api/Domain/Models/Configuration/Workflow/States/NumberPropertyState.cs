using System.Reflection;

namespace Engrana.Domain.Configuration;

public class NumberPropertyState : PropertyState<int>
{
    public override required int Value { get; set; }

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

        return entityValue is not null && (int)entityValue == Value;
    }

    public override bool TransferState(EntityBase entity, PropertyInfo[] entityProperties)
    {
        object? entityProperty = null;
        if (IsCustomProperty && entity is ConfigurableEntity configurableEntity)
        {
            entityProperty = configurableEntity
                .AdditionalStringProperties.FirstOrDefault(p => p.Name == PropertyName)
                ?.Entries.First();
            if (entityProperty is not null && entityProperty is NumberEntry numberEntry)
            {
                numberEntry.Value = Value;
                return true;
            }
        }
        else
        {
            entityProperty = entityProperties.FirstOrDefault(p => p.Name == PropertyName);
            if (entityProperty is not null && entityProperty is PropertyInfo propertyInfo)
            {
                propertyInfo.SetValue(entity, Value);
                return true;
            }
        }

        return false;
    }
}
