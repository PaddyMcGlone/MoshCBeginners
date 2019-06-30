using System;

namespace NonPrimitiveType
{
    public enum DeliveryMethods
    {
        AirMail = 0,
        ByHand  = 1,
        Drone   = 2
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Creating string
            var firstName = "Patrick";
            var lastName = "McGlone";

            Console.WriteLine(String.Format("{0} {1}", firstName, lastName));

            // Using String.Join
            var myNumbers = new[] { 1, 2, 3, 4, 5, 6, 100, 200, 300 };
            Console.WriteLine(string.Join(" - ", myNumbers)); // Join takes an array as a second argument.

            // Treat strings as Arrays
            var myName = "Patrick";
            Console.WriteLine($"The first char in {myName} is {myName[0]}");

            // Example below of how strings are immutable.
            //myName[0] = "T";

            // Verbatim strings
            var message = @"Hello Patrick,
                            Thank you for submitting your letter
                            It was delivered this morning

                            Speak soon,
                            Patrick";

            Console.WriteLine(message);

            // Convert the enum to its integer value
            var myEnum = DeliveryMethods.Drone;
            Console.WriteLine($"Enum value of {myEnum} is = {Convert.ToInt32(myEnum)}");
        }
    }
}
