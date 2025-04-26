using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class KnowledgeController(
    ILogger<KnowledgeController> logger,
    IService<KnowledgeArticle> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<KnowledgeArticle>(service, taskQueue)
{
    private readonly ILogger<KnowledgeController> _logger = logger;
}
