using System;
using System.Collections.Generic;
using System.Linq;

namespace TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];
            string snake = Console.ReadLine();
            int[] shotParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            matrix = InsertInMatrix(matrix, snake, size);
            matrix = ShotImpact(matrix, shotParameters, size);
            matrix = FallDown(matrix, size);
            for (int row = 0; row < size[0]; row++)
            {
                for (int col = 0; col < size[1]; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        private static char[,] FallDown(char[,] matrix, int[] size)
        {
            for (int col = 0; col < size[1]; col++)
            {
                List<char> current = new List<char>();
                for (int row = 0; row < size[0]; row++)
                {
                    current.Add(matrix[row, col]);
                }
                List<char> emptySpaces = current.Where(x => x == ' ').ToList();
                List<char> symbols = current.Where(x => x != ' ').ToList();
                current.Clear();
                current.AddRange(emptySpaces);
                current.AddRange(symbols);
                for (int row = 0; row < size[0]; row++)
                {
                    matrix[row, col] = current[row];
                }
            }
            return matrix;
        }

        private static char[,] ShotImpact(char[,] matrix, int[] shotParameters, int[] size)
        {
            int impactRow = shotParameters[0];
            int impactColumn = shotParameters[1];
            int radius = shotParameters[2];
            matrix[impactRow, impactColumn] = ' ';
            for (int row = 0; row < size[0]; row++)
            {
                for (int col = 0; col < size[1]; col++)
                {
                    if (Math.Pow((row - impactRow), 2) + Math.Pow((col - impactColumn), 2) <= radius * radius)
                        matrix[row, col] = ' ';
                }
            }
            return matrix;
        }
        private static char[,] InsertInMatrix(char[,] matrix, string snake, int[] size)
        {
            int index = 0;
            for (int row = size[0] - 1; row >= 0; row--)
            {
                for (int column = size[1] - 1; column >= 0; column--)
                {
                    matrix[row, column] = snake[index];
                    index++;
                    if (index == snake.Length) index = 0;
                }
            }

            if (size[0] % 2 != 0)
            {
                for (int row = 0; row < size[0]; row++)
                {
                    if (row % 2 != 0)
                    {
                        List<char> list = new List<char>();
                        for (int i = 0; i < size[1]; i++)
                        {
                            list.Add(matrix[row, i]);
                        }

                        list.Reverse();
                        for (int i = 0; i < size[1]; i++)
                        {
                            matrix[row, i] = list[i];
                        }
                    }
                    else continue;
                }
            }
            else
            {
                for (int row = 0; row < size[0]; row++)
                {
                    if (row % 2 == 0)
                    {
                        List<char> list = new List<char>();
                        for (int i = 0; i < size[1]; i++)
                        {
                            list.Add(matrix[row, i]);
                        }

                        list.Reverse();
                        for (int i = 0; i < size[1]; i++)
                        {
                            matrix[row, i] = list[i];
                        }
                    }
                    else continue;
                }
            }
            return matrix;
        }
    }
}
