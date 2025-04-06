using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public class Incident : ConfigurableEntity
{
    public override EntityType Type => EntityType.Incident;
    public required string Title { get; set; }
    public string? Description { get; set; }

    #region Entity Framework Navigation Properties
    public IList<ContactInformation>? Contacts { get; set; } = [];
    public IList<ConfigurationItem>? AffectedCIs { get; set; } = [];
    #endregion
}
