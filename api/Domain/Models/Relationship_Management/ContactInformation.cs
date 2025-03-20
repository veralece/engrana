namespace Engrana.Domain;

public class ContactInformation : EntityBase
{
    public required string Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    #region Entity Framework Navigation Properties
    public IList<PhysicalAddress>? Addresses { get; set; } = [];
    #endregion
}
