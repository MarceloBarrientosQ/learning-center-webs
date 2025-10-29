using ACME.LearningCenterPlatform.API.Publishing.Model.ValueObject;

namespace ACME.LearningCenterPlatform.API.Publishing.Model.Entities;

public class ImageAsset : Asset 
{

    public ImageAsset() : base(EAssetType.Image)
    {
    }
    public Uri? ImageUri { get; }
    public ImageAsset(string imageUrl) : base(EAssetType.Image)
    {
        ImageUri = new Uri(imageUrl);
    }

    public override bool Readable => false;

    public override bool Viewable => true;

    public override string GetContent()
    {
        return ImageUri is not null
            ? ImageUri.AbsoluteUri
            : String.Empty;
    }
}