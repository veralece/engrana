using System.Reflection;
using Engrana.Domain;

namespace Engrana.Infrastructure.Models;

public interface IPropertyState
{
    bool IsCustomProperty { get; set; }
    string PropertyName { get; set; }
    Condition? PropertyCondition { get; set; }
    bool Compare(EntityBase entity, PropertyInfo[] entityProperties);
    bool TransferState(EntityBase entity, PropertyInfo[] entityProperties);
}

public abstract class PropertyStateBase : EntityBase, IPropertyState
{
    public bool IsCustomProperty { get; set; } = false;
    public required string PropertyName { get; set; }
    public virtual Condition? PropertyCondition { get; set; }
    public abstract bool Compare(EntityBase entity, PropertyInfo[] entityProperties);
    public abstract bool TransferState(EntityBase entity, PropertyInfo[] entityProperties);
}

public abstract class PropertyState<T> : PropertyStateBase
{
    public abstract bool Equals(T entityValue);
    public required T Value { get; set; }
}


//todo determine how to transfer entity states
//? Comparison of entity state is already done.
// public class EntityPropertyState : PropertyState, IValueType<Guid>
// {
//     public required Guid Value { get; set; }

//     public override bool Equals(EntityBase entity, PropertyInfo[] entityProperties)
//     {
//         object? entityValue = entityProperties.First(p => p.Name == PropertyName).GetValue(entity);
//         if (entityValue is not null && entityValue is EntityBase entityRecord)
//         {
//             return entityRecord.Id == Value;
//         }
//         return false;
//     }

//     public override bool TransferState(EntityBase entity, PropertyInfo[] entityProperties)
//     {
//         object? entityProperty = entityProperties.First(p => p.Name == PropertyName);

//         if (entityProperty is not null && entityProperty is EntityBase entityRecord) { }

//         if (entityProperty is not null && (string)entityProperty == Value)
//         {
//             return true;
//         }
//         return false;
//     }
// }

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
