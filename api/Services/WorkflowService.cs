using Engrana.Domain.Configuration;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Services;

//todo determine which non-CRUD functions to create
public class WorkflowService(IDbContextFactory<EngranaContext> contextFactory)
    : ServiceBase<Workflow>(contextFactory) { }
