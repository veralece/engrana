using System.ComponentModel.DataAnnotations.Schema;
using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public static class EntityBaseExtenstions
{
    public static T GetByName<T>(this IEnumerable<T> source, string name)
        where T : EntityBase => source.First(e => e.Name == name);

    public static T? GetByNameOrDefault<T>(this IEnumerable<T> source, string name)
        where T : EntityBase => source.FirstOrDefault(e => e.Name == name);
}

public abstract class EntityBase : IEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    [NotMapped]
    public virtual EntityType EntityType { get; }
    public DateTime? Created { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime? LastModified { get; set; }
    public Guid? LastModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? Deleted { get; set; }
    public Guid? DeletedBy { get; set; }

    public T ShallowCopy<T>() => (T)this.MemberwiseClone();
}
