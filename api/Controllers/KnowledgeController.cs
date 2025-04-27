using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class KnowledgeController(
    ILogger<KnowledgeArticle> logger,
    IService<KnowledgeArticle> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<KnowledgeArticle>(service, taskQueue, logger) { }
