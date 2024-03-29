﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndlistsII
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
            //    If no one likes your post, it doesn't display anything.
            //    If only one person likes your post, it displays: [Friend's Name] likes your post.
            //    If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //    If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.


            //    Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
            //    Depending on the number of names provided, display a message based on the above pattern.


            //var names = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Please enter a name:");
            //    var name = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(name)) break;

            //    names.Add(name);
            //}

            //if(names.Count == 1)
            //    Console.WriteLine($"{names[0]} likes your post");
            //else if(names.Count == 2)
            //    Console.WriteLine($"{names[0]}, {names[1]} like your post");
            //else
            //    Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post");


            // 2- Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string.
            // Display the reversed name on the console.

            //Console.WriteLine("Please enter your name");
            //var input = Console.ReadLine();
            //var length = input.Length - 1;
            //var result1 = "";

            //for (int i = length; i >= 0; i--)
            //    result1 += input[i];

            //Console.WriteLine($"First attempt at reversing {result1}");


            //Console.WriteLine("Please enter your name again!");
            //var nameArray = Console.ReadLine().ToCharArray();
            //Array.Reverse(nameArray);

            //Console.WriteLine($"Second attempt at reversing {string.Join("",nameArray)}");

            // 3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered,
            // display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            //var count = 1;
            //var numbers = new List<int>();
            //do
            //{
            //    Console.WriteLine("Please enter a number");
            //    var number = Convert.ToInt32(Console.ReadLine());

            //    if (numbers.Contains(number))
            //    {
            //        Console.WriteLine("Number previously entered, please re-try");
            //        continue;
            //    }

            //    numbers.Add(number);
            //    count++;
            //}
            //while (count <= 5);

            //numbers.Sort();
            //Console.WriteLine($"Sorted numbers {string.Join("-",numbers)}");

            // 4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            // The list of numbers may include duplicates.Display the unique numbers that the user has entered.

            //var numbers = new List<int>();
            //while (true)
            //{
            //    Console.WriteLine("Please enter a number or type 'quit'");
            //    var input = Console.ReadLine();

            //    if (string.Equals(input.ToLower(), "quit")) break;

            //    numbers.Add(Convert.ToInt32(input));               
            //}

            //Console.WriteLine($"Your numbers {String.Join("-",numbers)}");

            // 5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
            // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            // otherwise, display the 3 smallest numbers in the list.
            
            while (true)
            {
                Console.WriteLine("Please supply a comma seperated list of numbers");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || input.Length < 5)
                {
                    Console.WriteLine("Invalid List please re-enter");
                    continue;
                }

                var numbers = input.Split('-').Select(n => Convert.ToInt32(n)).ToList();
                numbers.Sort();
                Console.WriteLine($"The three smallest numbers {string.Join(",",numbers.Take(3))}");
                break;
            }

            
        }
    }
}
