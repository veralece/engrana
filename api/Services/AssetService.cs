using Engrana.Domain;
using Engrana.Infrastructure;

namespace Engrana.Service;

public class AssetService(EngranaContext context) : ServiceBase<Asset>(context) { }
