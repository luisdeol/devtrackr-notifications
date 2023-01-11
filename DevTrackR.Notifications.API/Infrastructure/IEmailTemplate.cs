namespace DevTrackR.Notifications.API.Infrastructure
{
    public interface IEmailTemplate
    {
        string Subject { get; set; }
        string Content { get; set; }
        string To { get; set; }
    }
}
