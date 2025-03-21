namespace Engrana.Domain.Configuration;

public abstract class ConfigurableEntity : EntityBase
{
    public IList<CustomField>? CustomFields { get; set; }
}
