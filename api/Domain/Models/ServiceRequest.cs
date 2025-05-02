using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

//todo add other data points relevant to service requests
public record ServiceRequest(
    Guid? Id,
    string? Description,
    ServiceCategory? ServiceCategory,
    Service? Service,
    OrganizationQueue? AssignedQueue,
    Profile? AssignedResource
) : ConfigurableBase(Id), IServiceRequest
{
    public override EntityType EntityType => EntityType.ServiceRequest;
}
