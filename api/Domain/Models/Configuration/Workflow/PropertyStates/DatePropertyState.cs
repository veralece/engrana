using System.Reflection;

namespace Engrana.Domain.Configuration;

public class DatePropertyState : PropertyState<DateTime>
{
    private object? GetValue(EntityBase entity, PropertyInfo[] entityProperties)
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
        return entityValue;
    }

    public override bool Compare(EntityBase entity, PropertyInfo[] entityProperties)
    {
        var entityValue = GetValue(entity, entityProperties);
        if (entityValue is not null && PropertyCondition is not null)
        {
            return PropertyCondition switch
            {
                Condition.Equal => Equals(entityValue),
                Condition.Less => (DateTime)entityValue < Value,
                Condition.Greater => (DateTime)entityValue > Value,
                _ => throw new NotImplementedException()
            };
        }
        return false;
    }

    public override bool Equals(DateTime entityValue) => entityValue == Value;

    public override bool TransferState(EntityBase entity, PropertyInfo[] entityProperties)
    {
        object? entityProperty = null;
        if (IsCustomProperty && entity is ConfigurableEntity configurableEntity)
        {
            entityProperty = configurableEntity
                .AdditionalDateProperties.FirstOrDefault(p => p.Name == PropertyName)
                ?.Entries.First();
            if (entityProperty is not null && entityProperty is DateEntry dateEntry)
            {
                dateEntry.Value = Value;
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
