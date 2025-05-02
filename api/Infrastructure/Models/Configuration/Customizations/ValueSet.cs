using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public abstract class ValueSetBase<T> : EntityBase, IValueSet<T>
{
    public string? Description { get; set; }
    public IList<T> Values { get; set; } = [];
}

public class StringSet : ValueSetBase<string> { }

public class NumberSet : ValueSetBase<int> { }

public class DateSet : ValueSetBase<DateTime> { }
