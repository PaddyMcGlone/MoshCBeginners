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

            var repository = new BookRepository();

            // 1. Without Lambda expressions
            var books = repository.GetBooks();

            // Call a predicate to return the books
            // var cheapbooks = books.FindAll(FindCheapBooks);

            // Add a Lambda expression instead
            var cheapbooks = books.FindAll(b => b.Price < 10);
                
            foreach (var book in cheapbooks)
                Console.WriteLine(book.Title);
        }

        //public static bool FindCheapBooks(Book book)
        //{
        //    return book.Price < 10;
        //}
    }
}
