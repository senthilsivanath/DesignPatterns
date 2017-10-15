using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            WhiteBoard board = new WhiteBoard();

            DrawLineCommand drawLineCommand = new DrawLineCommand(board);
            drawLineCommand.Start = 1;
            drawLineCommand.End = 2;
            drawLineCommand.Color = "red";

            DrawRectangleCommand drawRectangleCommand = new DrawRectangleCommand(board);
            drawRectangleCommand.Start = new Tuple<int, int>(0, 0);
            drawRectangleCommand.End = new Tuple<int, int>(3, 3);
            drawRectangleCommand.Color = "blue";

            CommandManager commandManager = new CommandManager();
          
            commandManager.ExecuteCommand(drawRectangleCommand);
            commandManager.ExecuteCommand(drawLineCommand);

            Console.WriteLine("Board shape");
            board.showWhiteBoard();
            commandManager.Undo();
            Console.WriteLine("After Undo");
            board.showWhiteBoard();
            commandManager.Undo();
            Console.WriteLine("Clean Undo");
            board.showWhiteBoard();


        }
    }
}
