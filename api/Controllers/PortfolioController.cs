using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class PortfolioController(
    ILogger<Portfolio> logger,
    IService<Portfolio> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Portfolio>(service, taskQueue, logger) { }
