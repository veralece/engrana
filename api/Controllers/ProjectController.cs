using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ProjectController(
    ILogger<ProjectController> logger,
    ProjectService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Project>(service, taskQueue)
{
    private readonly ILogger<ProjectController> _logger = logger;
}
