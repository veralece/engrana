using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo create their controller, service, dbcontext
public class Project : ConfigurableEntity
{
    public string? Description { get; set; }
    public override EntityType EntityType => EntityType.Project;
}
