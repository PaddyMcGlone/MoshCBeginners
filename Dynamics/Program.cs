using System;

namespace Dynamics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // A simple example of dynamic types
            dynamic myString = "PaddyMcGlone";
            myString = 100;


            dynamic a = 10;
            dynamic b = 100;

            // At compile time, result will be set to type dynamic.
            var result = b - a;        
        }
    }
}
