using System.Reflection;
using Engrana.Infrastructure;

namespace Engrana.Infrastructure.Models;

public abstract class StepBase : EntityBase
{
    public int Order { get; set; }
    public abstract bool Step(
        EntityBase entity,
        PropertyInfo[] entityProperties,
        EngranaContext? context = null
    );
}
