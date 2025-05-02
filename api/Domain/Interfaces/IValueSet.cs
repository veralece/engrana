namespace Engrana.Domain.Interfaces;

public interface IValueSet<T> : IEntity
{
    public string? Description { get; }
    public IList<T> Values { get; }
}
