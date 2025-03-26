using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class ChangeController(ILogger<ChangeController> logger, ChangeService service)
    : GenericController<Change>(service)
{
    private readonly ILogger<ChangeController> _logger = logger;
}
