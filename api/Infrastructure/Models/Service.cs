using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public class Service : ConfigurableEntity, IService
{
    public override EntityType EntityType => EntityType.Service;
    public string? Description { get; set; }

    #region Entity Framework Navigation Properties
    public Manufacturer? Manufacturer { get; set; }
    public Organization? ServiceOwner { get; set; }
    #endregion
}
