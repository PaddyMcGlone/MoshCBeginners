using System;
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

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(@"C:\Documents\sampletext.txt");
                var text = reader.ReadToEnd();

               throw new Exception("An exception has occured!");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"A problem has occured : {ex.Message}.");
            }
            finally
            {
                if (reader != null)                
                    reader.Dispose();
            }
            
        }        
    }
}
