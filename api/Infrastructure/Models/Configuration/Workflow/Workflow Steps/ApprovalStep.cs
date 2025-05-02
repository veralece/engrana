using System.Reflection;
using Engrana.Infrastructure;

namespace Engrana.Infrastructure.Models;

public class ApprovalStep : StepBase
{
    public required Approval Approval { get; set; }

    public override bool Step(
        EntityBase entity,
        PropertyInfo[] entityProperties,
        EngranaContext? context
    )
    {
        //todo send the notification to voters?
        throw new NotImplementedException();
    }
}
