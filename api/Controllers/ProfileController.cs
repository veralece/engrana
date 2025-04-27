using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ProfileController(
    ILogger<Profile> logger,
    IService<Profile> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Profile>(service, taskQueue, logger) { }
