using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.DataTransfer;

public record DTAsset(Guid? Id) : Base(Id), IAsset
{
    public EntityType EntityType => EntityType.Asset;
    public string? AssetTag { get; set; }
    public string? Description { get; set; }
    public AssetStatus Status { get; set; } = AssetStatus.Active;
    public string? SerialNumber { get; set; }
    public string? Location { get; set; }
    public IList<IProperty> AdditionalProperties => [];
    // public Manufacturer? Manufacturer { get; set; }
    // public PhysicalAddress? Address { get; set; }
};
