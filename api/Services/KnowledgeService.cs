using Engrana.Domain;
using Engrana.Infrastructure;

namespace Engrana.Service;

//todo determine which non-CRUD functions to create
public class KnowledgeService(EngranaContext context) : ServiceBase<KnowledgeArticle>(context) { }
