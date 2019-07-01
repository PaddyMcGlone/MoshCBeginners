using System;

namespace ControlFlowII
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

            var count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine($"The total number divisable is {count}");

            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.

            int sum = 0;

            while (true)
            {               
                Console.WriteLine("Please enter a number or 'ok' to exit.");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok") break;

                sum += Convert.ToInt32(input);                
            }
            Console.WriteLine($"The total sum is {sum}");
        }
    }
}
