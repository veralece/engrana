namespace Engrana.Domain.Interfaces;

public interface IEntry : IEntity
{
    Guid EntityId { get; }
}

public interface IEntry<T> : IEntry
{
    T Value { get; }
}
