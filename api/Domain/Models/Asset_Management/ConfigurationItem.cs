using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public class ConfigurationItem : ConfigurableEntity
{
    public string? Description { get; set; }
    public ConfigurationItemStatus Status { get; set; } = ConfigurationItemStatus.Inactive;
    public string? Version { get; set; }
    public string? Location { get; set; } //logial vs physical?
    #region Entity Framework Navigation Properties
    public IList<ConfigurationItem> UpstreamConfigurationItems { get; set; } = [];
    public IList<ConfigurationItem> DownstreamConfigurationItems { get; set; } = [];
    public Manufacturer? Manufacturer { get; set; }
    public Asset? Asset { get; set; }
    #endregion
}
