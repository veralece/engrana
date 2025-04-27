using Engrana.Domain;
using Engrana.Domain.Configuration;
using Engrana.Services;

namespace Engrana.Controllers;

public class OrganizationQueueController(
    ILogger<OrganizationQueue> logger,
    IService<OrganizationQueue> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<OrganizationQueue>(service, taskQueue, logger) { }
