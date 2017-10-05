using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Iterator : IIterator
    {

        private int index = 0;

        public CustomList list { get; set; }

        public Iterator(CustomList list)
        {
            this.list = list;
        }

        public void moveNext()
        {
            
            index++;
        }

        public bool hasNext()
        {
            return index < list.Elements.Count;
        }

        public object getCurrent()
        {
            return list.Elements.ElementAt(index);
        }
    }
}
