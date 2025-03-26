using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public class ContactInformation : ConfigurableEntity
{
    public string? Email { get; set; }
    public string? Phone { get; set; }
    #region Entity Framework Navigation Properties
    public IList<PhysicalAddress>? Addresses { get; set; } = [];
    #endregion
}
