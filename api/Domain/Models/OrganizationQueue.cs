using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record OrganizationQueue(Guid? Id, Organization? Organization, IList<Profile> Resources)
    : ConfigurableBase(Id),
        IOrganizationQueue
{
    public override EntityType EntityType => EntityType.OrganizationQueue;
}
