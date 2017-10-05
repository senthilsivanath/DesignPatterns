using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Book
    {
        public String Name { get; set; }

        public String Author { get; set; }

        public override string ToString()
        {
            return "Book Name "+ Name + " Author Name " + Author;
        }
    }
}
