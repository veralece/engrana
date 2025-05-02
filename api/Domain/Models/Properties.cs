using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public abstract record PropertyBase<TEntry>(Guid? Id) : Base(Id), IProperty<TEntry>
    where TEntry : IEntry
{
    public string? FieldLabel { get; set; }
    public FieldType FieldType { get; set; } = FieldType.Input;
    public bool Required { get; set; }
    public string? HintMessage { get; set; }
    public IList<EntityType> EntityTypes { get; set; } = [];
    public IList<TEntry> Entries { get; set; } = [];
}

public record BooleanProperty(Guid? Id) : PropertyBase<BooleanEntry>(Id) { }

public record StringProperty(Guid? Id, StringSet? Set)
    : PropertyBase<StringEntry>(Id),
        IHaveSet<string, StringSet> { }

public record DateProperty(Guid? Id, DateSet? Set)
    : PropertyBase<DateEntry>(Id),
        IHaveSet<DateTime, DateSet> { }

public record NumberProperty(Guid? Id, NumberSet? Set)
    : PropertyBase<NumberEntry>(Id),
        IHaveSet<int, NumberSet> { }
