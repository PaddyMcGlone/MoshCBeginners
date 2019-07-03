using System;
using System.Linq;

namespace ControlFlowII
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

            //var count = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //        count++;
            //}

            //Console.WriteLine($"The total number divisable is {count}");

            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.

            //int sum = 0;

            //while (true)
            //{               
            //    Console.WriteLine("Please enter a number or 'ok' to exit.");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "ok") break;

            //    sum += Convert.ToInt32(input);                
            //}
            //Console.WriteLine($"The total sum is {sum}");

            //3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            //    For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            //Console.WriteLine("Please enter a number");
            //var input = Convert.ToInt32(Console.ReadLine());
            //var total=input;

            //for (int i = input-1; i > 0; i--)
            //    total *= i;

            //Console.WriteLine($"The factorial total: {total}");

            // 4 - Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.If the user guesses the number,
            // display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            //var random = new Random();
            //var number = random.Next(1, 10);

            //Console.WriteLine($"Random number is :{number}");
            //var count = 1;

            //while(count<=4)
            //{
            //    Console.WriteLine("Please guess the random number:");
            //    var attempt = Convert.ToInt32(Console.ReadLine());

            //    if (attempt == number) break;

            //    count++;
            //}

            //Console.WriteLine(count <= 4 ? "You won" : "You lost");

            //5 - Write a program and ask the user to enter a series of numbers separated by comma.
            //    Find the maximum of the numbers and display it on the console. For example,
            //    if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Please enter a series of number seperated by a comma.");
            var numbersArray = Console.ReadLine().Split('-').Select(n => Convert.ToInt32(n)).ToArray();
            var largest = 0;

            foreach (var current in numbersArray)
                largest = current > largest ? current : largest;

            Console.WriteLine($"The largest number was {largest}");
        }
    }
}
