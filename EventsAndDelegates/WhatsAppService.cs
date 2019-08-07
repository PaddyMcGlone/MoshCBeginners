using System;

namespace EventsAndDelegates
{
    public class WhatsAppService
    {
        public void VideoEnocderEventHandler(object source, EventArgs args)
        {
            Console.WriteLine("WhatsAppService: Sending a WhatsApp message.");
        }
    }
}
