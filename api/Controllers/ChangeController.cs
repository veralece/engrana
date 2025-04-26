using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ChangeController(
    ILogger<ChangeController> logger,
    IService<Change> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Change>(service, taskQueue)
{
    private readonly ILogger<ChangeController> _logger = logger;
}
