namespace Engrana.Domain.Interfaces;

//todo add other data points relevant to changes
public interface IChange : IConfigurable
{
    public string? Description { get; }
}
