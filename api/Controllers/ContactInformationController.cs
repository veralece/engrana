using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ContactInformationController(
    ILogger<ContactInformationController> logger,
    IService<ContactInformation> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ContactInformation>(service, taskQueue)
{
    private readonly ILogger<ContactInformationController> _logger = logger;
}
