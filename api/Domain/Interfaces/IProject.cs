namespace Engrana.Domain.Interfaces;

public interface IProject : IConfigurable
{
    string? Description { get; }
}
