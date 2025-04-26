using Engrana.Domain;
using Engrana.Domain.Configuration;
using Engrana.Services;

namespace Engrana.Controllers;

public class ServiceCategoryController(
    ILogger<ServiceCategoryController> logger,
    IService<ServiceCategory> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ServiceCategory>(service, taskQueue)
{
    private readonly ILogger<ServiceCategoryController> _logger = logger;
}
