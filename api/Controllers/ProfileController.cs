using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ProfileController(
    ILogger<ProfileController> logger,
    IService<Profile> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Profile>(service, taskQueue)
{
    private readonly ILogger<ProfileController> _logger = logger;
}
