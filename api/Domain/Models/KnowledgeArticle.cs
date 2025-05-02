using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

//todo add other data points relevant to knowledge articles
public record KnowledgeArticle(Guid? Id, string? Description)
    : ConfigurableBase(Id),
        IKnowledgeArticle
{
    public override EntityType EntityType => EntityType.KnowledgeArticle;
}
