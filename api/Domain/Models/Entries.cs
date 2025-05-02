using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record EntryBase<T>(Guid? Id) : Base(Id), IEntry<T>
{
    public required Guid EntityId { get; set; }
    public required T Value { get; set; }
}

public record StringEntry(Guid? Id) : EntryBase<string>(Id), IEntry<string> { }

public record NumberEntry(Guid? Id) : EntryBase<int>(Id), IEntry<int> { }

public record DateEntry(Guid? Id) : EntryBase<DateTime>(Id), IEntry<DateTime> { }

public record BooleanEntry(Guid? Id) : EntryBase<bool>(Id), IEntry<bool> { }
