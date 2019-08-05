using System;

namespace LambdaExpressions
{
    class MainClass
    {
        public static void Main()
        {
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));            
        }

        public static int CalculateSquare(int number)
        {
            return number * number;
        }
    }
}
