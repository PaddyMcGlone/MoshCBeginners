using System;

namespace ExtensionMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var myLongString = "My long string which i need shorten to four words";
            var result = myLongString.Shorten(4); // Calling an extension method on string.

            Console.WriteLine($"The first four words are: {result}");
        }        
    }
}
    