namespace ACME.LearningCenterPlatform.API.Publishing.Model.Entities;

public record AcmeAssetIdentifier(Guid identifier)
{
    public AcmeAssetIdentifier() : this(Guid.NewGuid()) {}
}