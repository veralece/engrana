using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ContactInformationController(
    ILogger<ContactInformation> logger,
    IService<ContactInformation> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ContactInformation>(service, taskQueue, logger) { }
