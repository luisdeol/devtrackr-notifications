namespace DevTrackR.Notifications.API.Infrastructure
{
    public class ShippingOrderUpdateTemplate : IEmailTemplate
    {
        public ShippingOrderUpdateTemplate(string trackingCode, string to, string description)
        {
            Subject = $"Your shipping order with code {trackingCode} was updated.";
            Content = $"Hi, how are you? This is a notification about your shipping order with code {trackingCode}. Update: {description}";
            To = to;
        }

        public string Subject { get; set; }
        public string Content { get; set; }
        public string To { get; set; }
    }
}
