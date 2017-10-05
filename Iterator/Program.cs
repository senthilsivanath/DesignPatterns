using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            list.Elements = new List<string>() { "Hey", "How", "Are", "Doing" };

            IIterator iterator = list.getIterator();
            while (iterator.hasNext())
            {
                Console.WriteLine("Current Value " + iterator.getCurrent());
                iterator.moveNext();
            }


        }
    }
}
