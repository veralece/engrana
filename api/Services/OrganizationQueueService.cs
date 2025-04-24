using Engrana.Domain.Configuration;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Services;

//todo determine which non-CRUD functions to create
public class OrganizationQueueService(
    IDbContextFactory<EngranaContext> contextFactory,
    IBackgroundTaskQueue taskQueue
) : ServiceBase<OrganizationQueue>(contextFactory, taskQueue) { }
