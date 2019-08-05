using System;

namespace LambdaExpressions
{
    class MainClass
    {
        private const int _factor = 5;

        public static void Main()
        {
            // Making use of the private constant defined earlier.
            //Func<int, int> square = n => n * _factor;
            //Console.WriteLine(square(5));
        }        
    }
}
