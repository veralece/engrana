using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

//todo add other data points relevant to changes
public class Project : ConfigurableEntity, IProject
{
    public override EntityType EntityType => EntityType.Project;
    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    public IList<ServiceRequest> ServiceRequests { get; init; } = [];
    public IList<Change> Changes { get; init; } = [];
    #endregion
}
