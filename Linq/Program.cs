﻿using System;
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
            var cheapBooks = books.Where(b => b.Price < 10);

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + ' ' + book.Price);
        }
    }
}
