using Engrana.Domain.Interfaces;

namespace Engrana.Infrastructure.Models;

public abstract class ConfigurableEntity
    : EntityBase,
        IConfigurable<StringProperty, DateProperty, BooleanProperty, NumberProperty>
{
    public IList<StringProperty> AdditionalStringProperties { get; init; } = [];
    public IList<DateProperty> AdditionalDateProperties { get; init; } = [];
    public IList<BooleanProperty> AdditionalBooleanProperties { get; init; } = [];
    public IList<NumberProperty> AdditionalNumberProperties { get; init; } = [];
    public IList<IProperty> AdditionalProperties =>
        [
            .. AdditionalStringProperties,
            .. AdditionalDateProperties,
            .. AdditionalBooleanProperties,
            .. AdditionalNumberProperties
        ];
}
