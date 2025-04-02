namespace Engrana.Domain.Configuration;

public abstract class PropertyBase : EntityBase
{
    public string? FieldLabel { get; set; }
    public FieldType FieldType { get; set; } = FieldType.Input;
    public bool Required { get; set; }
    public string? HintMessage { get; set; }
    public IList<EntityType> EntityTypes { get; set; } = [];
}

public class BooleanProperty : PropertyBase
{
    public BooleanProperty()
    {
        FieldType = FieldType.Boolean;
    }

    public IList<BooleanEntry> Entries { get; set; } = [];
}

public class StringProperty : PropertyBase
{
    #region Entity Framework Navigation Properties
    public StringSet? Set { get; set; }
    public IList<StringEntry> Entries { get; set; } = [];
    #endregion
}

public class DateProperty : PropertyBase
{
    #region Entity Framework Navigation Properties
    public DateSet? Set { get; set; }
    public IList<DateEntry> Entries { get; set; } = [];
    #endregion
}

public class NumberProperty : PropertyBase
{
    #region Entity Framework Navigation Properties
    public NumberSet? Set { get; set; }
    public IList<NumberEntry> Entries { get; set; } = [];
    #endregion
}
