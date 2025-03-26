using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class ManufacturerController(
    ILogger<ManufacturerController> logger,
    ManufacturerService service
) : GenericController<Manufacturer>(service)
{
    private readonly ILogger<ManufacturerController> _logger = logger;
}
