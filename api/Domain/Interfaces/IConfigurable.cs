namespace Engrana.Domain.Interfaces;

public interface IConfigurable : IEntity
{
    IList<IProperty> AdditionalProperties { get; }
}

public interface IConfigurable<TStringProp, TDateProp, TBoolProp, TNumberProp> : IConfigurable
    where TStringProp : IProperty
    where TDateProp : IProperty
    where TBoolProp : IProperty
    where TNumberProp : IProperty
{
    public IList<TStringProp> AdditionalStringProperties { get; }

    public IList<TDateProp> AdditionalDateProperties { get; }

    public IList<TBoolProp> AdditionalBooleanProperties { get; }

    public IList<TNumberProp> AdditionalNumberProperties { get; }
}
