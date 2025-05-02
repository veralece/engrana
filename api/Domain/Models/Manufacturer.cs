using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

//todo add other data points relevant to manufacturers
//licenses, contracts, policies...
public record Manufacturer(
    Guid? Id,
    IList<string>? Urls,
    IList<PhysicalAddress>? Addresses,
    IList<ContactInformation>? Contacts
) : ConfigurableBase(Id), IManufacturer
{
    public override EntityType EntityType => EntityType.Manufacturer;
}
