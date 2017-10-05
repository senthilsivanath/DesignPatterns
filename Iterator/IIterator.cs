using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IIterator
    {
        void moveNext();

        bool hasNext();

        object getCurrent();
    }
}
