using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo add other data points relevant to organizations
public class Organization : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.Organization;

    #region Entity Framework Navigation Properties
    public Portfolio? Portfolio { get; set; }
    public IList<OrganizationQueue> OrganizationQueues { get; init; } = [];
    public IList<Profile> Resources { get; init; } = [];
    public IList<ServiceCategory> ServiceCategories { get; init; } = [];
    #endregion
}
