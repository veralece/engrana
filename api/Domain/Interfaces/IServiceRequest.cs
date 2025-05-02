namespace Engrana.Domain.Interfaces;

public interface IServiceRequest : IConfigurable
{
    string? Description { get; }
}
