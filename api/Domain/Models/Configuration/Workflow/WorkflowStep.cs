namespace Engrana.Domain.Configuration;

public class WorkflowStep(EntityType outputEntity, EntityBase outputState) : EntityBase
{
    public EntityType OutputType { get; set; } = outputEntity;
    public EntityBase? OutputState { get; set; } =
        EntityFactory.TryConvertFromEnum(outputEntity, outputState);

    //? Might need to look into using the constructor for determining how the data will be saved to the database during run time.
    //todo Conditions
}
