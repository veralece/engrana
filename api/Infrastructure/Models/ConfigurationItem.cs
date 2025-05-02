using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public class ConfigurationItem : ConfigurableEntity, IConfigurationItem
{
    public override EntityType EntityType => EntityType.ConfigurationItem;
    public string? Description { get; set; }
    public ConfigurationItemStatus Status { get; set; } = ConfigurationItemStatus.Inactive;
    public Version? Version { get; set; }
    public string? Location { get; set; } //logial vs physical?
    #region Entity Framework Navigation Properties
    public IList<ConfigurationItem> UpstreamConfigurationItems { get; set; } = [];
    public IList<ConfigurationItem> DownstreamConfigurationItems { get; set; } = [];
    public Asset? Asset { get; set; }
    public Service? Service { get; set; }
    #endregion
}
