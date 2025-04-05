using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class ContactInformationController(
    ILogger<ContactInformationController> logger,
    ContactInformationService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ContactInformation>(service, taskQueue)
{
    private readonly ILogger<ContactInformationController> _logger = logger;
}
