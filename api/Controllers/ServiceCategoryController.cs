using Engrana.Domain;
using Engrana.Domain.Configuration;
using Engrana.Services;

namespace Engrana.Controllers;

public class ServiceCategoryController(
    ILogger<ServiceCategory> logger,
    IService<ServiceCategory> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ServiceCategory>(service, taskQueue, logger) { }
