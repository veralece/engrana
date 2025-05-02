using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public abstract class PropertyBase<TEntry> : EntityBase, IProperty<TEntry>
    where TEntry : IEntry
{
    public string? FieldLabel { get; set; }
    public FieldType FieldType { get; set; } = FieldType.Input;
    public bool Required { get; set; }
    public string? HintMessage { get; set; }
    public IList<EntityType> EntityTypes { get; set; } = [];
    public IList<TEntry> Entries { get; set; } = [];
}

public class BooleanProperty : PropertyBase<BooleanEntry>
{
    public BooleanProperty()
    {
        FieldType = FieldType.Boolean;
    }
}

public class StringProperty : PropertyBase<StringEntry>, IHaveSet<string, StringSet>
{
    #region Entity Framework Navigation Properties
    public StringSet? Set { get; set; }
    #endregion
}

public class DateProperty : PropertyBase<DateEntry>, IHaveSet<DateTime, DateSet>
{
    #region Entity Framework Navigation Properties
    public DateSet? Set { get; set; }
    #endregion
}

public class NumberProperty : PropertyBase<NumberEntry>, IHaveSet<int, NumberSet>
{
    #region Entity Framework Navigation Properties
    public NumberSet? Set { get; set; }
    #endregion
}
