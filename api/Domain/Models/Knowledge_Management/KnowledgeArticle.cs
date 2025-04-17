using Engrana.Domain.Configuration;

namespace Engrana.Domain;

//todo add other data points relevant to organizations
public class KnowledgeArticle : ConfigurableEntity
{
    public override EntityType EntityType => EntityType.KnowledgeArticle;
    public string? Description { get; set; }
    #region Entity Framework Navigation Properties
    #endregion
}
