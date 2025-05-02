using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record Profile(Guid? Id) : ConfigurableBase(Id), IProfile
{
    public override EntityType EntityType => EntityType.Profile;
}
