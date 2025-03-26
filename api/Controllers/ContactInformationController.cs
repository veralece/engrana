using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class ContactInformationController(
    ILogger<ContactInformationController> logger,
    ContactInformationService service
) : GenericController<ContactInformation>(service)
{
    private readonly ILogger<ContactInformationController> _logger = logger;
}
