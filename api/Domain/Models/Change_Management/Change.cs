using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo add other data points relevant to organizations
public class Change : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.Change;
    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    #endregion
}
