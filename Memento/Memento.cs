using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Memento
    {

        private List<string> shapes;

        public List<string> Shapes
        {
            get { return shapes; }
        }

        public Memento(List<string> shapes)
        {
            this.shapes = shapes;
        }

        public Memento getLastSavedMemento()
        {
            return this;
        }
    }
}
