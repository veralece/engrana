using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class KnowledgeController(
    ILogger<KnowledgeController> logger,
    KnowledgeService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<KnowledgeArticle>(service, taskQueue)
{
    private readonly ILogger<KnowledgeController> _logger = logger;
}
