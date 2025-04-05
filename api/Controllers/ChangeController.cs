using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class ChangeController(
    ILogger<ChangeController> logger,
    ChangeService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Change>(service, taskQueue)
{
    private readonly ILogger<ChangeController> _logger = logger;
}
