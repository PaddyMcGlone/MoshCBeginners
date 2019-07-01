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
            //var season = Season.Summer;

            //switch (season)
            //{
            //    case (Season.Spring):
            //    case (Season.Summer):
            //        Console.WriteLine("Its warm");
            //        break;
            //    case (Season.Autumn):
            //        Console.WriteLine("Its fall");
            //        break;
            //    default:
            //        Console.WriteLine("Its cold");
            //        break;
            //}

            // 1- Write a program and ask the user to enter a number.
            // The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".  
            //Console.WriteLine("Please enter a number between 1 and 10");
            //int result;
            //var message = int.TryParse(Console.ReadLine(), out result) ? "Valid" : "Invalid";

            //Console.WriteLine($"Results of integer parsing: {message}");

            // 2- Write a program which takes two numbers from the console and displays the maximum of the two.
            //Console.WriteLine("Please enter two numbers sperated by a space:");
            //var input = Console.ReadLine().Split(' ');
            //var number1 = Convert.ToInt32(input[0]);
            //var number2 = Convert.ToInt32(input[1]);

            //var largest = number1 > number2 ? number1 : number2;
            //Console.WriteLine($"The largest number between {number1} and {number2} is {largest}");

            // 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.            
            //Console.WriteLine("Please enter image width");
            //var width = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter image height");
            //var height = Convert.ToInt32(Console.ReadLine());

            //var type = width > height ? "Landscape" : "Portrait";
            //Console.WriteLine($"The image is {type}");            

            //4 - Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            //Write a program that asks the user to enter the speed limit.
            //Once set, the program asks for the speed of a car.
            //If the user enters a value less than the speed limit, program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the number of demerit points.
            //For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            //If the number of demerit points is above 12, the program should display License Suspended.

            //Console.WriteLine("Please enter the current speed limit.");
            //var limit = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter the speed of a car.");
            //var carSpeed = Convert.ToInt32(Console.ReadLine());

            //if (carSpeed < limit)
            //    Console.WriteLine("Ok");

            ////int points = 1;
            //int points = (carSpeed - limit) / 5;

            //if (points > 12)
            //    Console.WriteLine("Licence Suspended");
            //else
            //    Console.WriteLine($"Current points {points}");

            // Loop examples & controlling flow.
            //while (true)
            //{
            //    Console.WriteLine("Please enter your name, enter n/a to terminate.");
            //    var name = Console.ReadLine();

            //    if (String.Equals(name.ToLower(), "n/a")) break;

            //    Console.WriteLine($"Echo: {name}");
            //}

            // The continue statement forces the loop of execution to return to the top.
            //while (true)
            //{
            //    Console.WriteLine("Please enter your name, enter n/a to terminate.");
            //    var name = Console.ReadLine();

            //    if (!String.Equals(name.ToLower(), "n/a"))
            //    {
            //        Console.WriteLine($"Echo: {name}");
            //        continue;
            //    }

            //    break;
            //}

            // Use the random class to create 'Random ten numbers'
            var random = new Random();
            var numbers = new int[10];

            for (int i = 0; i < 10; i++)            
                numbers[i]= random.Next(10);

            Console.WriteLine(string.Join(" - ", numbers));
        }
    }
}
