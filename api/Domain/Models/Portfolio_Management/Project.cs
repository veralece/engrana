using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo create their controller, service, dbcontext
public class Project : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.Project;
    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    public IList<ServiceRequest> ServiceRequests { get; init; } = [];
    public IList<Change> Changes { get; init; } = [];
    #endregion
}
