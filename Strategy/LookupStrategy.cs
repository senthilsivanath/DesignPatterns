using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class LookupStrategy  : ISearchStrategy
    {

        private Dictionary<String, Book> bookDictionary = new Dictionary<string, Book>();

        public void SetBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                this.bookDictionary.Add(book.Name, book);
            }
        }

        public Book SearchBook(string bookName)
        {
            return this.bookDictionary[bookName];
        }
    }
}
