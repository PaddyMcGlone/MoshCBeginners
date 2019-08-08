using System;

namespace ExtensionMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var myLongString = "My long string which i need shorten to four words";
            var result = myLongString.Shorten(4); // Calling an extension method on string.
        }        
    }

    // Extensions have to be a static class
    // Naming convention is classname followed by extensions.
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            return "";
        }
    }
}
    