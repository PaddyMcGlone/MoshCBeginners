using System;

namespace EventsAndDelegates
{
    public class WhatsAppService
    {
        public void VideoEnocderEventHandler(object source, VideoArgs args)
        {
            Console.WriteLine($"WhatsAppService: Encoding video - {args.video.Title}.");
        }
    }
}
    