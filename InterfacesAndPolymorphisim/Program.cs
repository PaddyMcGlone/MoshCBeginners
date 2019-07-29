using System;

namespace InterfacesAndPolymorphisim
{
    public class MailService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Send message");
        }
    }

    // The video class below is tightly coupled to the mailservice and always
    // has to use this service to send a message.
    public class VideoEncoder
    {
        private readonly MailService _mailService;

        public VideoEncoder()
        {
            _mailService = new MailService();
        }

        public void Encode(Byte[] video)
        {
            // Do some work here..

            // Ideally we want to call a send service instead and have anyone implement this call.
            _mailService.SendMessage("Complete"); 
        }
    }

    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
