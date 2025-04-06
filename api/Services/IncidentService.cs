using Engrana.Domain;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Services;

//todo determine which non-CRUD functions to create
public class IncidentService(IDbContextFactory<EngranaContext> contextFactory)
    : ServiceBase<Incident>(contextFactory) { }
