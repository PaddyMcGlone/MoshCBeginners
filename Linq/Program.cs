using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Linq Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 8
                               orderby b.Title
                               select b.Title;

            // Linq Extension Methods
            var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);

            foreach (var book in cheapBooks)
                Console.WriteLine(book);
        }
    }
}
