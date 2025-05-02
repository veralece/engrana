using Engrana.Domain.Interfaces;

namespace Engrana.Domain;

public record Incident(
    Guid? Id,
    string Title,
    string? Description,
    ContactInformation PrimaryContact,
    IList<ContactInformation> AdditionalContacts,
    IList<ConfigurationItem> AffectedCIs
) : ConfigurableBase(Id), IIncident
{
    public override EntityType EntityType => EntityType.Incident;
}
