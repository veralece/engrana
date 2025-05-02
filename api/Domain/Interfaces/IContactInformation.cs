namespace Engrana.Domain.Interfaces;

public interface IContactInformation : IConfigurable
{
    string? Email { get; }
    string? Phone { get; }
}
