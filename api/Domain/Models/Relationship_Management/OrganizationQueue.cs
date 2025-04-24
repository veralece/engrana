namespace Engrana.Domain.Configuration;

public class OrganizationQueue : EntityBase
{
    public override EntityType EntityType => EntityType.OrganizationQueue;

    #region Entity Framework Navigation Properties
    public Organization? Organization { get; set; }
    public IList<Profile> Resources { get; init; } = [];
    #endregion
}
