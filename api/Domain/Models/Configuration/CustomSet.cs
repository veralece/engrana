namespace Engrana.Domain.Configuration;

public class CustomSet : EntityBase
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public IList<string>? Values { get; set; } = [];
}
