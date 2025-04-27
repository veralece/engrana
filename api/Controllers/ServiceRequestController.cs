using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ServiceRequestController(
    ILogger<ServiceRequest> logger,
    IService<ServiceRequest> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ServiceRequest>(service, taskQueue, logger) { }
