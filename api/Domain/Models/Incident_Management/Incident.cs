using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public class Incident : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.Incident;
    public required string Title { get; set; }
    public string? Description { get; set; }

    #region Entity Framework Navigation Properties
    public required ContactInformation PrimaryContact { get; set; }
    public IList<ContactInformation> AdditionalContacts { get; init; } = [];
    public IList<ConfigurationItem> AffectedCIs { get; init; } = [];
    #endregion
}
