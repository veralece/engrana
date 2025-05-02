using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record Asset(
    Guid? Id,
    string? AssetTag,
    string? Description,
    string? SerialNumber,
    string? Location,
    PhysicalAddress? Address,
    Manufacturer? Manufacturer,
    AssetStatus Status = AssetStatus.Active
) : ConfigurableBase(Id), IAsset
{
    public override EntityType EntityType => EntityType.Asset;
}
