using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo add other data points relevant to organizations
public class Organization : ConfigurableEntity
{
    public override EntityType Type => EntityType.Organization;
    #region Entity Framework Navigation Properties
    #endregion
}
