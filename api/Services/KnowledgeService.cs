using Engrana.Domain;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Services;

//todo determine which non-CRUD functions to create
public class KnowledgeService(IDbContextFactory<EngranaContext> contextFactory)
    : ServiceBase<KnowledgeArticle>(contextFactory) { }
