namespace Engrana.Domain;

//TODO apply formatting constraints?
public class PhysicalAddress : EntityBase
{
    public required string Name { get; set; }
    public string? Address { get; set; }

    public string? County { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }
}
