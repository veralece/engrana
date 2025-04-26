using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class PortfolioController(
    ILogger<PortfolioController> logger,
    IService<Portfolio> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Portfolio>(service, taskQueue)
{
    private readonly ILogger<PortfolioController> _logger = logger;
}
