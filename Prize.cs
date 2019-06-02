using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Prize
    {
        public int Value { get; private set; }
        public Point position { get; set; }

        public Prize()
        {
            Random generator = new Random();

            Value = generator.Next(0, 6);
            position.X = generator.Next(Board.minCol + 1, Board.maxCol - 2);
            position.Y = generator.Next(Board.minRow + 1, Board.maxRow - 1);
        }

        public void ShowPrize()
        {
            ConsoleColor color = Console.ForegroundColor;

            Console.SetCursorPosition(position.X, position.Y);
            if (Value == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public void ClearPrize()
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write(" ");
        }
    }
}