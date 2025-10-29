using ACME.LearningCenterPlatform.API.Publishing.Model.ValueObject;

namespace ACME.LearningCenterPlatform.API.Publishing.Model.Entities;

public class ReadableContentAsset : Asset
{
    public string ReadableContent { get; set; }

    public ReadableContentAsset() : base(EAssetType.ReadbleContentItem)
    {
        ReadableContent = string.Empty;
    }
    
    public ReadableContentAsset(string content) : base(EAssetType.ReadbleContentItem)
    {
        ReadableContent = content;
    }
    
    public override bool Readable => true;
    
    public override bool Viewable => false;
}