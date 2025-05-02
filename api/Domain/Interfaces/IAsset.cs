namespace Engrana.Domain.Interfaces;

public interface IAsset : IConfigurable
{
    string? AssetTag { get; }
    string? Description { get; }
    AssetStatus Status { get; }
    public string? SerialNumber { get; }
    public string? Location { get; }
}
