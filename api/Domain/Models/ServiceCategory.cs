using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record ServiceCategory(
    Guid? Id,
    string? Description,
    IList<Service> Services,
    Organization? ServiceCategoryOwner
) : Base(Id), IServiceCategory
{
    public override EntityType EntityType => EntityType.ServiceCategory;
}
