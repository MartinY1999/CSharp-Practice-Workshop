using System;
using System.Collections.Generic;
using System.Linq;

namespace StringMatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {'(', ')'}, StringSplitOptions.RemoveEmptyEntries);
            int degrees = (int.Parse(input[1]) / 90) % 4;
            List<string> words = new List<string>();
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "END") break;
                else words.Add(word);
            }
            char[,] matrix = new char[words.Count, words.OrderByDescending(x => x.Length).First().Length];
            FillMatrix(matrix, words);
            RotateMatrix(matrix, degrees, words);
        }
        private static void RotateMatrix(char[,] matrix, int degrees, List<string> words)
        {
            switch (degrees)
            {
                case 0:
                    PrintMatrixType1(matrix);
                    break;
                case 1:
                    matrix = RotateAt90Degrees(ref matrix, words);
                    PrintMatrixType1(matrix);
                    break;
                case 2:
                    char[][] jMatrix = RotateAt180Degrees(ref matrix);
                    PrintMatrixType2(jMatrix);
                    break;
                case 3:
                    matrix = RotateAt270Degrees(ref matrix, words);
                    PrintMatrixType1(matrix);
                    break;
            }
        }
        private static void PrintMatrixType2(char[][] jMatrix)
        {
            foreach (char[] row in jMatrix)
            {
                Console.WriteLine(String.Join("", row));
            }
            Console.ReadLine();
        }
        private static void PrintMatrixType1(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        private static char[,] RotateAt90Degrees(ref char[,] matrix, List<string> words)
        {
            char[,] dMatrix = new char[matrix.GetLength(1), matrix.GetLength(0)];
            int counter = words.Count - 1;
            for (int col = 0; col < dMatrix.GetLength(1); col++)
            {
                for (int row = 0; row < dMatrix.GetLength(0); row++)
                {
                    try
                    {
                        dMatrix[row, col] = words[counter][row];
                    }
                    catch
                    {
                        dMatrix[row, col] = ' ';
                    }
                }
                counter--;
            }
            return dMatrix;
        }
        private static char[][] RotateAt180Degrees(ref char[,] matrix)
        {
            char[][] jMatrix = new char[matrix.GetLength(0)][];
            int counter = 0;
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                List<char> reversed = new List<char>();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    reversed.Add(matrix[row, col]);
                }
                reversed.Reverse();
                jMatrix[counter] = reversed.ToArray();
                counter++;
            }
            return jMatrix;
        }
        private static char[,] RotateAt270Degrees(ref char[,] matrix, List<string> words)
        {
            char[,] dMatrix = new char[matrix.GetLength(1), matrix.GetLength(0)];
            for (int col = 0; col < dMatrix.GetLength(1); col++)
            {
                int counter = 0;
                for (int row = dMatrix.GetLength(0) - 1; row >= 0; row--)
                {
                    try
                    {
                        dMatrix[row, col] = words[col][counter];
                    }
                    catch
                    {
                        dMatrix[row, col] = ' ';
                    }
                    counter++;
                }
            }
            return dMatrix;
        }
        private static void FillMatrix(char[,] matrix, List<string> words)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    try
                    {
                        matrix[row, column] = words[row][column];
                    }
                    catch
                    {
                        matrix[row, column] = ' ';
                    }
                }
            }
        }
    }
}
