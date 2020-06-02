using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private readonly IList<Book> books;

        public Library(params Book[] books)
        {
            this.books = books;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return this.books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly IList<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public Book Current => this.books[currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
                throw new System.NotImplementedException();
            }

            public bool MoveNext()
            {
                return (++currentIndex) < this.books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
