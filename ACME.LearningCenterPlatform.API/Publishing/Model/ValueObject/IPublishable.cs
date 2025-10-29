namespace ACME.LearningCenterPlatform.API.Publishing.Model.ValueObject;

public interface IPublishable
{
    void SendToEdit();
    void SendToApproval();
    void ApproveAndLock();
    void Reject();
    void ReturnToEdit();
}