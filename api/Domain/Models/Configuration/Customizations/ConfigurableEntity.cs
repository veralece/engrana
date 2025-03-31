namespace Engrana.Domain.Configuration;

public abstract class ConfigurableEntity : EntityBase
{
    public IList<StringProperty> AdditionalStringProperties { get; set; } = [];
    public IList<DateProperty> AdditionalDateProperties { get; set; } = [];
    public IList<BooleanProperty> AdditionalBooleanProperties { get; set; } = [];
    public IList<NumberProperty> AdditionalNumberProperties { get; set; } = [];
}
