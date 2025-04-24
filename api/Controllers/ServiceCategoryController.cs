using Engrana.Domain.Configuration;
using Engrana.Services;

namespace Engrana.Controllers;

public class ServiceCategoryController(
    ILogger<ServiceCategoryController> logger,
    ServiceCategoryService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ServiceCategory>(service, taskQueue)
{
    private readonly ILogger<ServiceCategoryController> _logger = logger;
}
