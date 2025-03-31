namespace Engrana.Domain.Configuration;

public abstract class SetBase<T> : EntityBase
{
    public string? Description { get; set; }
    public IList<T> Values { get; set; } = [];
}

public class StringSet : SetBase<string> { }

public class NumberSet : SetBase<int> { }

public class DateSet : SetBase<DateTime> { }
