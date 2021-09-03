using IteratorsAndComparators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Library : IEnumerable<Book>
    {
        private readonly IList<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            //return books.GetEnumerator();

            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
