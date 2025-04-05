using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class PhysicalAddressController(
    ILogger<PhysicalAddressController> logger,
    PhysicalAddressService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<PhysicalAddress>(service, taskQueue)
{
    private readonly ILogger<PhysicalAddressController> _logger = logger;
}
