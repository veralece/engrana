using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record ConfigurationItem(
    Guid? Id,
    string? Description,
    ConfigurationItemStatus Status,
    Version? Version,
    string? Location
) : ConfigurableBase(Id), IConfigurationItem
{
    public override EntityType EntityType => EntityType.ConfigurationItem;
}
