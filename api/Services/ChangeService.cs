using Engrana.Domain;
using Engrana.Infrastructure;

namespace Engrana.Service;

//todo determine which non-CRUD functions to create
public class ChangeService(EngranaContext context) : ServiceBase<Change>(context) { }
