using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public class Asset : ConfigurableEntity, IAsset
{
    public override EntityType EntityType => EntityType.Asset;
    public string? AssetTag { get; set; }
    public string? Description { get; set; }
    public AssetStatus Status { get; set; } = AssetStatus.Active;
    public string? SerialNumber { get; set; }
    public string? Location { get; set; }
    #region Entity Framework Navigation Properties
    public Manufacturer? Manufacturer { get; set; }
    public PhysicalAddress? Address { get; set; }
    #endregion
}
