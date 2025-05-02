using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public class ServiceCategory : EntityBase, IServiceCategory
{
    public override EntityType EntityType => EntityType.ServiceCategory;
    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    public IList<Service> Services { get; set; } = [];
    public Organization? ServiceCategoryOwner { get; set; }
    #endregion
}
