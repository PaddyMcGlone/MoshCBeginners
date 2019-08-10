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

            //Console.WriteLine(dateTime.GetValueOrDefault());
            //Console.WriteLine(dateTime.HasValue);
            //Console.WriteLine(dateTime.Value);

            DateTime? newDate = null;
            DateTime date2;

            if (newDate != null)            
                date2 = newDate.GetValueOrDefault();            
            else            
                date2 = DateTime.Today;

            // There is a better way to write this code

            date2 = newDate ?? DateTime.Today;
        }
    }
}
