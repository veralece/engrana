namespace Engrana.Domain.Interfaces;

public interface IProperty : IEntity
{
    string? FieldLabel { get; }
    FieldType FieldType { get; }
    public bool Required { get; }
    string? HintMessage { get; }
    IList<EntityType> EntityTypes { get; }
}

public interface IProperty<TEntry> : IProperty
    where TEntry : IEntry
{
    IList<TEntry> Entries { get; }
}

public interface IHaveSet<T, TSet>
    where TSet : IValueSet<T>
{
    TSet? Set { get; }
}
