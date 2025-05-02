using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

//todo add other data points relevant to manufacturers
//licenses, contracts, policies...
public class Manufacturer : ConfigurableEntity, IManufacturer
{
    public override EntityType EntityType => EntityType.Manufacturer;
    public IList<string>? Urls { get; init; } = [];
    #region Entity Framework Navigation Properties
    public IList<PhysicalAddress>? Addresses { get; init; } = [];
    public IList<ContactInformation>? Contacts { get; init; } = [];
    #endregion
}
