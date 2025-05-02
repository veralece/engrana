using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

//todo add other data points relevant to organizations
public record Organization(
    Guid? Id,
    IList<OrganizationQueue> OrganizationQueues,
    Portfolio? Portfolio,
    IList<Profile> Resources,
    IList<ServiceCategory> ServiceCategories
) : ConfigurableBase(Id), IOrganization
{
    public override EntityType EntityType => EntityType.Organization;
}
