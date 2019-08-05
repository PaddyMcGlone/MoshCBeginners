using System;

namespace LambdaExpressions
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine(CalculateSquare(5));
        }

        public static int CalculateSquare(int number)
        {
            return number * number;
        }
    }
}
