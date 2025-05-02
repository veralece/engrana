namespace Engrana.Infrastructure.Models;

public class Vote : EntityBase
{
    public required Profile Voter { get; set; }
    public bool Decision { get; set; }
}
