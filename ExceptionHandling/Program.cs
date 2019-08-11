﻿using System;
using System.IO;

namespace ExceptionHandling
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Below is the simple calculator example
            //try
            //{
            //    var calculator = new Calculator();
            //    var result = calculator.Divide(5, 0);

            //    Console.WriteLine($"The result: {result}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry an unexspected exception occurred.");
            //}

            var reader = new StreamReader("C:\Documents\sampletext.txt");

            try
            {
               var text = reader.ReadToEnd();
            }
            catch(Exception ex)
            {
                Console.WriteLine("A problem has occured.");
            }
            finally
            {
                reader.Dispose();
            }
            
        }        
    }
}
