using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public class OrganizationQueue : ConfigurableEntity, IOrganizationQueue
{
    public override EntityType EntityType => EntityType.OrganizationQueue;

    #region Entity Framework Navigation Properties
    public Organization? Organization { get; set; }
    public IList<Profile> Resources { get; init; } = [];
    #endregion
}
