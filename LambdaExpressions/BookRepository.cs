using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Title = "VW Transporters", Price = 8},
                new Book{Title = "VanLife", Price = 12},
                new Book{Title = "Van detailing", Price = 15}
            };
        }
    }
}
