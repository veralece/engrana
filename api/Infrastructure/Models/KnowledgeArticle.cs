using Engrana.Domain;
using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

//todo add other data points relevant to knowledge articles
public class KnowledgeArticle : ConfigurableEntity, IKnowledgeArticle
{
    public override EntityType EntityType => EntityType.KnowledgeArticle;
    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    #endregion
}
