namespace Engrana.Domain.Interfaces;

public interface IEntity
{
    EntityType EntityType { get; }
    string? Name { get; }
    DateTime? LastModified { get; }
    Guid? LastModifiedBy { get; }
}
