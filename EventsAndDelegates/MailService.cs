using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void VideoEnocderEventHandler(object source, EventArgs args)
        {
            Console.WriteLine("Sending an email...");
        }
    }
}
