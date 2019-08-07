namespace EventsAndDelegates
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var video1 = new Video { Title = "Van highlights" };
            var encoder = new VideoEncoder(); // Publisher
            var mailService = new MailService(); // Subscriber

            encoder.VideoEncoded += mailService.VideoEnocderEventHandler; // subcribe to the event

            encoder.Encode(video1);
        }
    }
}
