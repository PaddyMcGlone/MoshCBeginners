﻿using System;

namespace ExceptionHandling
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);

                Console.WriteLine($"The result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry an unexspected exception occurred.");
            }
            
        }        
    }
}
