using System;
using System.Collections.Generic;

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

    // Step one: Implement an interface
    public interface IMessaging
    {
        void send(string message);
    }

    // Step two: Implement the interfaces
    public class SmsMessage : IMessaging
    {
        public void send(string message)
        {
            Console.WriteLine("Sending an SMS Message.");
        }
    }
    public class MailMessage : IMessaging
    {
        public void send(string message)
        {
            Console.WriteLine("Sending a mail message.");
        }
    }

    // Step three: Replace the method calls with interface calls in the new class
    public class NewVideoEncoder
    {
        // A list if messaging types
        private readonly IList<IMessaging> messagings;

        public NewVideoEncoder()
        {            
            messagings = new List<IMessaging>();
        }

        public void Encode(byte[] video)
        {
            // do some work here.

            sendMessage();            
        }

        // This is the polymorphic code, at runtime the compiler will decide which type of messaging to call.
        private void sendMessage()
        {
            foreach (var type in messagings)
                type.send("Completed message");
        }

        public void AddChanel(IMessaging channel)
        {
            messagings.Add(channel);
        }
    }

    class MainClass
    {
        public static void Main()
        {
            var encoder = new NewVideoEncoder();
            encoder.AddChanel(new SmsMessage());
            encoder.AddChanel(new MailMessage());

            encoder.Encode(new byte[10]);
        }
    }
}
