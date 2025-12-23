using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced
{
    internal class EnumerableBooks : IEnumerable<BookItem>
    {
        private readonly List<BookItem> _books = new();

        public void AddBookItem(string title, string author, double price)
        {
            _books.Add(new BookItem { Title = title, Author = author, Price = price });
        }

        public IEnumerator<BookItem> GetEnumerator()
        {
            foreach (var book in _books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Indexer by position
        public BookItem this[int index]
        {
            get => _books[index];
        }

        // Indexer by title
        public BookItem this[string title]
        {
            get
            {
                var book = _books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                return book == null ? throw new ArgumentNullException("Book not found") : book;
            }
        }
    }
}
