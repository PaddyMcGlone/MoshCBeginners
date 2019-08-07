using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void VideoEnocderEventHandler(object source, VideoArgs args)
        {
            Console.WriteLine($"MailService: Encoding video {args.video.Title}");
        }
    }
}
