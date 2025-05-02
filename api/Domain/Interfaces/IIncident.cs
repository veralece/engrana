namespace Engrana.Domain.Interfaces;

public interface IIncident : IConfigurable
{
    string Title { get; }
    string? Description { get; }
}
