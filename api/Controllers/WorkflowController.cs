using Engrana.Domain;
using Engrana.Domain.Configuration;
using Engrana.Services;

namespace Engrana.Controllers;

public class WorkflowController(
    ILogger<WorkflowController> logger,
    IService<Workflow> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Workflow>(service, taskQueue)
{
    private readonly ILogger<WorkflowController> _logger = logger;
}
