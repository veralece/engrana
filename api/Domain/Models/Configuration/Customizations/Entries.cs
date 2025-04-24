namespace Engrana.Domain.Configuration;

public class EntryBase : EntityBase
{
    public required Guid EntityId { get; set; }
}

public class StringEntry : EntryBase
{
    public required string Value { get; set; }
}

public class NumberEntry : EntryBase
{
    public required int Value { get; set; }
}

public class DateEntry : EntryBase
{
    public required DateTime Value { get; set; }
}

public class BooleanEntry : EntryBase
{
    public required bool Value { get; set; }
}
