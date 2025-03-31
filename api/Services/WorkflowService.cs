using Engrana.Domain;
using Engrana.Domain.Configuration;
using Engrana.Infrastructure;

namespace Engrana.Service;

//todo determine which non-CRUD functions to create
public class WorkflowService(EngranaContext context) : ServiceBase<Workflow>(context) { }
