using System;

namespace ControlFlow
{
    enum Season
    {
        Spring = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 3
    }   

    class MainClass
    {
        public static void Main(string[] args)
        {
            var season = Season.Summer;

            switch (season)
            {
                case (Season.Spring):
                case (Season.Summer):
                    Console.WriteLine("Its warm");
                    break;
                case (Season.Autumn):
                    Console.WriteLine("Its fall");
                    break;
                default:
                    Console.WriteLine("Its cold");
                    break;
            }

            // 1- Write a program and ask the user to enter a number.
            // The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".  

            Console.WriteLine("Please enter a number between 1 and 10");
            int result;
            var message = int.TryParse(Console.ReadLine(), out result) ? "Valid" : "Invalid";

            Console.WriteLine($"Results of integer parsing: {message}");
        }
    }
}
