using ACME.LearningCenterPlatform.API.Publishing.Model.ValueObject;

namespace ACME.LearningCenterPlatform.API.Publishing.Model.Entities;

public class VideoAsset : Asset
{
    public Uri? VideoUri { get; private set; }
    
    public override bool Readable => false;
    
    public override bool Viewable => true;

    public VideoAsset() : base(EAssetType.Video)
    {
        VideoUri = null;
    }
    
    public VideoAsset(String videoUrl) : base(EAssetType.Video)
    {
        VideoUri = new Uri(videoUrl);
    }
    
    public override string GetContent()
    {
        return VideoUri is not null
            ? VideoUri.AbsoluteUri
            : String.Empty;
    }
}