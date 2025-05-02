using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record Service(
    Guid? Id,
    string? Description,
    Manufacturer? Manufacturer,
    Organization? ServiceOwner
) : ConfigurableBase(Id), IService
{
    public override EntityType EntityType => EntityType.Service;
}
