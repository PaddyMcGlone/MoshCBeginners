using System;

namespace NullableTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Value type cannot hold a null value
            //DateTime dateTime = null;

            // Adding the Nullable<> prefix allows the null value to be held.
            Nullable<DateTime> dateTime = null;

            Console.WriteLine(dateTime.GetValueOrDefault());
            Console.WriteLine(dateTime.HasValue);
            Console.WriteLine(dateTime.Value);
        }
    }
}
