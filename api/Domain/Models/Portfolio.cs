using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

//todo add other data points relevant to changes
public record Portfolio(
    Guid? Id,
    string? Description,
    IList<Project> Projects,
    IList<Service> Services
) : ConfigurableBase(Id), IPortfolio
{
    public override EntityType EntityType => EntityType.Portfolio;
}
