using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ProfileController(
    ILogger<ProfileController> logger,
    ProfileService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Profile>(service, taskQueue)
{
    private readonly ILogger<ProfileController> _logger = logger;
}
