using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    interface ISearchStrategy
    {
        void SetBooks(List<Book> books);

        Book SearchBook(string bookName);
    }
}
