namespace Engrana.Domain.Interfaces;

public interface IManufacturer : IConfigurable
{
    public IList<string>? Urls { get; }
}
