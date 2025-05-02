using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

//todo add other data points relevant to changes
public class Change : ConfigurableEntity, IChange
{
    public override EntityType EntityType => EntityType.Change;
    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    #endregion
}
