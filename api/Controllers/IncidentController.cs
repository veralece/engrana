using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class IncidentController(ILogger<IncidentController> logger, IncidentService service)
    : GenericController<Incident>(service)
{
    private readonly ILogger<IncidentController> _logger = logger;
}
