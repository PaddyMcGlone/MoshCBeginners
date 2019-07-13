using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var message = "Christina Maire McGlone";
            //var newString = message.Substring(10, 5);

            //var startingPoint = message.IndexOf('e');
            //var endingPoint = message.LastIndexOf('e');

            //Console.WriteLine(newString);
            //Console.WriteLine($"{startingPoint}, {endingPoint}");

            //var myMistake = "Paztrick";
            //myMistake = myMistake.Replace("Paztrick", "Pat");

            //Console.WriteLine(myMistake);

            //// Retrieve FirstName and LastName
            //var name = "Patrick McGlone";
            //var nameArray = name.Split(' ');
            //var firstName = nameArray[0];
            //var lastName = nameArray[1];

            //Console.WriteLine(firstName);
            //Console.WriteLine(lastName);

            //// String builder
            //var builder = new StringBuilder();
            //builder.Append('-', 20); // Append to add the text 
            //builder.AppendLine();    // Append line to add a new line to the text
            //builder.Append("Header text");
            //builder.AppendLine();
            //builder.Append('-', 20);

            //Console.WriteLine(builder);

            //1. Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
            //   For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            // Prompt
            //Console.WriteLine("Please enter a few numbers separated by a hypen.");
            //var input = Console.ReadLine();

            //var numbers = input.Split('-').Select(n => Convert.ToInt32(n)).ToList();            

            //var previousNumber = numbers[0];
            //var message = "";
            //foreach (var currentNumber in numbers)
            //{
            //    message = currentNumber > previousNumber ? "Consecutive" : "Not Consecutive";
            //    previousNumber = currentNumber;
            //}

            //Console.WriteLine($"The numbers you entered are {message}");

            // 2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            // If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
            // If so, display "Duplicate" on the console.

            while (true)
            {
                Console.WriteLine("Please enter a few numbers separated by a hypen.");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                var numbers = input.Split('-').Select(n => Convert.ToInt32(n)).ToList().ToList();
                var previous = 0;
                foreach (var number in numbers)
                {
                    if (previous == number)
                        Console.WriteLine("Duplicate");

                    previous = number;
                }                    
            }            
        }
    }
}
