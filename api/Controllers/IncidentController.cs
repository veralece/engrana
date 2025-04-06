using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class IncidentController(
    ILogger<IncidentController> logger,
    IncidentService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Incident>(service, taskQueue)
{
    private readonly ILogger<IncidentController> _logger = logger;
}
