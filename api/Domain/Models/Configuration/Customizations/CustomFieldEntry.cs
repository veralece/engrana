namespace Engrana.Domain.Configuration;

//TODO should date values be serialized into a string?
public class CustomFieldEntry : EntityBase
{
    public required Guid EntityId { get; set; }
    public string? Value { get; set; }
    public DateTime? DateValue { get; set; }
    public bool? BoolValue { get; set; }
    public IList<string>? MultiValue { get; set; }
}
