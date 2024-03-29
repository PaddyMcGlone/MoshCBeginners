﻿using System.Collections.Generic;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Title = "Lowdown transporters",          Price = 10.99f},
                new Book {Title = "Transporter HQ",                Price = 9.99f },
                new Book {Title = "VW Transporter Haynes mannual", Price = 6     }
            };
        }
    }
}