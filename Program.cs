using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_14_TrianglesAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Right Triangles".ToUpper());
            Console.ResetColor();
            DrawRightTriangle(5);
            DrawRightTriangle(10);
            DrawRightTriangle(20);
            DrawRightTriangle(30);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nIsosceles Triangles".ToUpper());
            Console.ResetColor();
            DrawIsoscelesTriangle(5);
            DrawIsoscelesTriangle(10);
            DrawIsoscelesTriangle(20);
            DrawIsoscelesTriangle(30);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSquares".ToUpper());
            Console.ResetColor();
            DrawSquare(4);
            DrawSquare(8);
            DrawSquare(16);
            DrawSquare(32);

            ConsoleKey exit;
            do
            {
                exit = Console.ReadKey().Key;

            } while (exit != ConsoleKey.Escape);

        }

        private static void DrawSquare(int height)
        {
            string level = string.Empty;
            for (int lineDrawn = 0; lineDrawn <= height; lineDrawn++)
            {
                if (lineDrawn == 0 || lineDrawn == height)
                {
                    level = new string('*', height * 2);
                    Console.WriteLine(level);
                }
                else
                {
                    level = new string(' ', height * 2);
                    char[] _temp = level.ToCharArray();
                    _temp[0] = '*';
                    _temp[level.Length - 1] = '*';
                    level = new string(_temp);
                    Console.WriteLine(level);
                }
            }
        }

        private static void DrawIsoscelesTriangle(int height)
        {
            string level = string.Empty;

            for (int i = 0; i < height / 2; i++)
            {
                level = new string(' ', height);
                char[] _temp = level.ToCharArray();
                _temp[(height / 2) - i] = '*';
                _temp[(height / 2) + i] = '*';
                level = new string(_temp);
                Console.WriteLine(level);
            }

            level = new string('*', height + 1);
            Console.WriteLine(level);
        }

        private static void DrawRightTriangle(int height)
        {
            string level = string.Empty;
            for (int lineDrawn = 1; lineDrawn <= height; lineDrawn++)
            {
                level = new string('*', lineDrawn);
                Console.WriteLine(level);
            }

        }
    }
}
