using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingBoard drawingBoard = new DrawingBoard();
            drawingBoard.AddCircle();
            drawingBoard.AddLine();

            Memento m = drawingBoard.SaveDrawingBoard();

            DrawingBoard newDrawingBoard = new DrawingBoard();
            Console.WriteLine("Before restoring "+newDrawingBoard.getShapesCount());

            newDrawingBoard.RestoreDrawingBoard(m);

            Console.WriteLine("After restoring "+newDrawingBoard.getShapesCount());

        }
    }
}
