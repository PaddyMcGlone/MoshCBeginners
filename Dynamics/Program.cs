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


            _ = Console.WriteLine(myString);
        }
    }
}
