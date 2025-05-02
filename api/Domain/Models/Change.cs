using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record Change(Guid? Id, string? Description) : ConfigurableBase(Id), IChange
{
    public override EntityType EntityType => EntityType.Change;
}
