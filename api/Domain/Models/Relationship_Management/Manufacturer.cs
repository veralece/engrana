using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo add other data points relevant to manufacturers
//licenses, contracts, policies...
public class Manufacturer : ConfigurableEntity
{
    public required string Name { get; set; }
    public IList<string>? Urls { get; set; } = [];
    #region Entity Framework Navigation Properties
    public IList<PhysicalAddress>? Addresses { get; set; } = [];
    public IList<ContactInformation>? Contacts { get; set; } = [];
    #endregion
}
