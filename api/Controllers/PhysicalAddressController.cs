using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class PhysicalAddressController(
    ILogger<PhysicalAddressController> logger,
    PhysicalAddressService service
) : GenericController<PhysicalAddress>(service)
{
    private readonly ILogger<PhysicalAddressController> _logger = logger;
}
