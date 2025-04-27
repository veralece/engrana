using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo add other data points relevant to service requests
public class ServiceRequest : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.ServiceRequest;
    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    public ServiceCategory? ServiceCategory { get; set; }
    public Service? Service { get; set; }
    public OrganizationQueue? AssignedQueue { get; set; }
    public Profile? AssignedResource { get; set; }
    #endregion
}
