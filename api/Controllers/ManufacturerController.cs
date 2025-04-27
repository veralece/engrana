using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ManufacturerController(
    ILogger<Manufacturer> logger,
    IService<Manufacturer> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Manufacturer>(service, taskQueue, logger) { }
