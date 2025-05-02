using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public abstract record Base(Guid? Id) : IEntity
{
    public virtual EntityType EntityType { get; init; }
    public string? Name { get; init; }
    public DateTime? LastModified { get; init; }
    public Guid? LastModifiedBy { get; init; }
};

public abstract record ConfigurableBase(Guid? Id)
    : Base(Id),
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
