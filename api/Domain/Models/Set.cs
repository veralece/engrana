using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public abstract record ValueSetBase<T>(Guid? Id) : Base(Id), IValueSet<T>
{
    public string? Description { get; set; }
    public IList<T> Values { get; set; } = [];
}

public record StringSet(Guid? Id) : ValueSetBase<string>(Id) { }

public record NumberSet(Guid? Id) : ValueSetBase<int>(Id) { }

public record DateSet(Guid? Id) : ValueSetBase<DateTime>(Id) { }
