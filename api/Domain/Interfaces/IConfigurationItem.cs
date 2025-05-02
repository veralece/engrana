using Engrana.Domain;

namespace Engrana.Domain.Interfaces;

public interface IConfigurationItem : IConfigurable
{
    string? Description { get; }
    ConfigurationItemStatus Status { get; }
    Version? Version { get; }
    string? Location { get; } //logial vs physical?
}
