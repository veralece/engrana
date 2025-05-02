using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public class ContactInformation : ConfigurableEntity, IContactInformation
{
    public override EntityType EntityType => EntityType.ContactInformation;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    #region Entity Framework Navigation Properties
    public IList<PhysicalAddress>? Addresses { get; init; } = [];
    #endregion
}
