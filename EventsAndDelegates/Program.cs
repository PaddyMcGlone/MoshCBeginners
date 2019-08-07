namespace EventsAndDelegates
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var video1 = new Video { Title = "Van highlights" };
            var encoder = new VideoEncoder(); // Publisher
            var mailService = new MailService(); // Subscriber
            var whatsApp = new WhatsAppService(); // Another Subscriber

            // VideoEncoded behind the scenes is a list of pointers (methods)
            // Below we are just adding a new method to call to this list.
            encoder.VideoEncoded += mailService.VideoEnocderEventHandler; // subcribe to the event

            // Adding another subscriber
            encoder.VideoEncoded += whatsApp.VideoEnocderEventHandler; // Subscribe to the event

            encoder.Encode(video1);
        }
    }
}
    