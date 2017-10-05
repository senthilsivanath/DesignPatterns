using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class DrawingBoard
    {

        private List<string> shapes = new List<string>();

        public void AddLine()
        {
            this.shapes.Add("Line");
        }

        public void AddCircle()
        {
            this.shapes.Add("Circle");
        }

        public void RestoreDrawingBoard(Memento memento)
        {
            this.shapes = memento.Shapes;
        }

        public Memento SaveDrawingBoard()
        {
            return new Memento(this.shapes);
        }

        public int getShapesCount()
        {
            return this.shapes.Count;
        }
    }
}
