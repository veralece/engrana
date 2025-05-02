namespace Engrana.Domain.Interfaces;

public interface IPhysicalAddress
{
    string? Address { get; }
    string? County { get; }
    string? City { get; }
    string? State { get; }
    string? ZipCode { get; }
}
