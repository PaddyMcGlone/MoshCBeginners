using System;
using System.Collections.Generic;
using System.Globalization;
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

            //while (true)
            //{
            //    Console.WriteLine("Please enter a few numbers separated by a hypen.");
            //    var input = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(input))
            //        break;

            //    var numbers = input.Split('-').Select(n => Convert.ToInt32(n)).ToList().ToList();
            //    var previous = 0;
            //    foreach (var number in numbers)
            //    {
            //        if (previous == number)
            //            Console.WriteLine("Duplicate");

            //        previous = number;
            //    }                    
            //}

            // 3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00).
            // A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok";
            // otherwise, display "Invalid Time".If the user doesn't provide any values, consider it as invalid time.
            //Console.WriteLine("Enter a time value in twenty four hour format.");
            //DateTime time;
            //var result = DateTime.TryParseExact(Console.ReadLine(), "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out time);

            //Console.WriteLine(result ? "Ok" : "Not Ok");

            // 4 - Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.
            // For example, if the user types: "number of students", display "NumberOfStudents".Make sure that the program is not dependent on the input.
            // So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            //Console.WriteLine("Enter a few words separated by a space in order to create a PascalWord.");
            //var pascalWords = Console.ReadLine().Split(' ');
            //var message = "";

            //foreach (var word in pascalWords)
            //    message += word.Replace(word[0], char.ToUpper(word[0]));

            //Console.WriteLine(message);

            // 5 - Write a program and ask the user to enter an English word.Count the number of vowels(a, e, o, u, i) in the word.
            // So, if the user enters "inadequate", the program should display 6 on the console.

            //Console.WriteLine("Please enter a word from the english dictionary.");
            //var word = Console.ReadLine();

            //var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            //var count = 0;

            //foreach (var item in word)            
            //    if (vowels.Contains(item))
            //        count++;

            //Console.WriteLine($"Vowel count for word {word} is {count}");

            // 6. Write a program to ask a user to enter a word. Determine if the word is a plaindrome, if so display 'yes' or 'no'.

            //while (true)
            //{
            //    Console.WriteLine("Please enter a word on the console.");
            //    var input = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(input)) break;

            //    var reversed = string.Join("",input.Reverse());
            //    var message = string.Equals(input, reversed) ? "is" : "is not";
            //    Console.WriteLine($"the word {input} {message} a plaindrome.");
            //}

            while (true)
            {
                Console.WriteLine("Please enter a word on the console.");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;

                var message = input != string.Join("", input.Reverse()) ? "True" : "False";
                Console.WriteLine($"{input} is a plaindrome: {message}");
            }
        }
    }
}
