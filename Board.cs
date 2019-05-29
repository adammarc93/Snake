using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class Board
    {
        public static readonly int minRow = 0;
        public static readonly int minCol = 0;
        public static readonly int maxRow = 23;
        public static readonly int maxCol = 80;

        public static void PaintBoard()
        {
            string spaces = String.Empty;

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(minCol, minRow);
            Console.Write(spaces.PadLeft(maxCol));          //top edge
            Console.SetCursorPosition(minCol, maxRow);
            Console.Write(spaces.PadLeft(maxCol));          //low edge

            for (int i = 0; i < maxRow; i++)
            {
                Console.SetCursorPosition(minCol, i);       //left edge
                Console.Write(" ");
                Console.SetCursorPosition(maxCol - 1, i);   //right edge
                Console.Write(" ");
            }

            WritePoints(0);
            Console.SetWindowPosition(0, 0);
        }

        public static void WritePoints(int points)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(minCol + 1, maxRow);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Wynik = {0}", points);
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}
