namespace DevTrackR.Notifications.API.Infrastructure
{
    public interface INotificationService
    {
        Task Send(IEmailTemplate template);
    }
}
