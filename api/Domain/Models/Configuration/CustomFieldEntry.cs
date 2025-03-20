namespace Engrana.Domain.Configuration;

//TODO should date values be serialized into a string?
public class CustomFieldEntry : EntityBase
{
    public string? TextValue { get; set; }
    public DateTime[]? DateValue { get; set; } = [];
    public string[]? MultiValue { get; set; } = [];
}
