using System;

namespace EventsAndDelegates
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var video1 = new Video { Title = "Van highlights" };
            var encoder = new VideoEncoder();

            encoder.Encode(video1);
        }
    }

    public class MailService
    {
        public void VideoEnocderEventHandler(object source, EventArgs args)
        {
            Console.WriteLine("Sending an email...");
        }
    }
}
