using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public class Asset : ConfigurableEntity
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
