using Engrana.Domain;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Services;

//todo determine which non-CRUD functions to create
public class ServiceService(IDbContextFactory<EngranaContext> contextFactory)
    : ServiceBase<Service>(contextFactory) { }
