using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class BookKeeper
    {
        private List<Book> books = new List<Book>();

        private ISearchStrategy searchStrategy;

        public void addBook(Book book)
        {
            this.books.Add(book);
        }

        public void searchStragey(ISearchStrategy searchStrategy)
        {
            this.searchStrategy = searchStrategy;
            searchStrategy.SetBooks(this.books);
        }

        public Book searchBook(String bookName)
        {
            return searchStrategy.SearchBook(bookName);
        }
    }
}
