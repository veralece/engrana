using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo add other data points relevant to organizations
public class Organization : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.Organization;

    #region Entity Framework Navigation Properties
    public Portfolio? Portfolio { get; set; }
    #endregion
}
