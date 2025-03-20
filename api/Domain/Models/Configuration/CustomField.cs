namespace Engrana.Domain.Configuration;

public class CustomField : EntityBase
{
    public required string Label { get; set; }
    public CustomFieldType Type { get; set; } = CustomFieldType.Text;

    #region Entity Framework Navigation Properties
    public string[]? CustomSetValues { get; set; } = [];
    public IList<CustomFieldEntry>? Entries { get; set; } = [];
    #endregion
}
