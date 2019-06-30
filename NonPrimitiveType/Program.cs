using System;

namespace NonPrimitiveType
{
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
            Console.WriteLine(string.Join(" - ", myNumbers));
        }
    }
}
