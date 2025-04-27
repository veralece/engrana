using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ChangeController(
    ILogger<Change> logger,
    IService<Change> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Change>(service, taskQueue, logger) { }
