using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    static class Menu
    {
        public static void StartMenu()
        {
            Console.Title = "Snake";
            Console.SetBufferSize(Board.maxCol, Board.maxRow + 3);
            Console.SetWindowSize(Board.maxCol, Board.maxRow + 1);

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.SetCursorPosition(Board.minCol + 20, Board.minRow + 1);
                Console.Write(">>> C o n s o l e  S n a k e <<<");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(Board.minCol + 28, Board.minRow + 10);
                Console.Write("1 - Start game");
                Console.SetCursorPosition(Board.minCol + 28, Board.minRow + 12);
                Console.Write("2 - Exit");
                Console.ForegroundColor = ConsoleColor.White;

                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Game.NewGame();
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D2:
                        Console.Clear();
                        return;
                    defoult:
                        break;
                }
            }
        }
    }
}