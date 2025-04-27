using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class OrganizationController(
    ILogger<Organization> logger,
    IService<Organization> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Organization>(service, taskQueue, logger) { }
