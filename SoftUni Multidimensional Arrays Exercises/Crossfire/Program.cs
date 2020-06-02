using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossfire
{
    class Program
    {
        public static int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        static void Main(string[] args)
        {
            string[,] matrix = new string[input[0], input[1]];
            for (int row = 0; row < input[0]; row++)
            for (int column = 0; column < input[1]; column++)
            {
                matrix[row, column] = Convert.ToString(row * input[1] + column + 1);
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Nuke it from orbit") break;
                else
                {
                    int[] numbers = command.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    if (IndexesAreValid(numbers))
                    {
                        matrix = ShotImpact(matrix, numbers);
                        matrix = SwitchEmptySpaces(matrix);
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                List<string> elements = new List<string>();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    elements.Add(matrix[row, column]);
                }
                if (elements.Any(x => x != " ")) Console.WriteLine(String.Join(" ", elements));
            }
            Console.ReadLine();
        }
        private static bool IndexesAreValid(int[] numbers)
        {
            return Math.Abs(numbers[0]) >= 0 && Math.Abs(numbers[0]) < input[0] && Math.Abs(numbers[1]) >= 0 && Math.Abs(numbers[1]) < input[1];
        }
        private static string[,] SwitchEmptySpaces(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            for (int column = 0; column < matrix.GetLength(1) - 1; column++)
            {
                if (matrix[row, column] == " " && matrix[row, column + 1] != " ")
                {
                    matrix[row, column] = matrix[row, column + 1];
                    matrix[row, column + 1] = " ";
                }
            }
            return matrix;
        }
        private static string[,] ShotImpact(string[,] matrix, int[] numbers)
        {
            int impactRow = numbers[0];
            int impactColumn = Math.Abs(numbers[1]);
            int radius = Math.Abs(numbers[2]);
            matrix[impactRow, impactColumn] = " ";
            matrix = UpImpact(matrix, impactRow, impactColumn, radius);
            matrix = DownImpact(matrix, impactRow, impactColumn, radius);
            matrix = LeftImpact(matrix, impactRow, impactColumn, radius);
            matrix = RightImpact(matrix, impactRow, impactColumn, radius);
            return matrix;
        }
        private static string[,] UpImpact(string[,] matrix, int impactRow, int impactColumn, int radius)
        {
            try
            {
                for (int i = 1; i <= radius; i++)
                {
                    matrix[impactRow - i, impactColumn] = " ";
                }
            }
            catch
            {
                throw new Exception();
            }
            return matrix;
        }
        private static string[,] DownImpact(string[,] matrix, int impactRow, int impactColumn, int radius)
        {
            try
            {
                for (int i = 1; i <= radius; i++)
                {
                    matrix[impactRow + i, impactColumn] = " ";
                }
            }
            catch
            {
                throw new Exception();
            }
            return matrix;
        }
        private static string[,] LeftImpact(string[,] matrix, int impactRow, int impactColumn, int radius)
        {
            try
            {
                for (int i = 1; i <= radius; i++)
                {
                    matrix[impactRow, impactColumn - i] = " ";
                }
            }
            catch
            {
                throw new Exception();
            }
            return matrix;
        }
        private static string[,] RightImpact(string[,] matrix, int impactRow, int impactColumn, int radius)
        {
            try
            {
                for (int i = 1; i <= radius; i++)
                {
                    matrix[impactRow, impactColumn + i] = " ";
                }
            }
            catch
            {
                throw new Exception();
            }
            return matrix;
        }
    }
}
