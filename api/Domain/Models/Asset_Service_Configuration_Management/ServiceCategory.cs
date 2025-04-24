namespace Engrana.Domain.Configuration;

public class ServiceCategory : EntityBase
{
    public override EntityType EntityType => EntityType.ServiceCategory;
    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    public IList<Service> Services { get; set; } = [];
    public Organization? ServiceCategoryOwner { get; set; }
    #endregion
}
