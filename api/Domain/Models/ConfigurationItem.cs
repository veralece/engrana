using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public class ConfigurationItem : EntityBase
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public ConfigurationItemStatus Status { get; set; } = ConfigurationItemStatus.Inactive;
    public string? Version { get; set; }
    public string? Location { get; set; } //logial vs physical?
    public IList<ConfigurationItem> UpstreamConfigurationItems { get; set; } = [];
    public IList<ConfigurationItem> DownstreamConfigurationItems { get; set; } = [];
}
