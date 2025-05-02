using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

//TODO apply formatting constraints?
public class PhysicalAddress : ConfigurableEntity, IPhysicalAddress
{
    public override EntityType EntityType => EntityType.PhysicalAddress;
    public string? Address { get; set; }
    public string? County { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
}
