using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public class Profile : ConfigurableEntity, IProfile
{
    public override EntityType EntityType => EntityType.Profile;
}
