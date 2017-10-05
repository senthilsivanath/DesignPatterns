using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class LinearSearchStragegy    : ISearchStrategy
    {
        private List<Book> books;

        public void SetBooks(List<Book> books)
        {
            this.books = books;
        }

        public Book SearchBook(string bookName)
        {
            foreach (var book in books)
            {
                if (book.Name.Equals(bookName))
                {
                    return book;
                }
            }
            throw new Exception("Book not found exception");
        }
    }
}
