using Engrana.Domain.Configuration;
using Engrana.Service;

namespace Engrana.Controllers;

public class WorkflowController(
    ILogger<WorkflowController> logger,
    WorkflowService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Workflow>(service, taskQueue)
{
    private readonly ILogger<WorkflowController> _logger = logger;
}
