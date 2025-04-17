using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo create their controller, service, dbcontext
public class Portfolio : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.Portfolio;
    public string? Description { get; set; }

    #region Entity Framework Navigation Properties
    public IList<Project> Projects { get; set; } = [];
    public IList<Service> Services { get; set; } = [];
    #endregion
}
