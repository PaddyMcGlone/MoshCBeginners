using System;
using System.Linq;

namespace ExtensionMethods
{
    // Extensions have to be a static class
    // Naming convention is classname followed by extensions.
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords == 0)
                return "";

            // Adding a .Take() to lift the fist number of words.
            return String.Join(" ", str.Split(' ').Take(numberOfWords));
        }
    }
}
