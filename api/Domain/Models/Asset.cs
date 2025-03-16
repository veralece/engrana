#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Engrana.Domain
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
