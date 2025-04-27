using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ServiceController(
    ILogger<Service> logger,
    IService<Service> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Service>(service, taskQueue, logger) { }
