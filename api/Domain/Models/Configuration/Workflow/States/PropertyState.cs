using System.Reflection;

namespace Engrana.Domain.Configuration;

public abstract class PropertyState : EntityBase
{
    public bool IsCustomProperty { get; set; } = false;
    public required string PropertyName { get; set; }
    public abstract bool Compare(EntityBase entity, PropertyInfo[] entityProperties);
    public abstract void TransferState(EntityBase entity, PropertyInfo[] entityProperties);
}

//todo determine how to transfer entity states
//? Comparison of entity state is already done.
// public class EntityPropertyState : PropertyState, IValueType<Guid>
// {
//     public required Guid Value { get; set; }

//     public override bool Compare(EntityBase entity, PropertyInfo[] entityProperties)
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
