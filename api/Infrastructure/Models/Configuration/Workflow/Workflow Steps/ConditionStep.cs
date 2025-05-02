using System.Reflection;
using Engrana.Infrastructure;

namespace Engrana.Infrastructure.Models;

public class ConditionStep : StepBase
{
    public required ConditionStatement ConditionStatement { get; set; }

    public override bool Step(
        EntityBase entity,
        PropertyInfo[] entityProperties,
        EngranaContext? context = null
    )
    {
        ConditionStatement.Evaluate(entity, entityProperties);
        return ConditionStatement.IsSatisfied;
    }
}
