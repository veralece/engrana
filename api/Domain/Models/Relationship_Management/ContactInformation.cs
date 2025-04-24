using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public class ContactInformation : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.ContactInformation;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    #region Entity Framework Navigation Properties
    public IList<PhysicalAddress>? Addresses { get; init; } = [];
    #endregion
}
