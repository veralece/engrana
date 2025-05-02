namespace Engrana.Infrastructure.Models;

//todo add other data points relevant to approvals
public class Approval : EntityBase
{
    //todo create role class to have relationship to approval step
    public IList<Profile> Voters { get; init; } = [];
    public IList<Vote> Votes { get; init; } = [];
    public bool Result { get; init; }
}
