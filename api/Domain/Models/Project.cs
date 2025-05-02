using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

//todo add other data points relevant to changes
public record Project(
    Guid? Id,
    string? Description,
    IList<ServiceRequest> ServiceRequests,
    IList<Change> Changes
) : ConfigurableBase(Id), IProject
{
    public override EntityType EntityType => EntityType.Project;
}
