using System;

namespace Inheritance
{
    public class Shape
    {
        public string Area { get; set; }
    }

    public class Circle : Shape
    {
        public string Radius { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Downcasting example
            var myShape = new Shape();
            myShape = new Circle();


            // In order to prevent the invalid cast exception we can use the 'as' keyword
            Shape newShape = (Circle) new Shape(); // Will return an exception if we cannot cast

            newShape  = newShape as Circle; // 'as' keyword will not return exception, instead will allow compilation to continue.
            if(newShape != null)
            {
                //... Do some work.
            }


            // We can use the 'is' keyword to work out if an object is a certain type
            if(newShape is Shape)
            {
                //... Do some work
            }

            // In C# - Upcasting is implicit, theres no need to define the resulting type.
            // Downcasting however is explicit and you need to define the resulting type.


            // C# types
            // There are two types within .Net
            // 1.Values types - all primitive types and are stored on the stack (managed reserved memory).
            // 2.Reference type - All classes instances, these are reside within the heap.


            // Boxing
            // This is the process of converting a value type to an class instance (object).

            int number = 100; // Value type stored in the stack
            object myObject = number; // Value type moved to clr then stored as object on the heap.

            // Unboxing
            // This is a process of taking an object from the heap and converting to variable on the stack
            object obj = 10;
            int newNumber = (int)obj;


        }
    }
}
