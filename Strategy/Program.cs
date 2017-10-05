using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // A Bookeeper accept several books and later when a book has to be checked whether it already exists
            // Two strategy a. linear search
            // b. dictionary based

            BookKeeper bookKeeper = new BookKeeper();
            bookKeeper.addBook(new Book() { Name = "Let us C", Author = "Yashwanth Kanithkar" });
            bookKeeper.addBook(new Book() { Name = "Crack the coding interview", Author = "Mcdowell" });

            bookKeeper.searchStragey(new LookupStrategy());

            Book book = bookKeeper.searchBook("Let us C");

            Console.WriteLine("Found a book using lookup strategy "+book);

            bookKeeper.searchStragey(new LinearSearchStragegy());

            book = bookKeeper.searchBook("Let us C");
            Console.WriteLine("Found a book using linear strategy " + book);
        }
    }
}
