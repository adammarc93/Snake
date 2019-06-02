using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        private static LinkedList<Point> snakeBody = new LinkedList<Point>();
        public static Direction whereTurn;

        public static void CreateSnake()
        {
            for (int i = 1; i < 10; i++)
            {
                snakeBody.AddFirst(new Point(i, Board.minRow + 6));
                whereTurn = Direction.right;
                DrawSnake();
            }
        }

        public static void DrawSnake()
        {
            foreach (var point in snakeBody)
            {
                DrawPoint(point);
            }
        }

        public static void DrawPoint(Point point)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write("*");
        }

        public static void ClearPoint(Point point)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write(" ");
        }

        public static void ClearSnake()
        {
            foreach (var point in snakeBody)
            {
                ClearPoint(point);
            }

            snakeBody.Clear();
        }

        public static void ShiftForTheHead(ref int vertical, ref int horizontal)
        {
            if (whereTurn == Direction.right)
            {
                horizontal = 1;
            }
            else if (whereTurn == Direction.left)
            {
                horizontal = -1;
            }
            else if (whereTurn == Direction.up)
            {
                vertical = -1;
            }
            else if (whereTurn == Direction.down)
            {
                vertical = 1;
            }
        }

        private static void MakeMove()
        {
            int shiftHorizontal = 0;
            int shiftVertical = 0;
            Point point = new Point();

            ClearPoint(snakeBody.Last.Value);
            snakeBody.RemoveLast();
            ShiftForTheHead(ref shiftVertical, ref shiftHorizontal);
            point.Y = snakeBody.First.Value.Y + shiftVertical;
            point.X = snakeBody.First.Value.X + shiftHorizontal;
            snakeBody.AddFirst(point);
            DrawPoint(point);
        }

        public static bool MoveSnake()
        {
            bool moveAllowed = true;

            if ((whereTurn == Direction.right && snakeBody.First.Value.X >= Board.maxCol - 2) ||
                (whereTurn == Direction.left && snakeBody.First.Value.X <= Board.minCol + 1) ||
                (whereTurn == Direction.up && snakeBody.First.Value.Y <= Board.minRow + 1) ||
                (whereTurn == Direction.down && snakeBody.First.Value.Y >= Board.maxRow - 1))
            {
                moveAllowed = false;
            }
            else
            {
                MakeMove();
            }

            return moveAllowed;
        }

        public static void SnakeExtension()
        {
            int shiftHorizontal = 0;
            int shiftVertical = 0;
            Point point = new Point();

            ShiftForTheTail(ref shiftVertical, ref shiftHorizontal);
            point.X = snakeBody.First.Value.X + shiftVertical;
            point.Y = snakeBody.First.Value.Y + shiftHorizontal;
            snakeBody.AddLast(point);
            DrawPoint(point);
        }

        private static void ShiftForTheTail(ref int vertical, ref int horizontal)
        {
            ShiftForTheHead(ref vertical, ref horizontal);
            vertical = vertical * (-1);
            horizontal = horizontal * (-1);
        }

        internal static bool DoesTheSnakeEat()
        {
            bool result = false;
            bool firstPoint = true;

            foreach (var point in snakeBody)
            {
                if (!firstPoint)
                {
                    if (snakeBody.First.Value.X == point.X && snakeBody.First.Value.Y == point.Y)
                    {
                        result = true;
                        break;
                    }

                    firstPoint = false;
                }
            }

            return result;
        }

        public static bool IsHere(Point prizePoint)
        {
            bool result = false;

            foreach (var snakePoint in snakeBody)
            {
                if (snakePoint.X == prizePoint.X && snakePoint.Y == prizePoint.Y)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}