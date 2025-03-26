using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public abstract class EntityBase
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public DateTime? Created { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime? LastModified { get; set; }
    public Guid? LastModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? Deleted { get; set; }
    public Guid? DeletedBy { get; set; }
}

public static class EntityFactory
{
    public static EntityBase? TryConvertFromEnum(EntityType entityType, EntityBase? entity)
    {
        return entityType switch
        {
            EntityType.Asset => entity as Asset,
            _ => null,
        };
    }
}
