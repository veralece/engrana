using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ManufacturerController(
    ILogger<ManufacturerController> logger,
    ManufacturerService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Manufacturer>(service, taskQueue)
{
    private readonly ILogger<ManufacturerController> _logger = logger;
}
