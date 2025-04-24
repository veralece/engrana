using Engrana.Domain.Configuration;

namespace Engrana.Domain;

public class Profile : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.Profile;
}
