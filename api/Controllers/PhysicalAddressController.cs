using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class PhysicalAddressController(
    ILogger<PhysicalAddress> logger,
    IService<PhysicalAddress> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<PhysicalAddress>(service, taskQueue, logger) { }
