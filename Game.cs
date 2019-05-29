using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    static class Game
    {
        static bool gameActive = true;
        static int points = 0;

        public static void NewGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            gameActive = true;
            points = 0;
            Board.PaintBoard();
        }
    }
}
