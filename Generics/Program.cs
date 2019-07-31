using System;

namespace Generics
{
    // Creating a Generic class with Icomparable constraint
    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // Creating a generic method and implementing the compare to method.
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    // Constraint for a class
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
    }

    public class Book
    {
        public string ISBN { get; set; }
    }

    // Adding object constraint
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    // Working with value type constraints
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            return HasValue ? (T)_value : default(T);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Testing the struc constraint
            var number = new Nullable<int>(5);
            Console.WriteLine($"Has value: {number.HasValue}");
            Console.WriteLine($"The value: {number.GetValueOrDefault()}");
        }
    }
}
