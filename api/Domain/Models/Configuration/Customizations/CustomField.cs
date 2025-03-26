namespace Engrana.Domain.Configuration;

public class CustomField : EntityBase
{
    public required string Label { get; set; }
    public CustomFieldType Type { get; set; } = CustomFieldType.Text;
    public EntityType Entity { get; set; }

    #region Entity Framework Navigation Properties
    public CustomSet? Set { get; set; }
    public IList<CustomFieldEntry>? Entries { get; set; }
    #endregion
}
