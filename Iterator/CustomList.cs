using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class CustomList : IIteratable
    {

        private List<string> elements;

        public List<string> Elements
        {
            get { return elements; }
            set { elements = value; }
        }

        public IIterator getIterator()
        {
            return new Iterator(this);
        }
    }
}
