using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record PhysicalAddress(
    Guid? Id,
    string? Address,
    string? County,
    string? City,
    string? State,
    string? ZipCode
) : ConfigurableBase(Id), IPhysicalAddress
{
    public override EntityType EntityType => EntityType.PhysicalAddress;
}
