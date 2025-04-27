using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class IncidentController(
    ILogger<Incident> logger,
    IService<Incident> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Incident>(service, taskQueue, logger) { }
