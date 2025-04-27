using System.Reflection;
using Engrana.Infrastructure;

namespace Engrana.Domain.Configuration;

public abstract class StepBase : EntityBase
{
    public int Order { get; set; }
    public abstract bool Step(
        EntityBase entity,
        PropertyInfo[] entityProperties,
        EngranaContext? context = null
    );
}
