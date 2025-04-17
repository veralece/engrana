using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo add other data points relevant to organizations
public class ServiceRequest : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.ServiceRequest;
    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    #endregion
}
