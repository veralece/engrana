using Engrana.Domain;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Service;

//todo determine which non-CRUD functions to create
public class ManufacturerService(IDbContextFactory<EngranaContext> contextFactory)
    : ServiceBase<Manufacturer>(contextFactory) { }
