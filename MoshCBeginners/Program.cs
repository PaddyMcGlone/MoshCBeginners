using System;

namespace MoshCBeginners
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Implicit type conversion
            //byte myByte = 255;
            //int myInt = myByte;

            //Console.WriteLine("Implicit type conversion =  "+ myInt);

            // Explicit type conversion
            //byte myByte = 0;
            //int myInt = 200;

            //myByte = (byte)myInt;
            //Console.WriteLine("Explicit type conversion = " + myByte);

            // Convert string to an int
            string myString = "100";
            int myInt = Convert.ToInt32(myString);

            Console.WriteLine($"Convert class = {myInt}");

            // Convert string to a boolean
            string myBooleanString = "True";
            bool myBool = Convert.ToBoolean(myBooleanString);
            
            Console.WriteLine(myBool ? "Correct" : "False");
        }
    }
}
