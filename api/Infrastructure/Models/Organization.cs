using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

//todo add other data points relevant to organizations
public class Organization : ConfigurableEntity, IOrganization
{
    public override EntityType EntityType => EntityType.Organization;

    #region Entity Framework Navigation Properties
    public IList<OrganizationQueue> OrganizationQueues { get; init; } = [];
    public Portfolio? Portfolio { get; set; }
    public IList<Profile> Resources { get; init; } = [];
    public IList<ServiceCategory> ServiceCategories { get; init; } = [];
    #endregion
}
