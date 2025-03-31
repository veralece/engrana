using Engrana.Domain.Configuration;
using Engrana.Service;

namespace Engrana.Controllers;

public class WorkflowController(ILogger<WorkflowController> logger, WorkflowService service)
    : GenericController<Workflow>(service)
{
    private readonly ILogger<WorkflowController> _logger = logger;
}
