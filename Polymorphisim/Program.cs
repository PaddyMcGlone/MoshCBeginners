using System;

namespace Polymorphisim
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("The base class draw.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle.");
        }
    }

    // Below is an example of polymorphisim, we are overriding the method draw for our specific purposes.

    class MainClass
    {
        public static void Main(string[] args)
        {
            var shape = new Shape();
            shape.Draw();

            var circle = new Circle();
            circle.Draw();
        }
    }

    // The Benifit of this approach is we could add another class and it wouldnt have any effect on the shape class nor the other sister child classes.
    // This is an example of a perfect lose couple relationship, we can make a change and it doesnt effect other areas of the application.


    // Abstract classes
    // This is where within the base class we do not define the method implementation, as it is too hard to define a 'draw' method for all the different types
    // of shapes.

    public abstract class AbstractShape
    {
        // No implementation details
        public abstract void Draw();
        
    }

    public class NewCircle : AbstractShape
    {
        public override void Draw()
        {
            Console.WriteLine("Adding new implementation details.");
        }
    }

    // What is a sealed class?
    // A sealed class in .Net prevents other classes from inheriting this class. It seals its behaviour.
    // A seal is like the .pdf version of a class.
}
