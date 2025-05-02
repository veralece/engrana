using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record ContactInformation(
    Guid? Id,
    string? Email,
    string? Phone,
    IList<PhysicalAddress>? Addresses
) : ConfigurableBase(Id), IContactInformation
{
    public override EntityType EntityType => EntityType.ContactInformation;
}
