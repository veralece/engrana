using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class KnowledgeController(ILogger<KnowledgeController> logger, KnowledgeService service)
    : GenericController<KnowledgeArticle>(service)
{
    private readonly ILogger<KnowledgeController> _logger = logger;
}
