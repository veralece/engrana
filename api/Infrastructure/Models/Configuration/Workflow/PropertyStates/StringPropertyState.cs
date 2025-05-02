using System.Reflection;
using Engrana.Domain;

namespace Engrana.Infrastructure.Models;

public class StringPropertyState : PropertyState<string>
{
    public override Condition? PropertyCondition
    {
        get => Condition.Equal;
    }

    private object? GetValue(EntityBase entity, PropertyInfo[] entityProperties)
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

        return entityValue;
    }

    public override bool Compare(EntityBase entity, PropertyInfo[] entityProperties)
    {
        var entityValue = GetValue(entity, entityProperties);
        if (entityValue is not null && PropertyCondition is not null)
            return Equals((string)entityValue);
        return false;
    }

    public override bool Equals(string entityValue)
    {
        return Value.Equals(entityValue.Trim(), StringComparison.InvariantCultureIgnoreCase);
    }

    public override bool TransferState(EntityBase entity, PropertyInfo[] entityProperties)
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
