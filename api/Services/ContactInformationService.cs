using Engrana.Domain;
using Engrana.Infrastructure;

namespace Engrana.Service;

//todo determine which non-CRUD functions to create
public class ContactInformationService(EngranaContext context)
    : ServiceBase<ContactInformation>(context) { }
