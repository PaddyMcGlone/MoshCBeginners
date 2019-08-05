using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Title = "VW Transporters"},
                new Book{Title = "VanLife"},
                new Book{Title = "Van detailing"}
            };
        }
    }
}
