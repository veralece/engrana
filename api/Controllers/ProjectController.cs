using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ProjectController(
    ILogger<Project> logger,
    IService<Project> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Project>(service, taskQueue, logger) { }
