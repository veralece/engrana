using System.ComponentModel.DataAnnotations.Schema;
using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public abstract class EntityBase
{
    public Guid Id { get; set; }
    public required string Name { get; set; }

    [NotMapped]
    public virtual EntityType Type { get; }
    public DateTime? Created { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime? LastModified { get; set; }
    public Guid? LastModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? Deleted { get; set; }
    public Guid? DeletedBy { get; set; }

    public T ShallowCopy<T>() => (T)this.MemberwiseClone();
}
