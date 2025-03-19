using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public class Asset : EntityBase
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public AssetStatus Status { get; set; } = AssetStatus.Active;
    public string? SerialNumber { get; set; }
}
