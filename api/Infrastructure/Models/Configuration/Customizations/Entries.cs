using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public class EntryBase<T> : EntityBase, IEntry<T>
{
    public required Guid EntityId { get; set; }
    public required T Value { get; set; }
}

public class StringEntry : EntryBase<string>, IEntry<string> { }

public class NumberEntry : EntryBase<int>, IEntry<int> { }

public class DateEntry : EntryBase<DateTime>, IEntry<DateTime> { }

public class BooleanEntry : EntryBase<bool>, IEntry<bool> { }
