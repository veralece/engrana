namespace Engrana.Domain.Configuration;

public enum AssetStatus
{
    Active,
    Under_Maintenance,
    Disposed
}

public enum ConfigurationItemStatus
{
    Active,
    Inactive,
    Under_Maintenance,
    Retired
}

public enum IncidentStatus
{
    Logged,
    Assigned,
    Escalated,
    Monitoring,
    Resolved,
    Closed
}
