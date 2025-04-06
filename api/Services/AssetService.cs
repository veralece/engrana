using Engrana.Domain;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Services;

//todo determine which non-CRUD functions to create
public class AssetService(IDbContextFactory<EngranaContext> contextFactory)
    : ServiceBase<Asset>(contextFactory) { }
