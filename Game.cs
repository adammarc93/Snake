using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    static class Game
    {
        static bool gameActive = true;
        static DateTime start = DateTime.Now;
        static int points = 0;
        static Prize prize = new Prize();


        public static void NewGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            gameActive = true;
            points = 0;
            Board.PaintBoard();
            Snake.CreateSnake();
            prize.ShowPrize();
            Play();
        }

        private static void Play()
        {
            while (gameActive)
            {
                ReadKey();
                if (!gameActive)
                {
                    break;
                }

                NewPrize();
                DoesTheSnakeEat();
                if (!gameActive)
                {
                    break;
                }

                SnakeGoes();
                if (!gameActive)
                {
                    break;
                }

                EatPrize();
                Thread.Sleep(100);
            }
        }

        private static void DoesTheSnakeEat()
        {
            if (Snake.DoesTheSnakeEat())
            {
                GameOver();
            }
        }

        private static void EatPrize()
        {
            if (Snake.IsHere(prize.position))
            {
                if (prize.Value == 0)
                {
                    Snake.ClearSnake();
                    Snake.CreateSnake();
                    points = 0;
                }
                else
                {
                    points += prize.Value;
                    Snake.SnakeExtension();
                }

                Board.WritePoints(points);
                prize = new Prize();
                prize.ShowPrize();
            }
        }

        private static void NewPrize()
        {
            if (start <= DateTime.Now.Subtract(TimeSpan.FromSeconds(10)))
            {
                prize.ClearPrize();
                start = DateTime.Now;
                prize = new Prize();
                prize.ShowPrize();
            }
        }

        private static void SnakeGoes()
        {
            if (!Snake.MoveSnake())
            {
                GameOver();
            }
        }

        private static void GameOver()
        {
            ConsoleColor color = Console.ForegroundColor;

            gameActive = false;
            Console.SetCursorPosition(Board.minCol + 34, Board.minRow + 11);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Game over!!!");
            Console.ForegroundColor = color;
            Console.ReadKey();
            Snake.ClearSnake();
        }

        private static void ReadKey()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.LeftArrow && Snake.whereTurn != Direction.right)
                {
                    Snake.whereTurn = Direction.left;
                }

                if (key.Key == ConsoleKey.RightArrow && Snake.whereTurn != Direction.left)
                {
                    Snake.whereTurn = Direction.right;
                }

                if (key.Key == ConsoleKey.UpArrow && Snake.whereTurn != Direction.down)
                {
                    Snake.whereTurn = Direction.up;
                }

                if (key.Key == ConsoleKey.DownArrow && Snake.whereTurn != Direction.up)
                {
                    Snake.whereTurn = Direction.down;
                }
                
                if (key.Key == ConsoleKey.Escape)
                {
                    GameOver();
                }

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
            }
        }
    }
}