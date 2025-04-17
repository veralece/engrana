using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public class Service : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.Service;

    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    public Manufacturer? Manufacturer { get; set; }
    #endregion
}
