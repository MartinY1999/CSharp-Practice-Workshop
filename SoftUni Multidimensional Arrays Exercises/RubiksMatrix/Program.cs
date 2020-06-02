using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;

namespace RubiksMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rc = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int countOfCommands = int.Parse(Console.ReadLine());
            int matrixElement = 1;
            int[,] matrix = new int[rc[0], rc[1]];
            for (int row = 0; row < rc[0]; row++)
            for (int column = 0; column < rc[1]; column++)
            {
                matrix[row, column] = matrixElement;
                matrixElement++;
            }
            while (countOfCommands > 0)
            {
                string[] command = Console.ReadLine().Split(' ');
                matrix = Shuffle(matrix, command, rc);
                countOfCommands--;
            }
            SwapPlaces(matrix);
            Console.ReadLine();
        }
        private static void SwapPlaces(int[,] matrix)
        {
            int rightNumber = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (matrix[row, column] == rightNumber) Console.WriteLine("No swap required");
                else
                {
                    int toMove = matrix[row, column];
                    for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
                    for (int column1 = 0; column1 < matrix.GetLength(1); column1++)
                    {
                        if (matrix[row1, column1] == rightNumber)
                        {
                            matrix[row, column] = matrix[row1, column1];
                            matrix[row1, column1] = toMove;
                            Console.WriteLine($"Swap ({row}, {column}) with ({row1}, {column1})");
                            goto Done;
                        }
                    }
                }
                Done:;
                rightNumber++;
            }
        }
        private static int[,] Shuffle(int[,] smatrix, string[] command, int[] rc)
        {
            int current = int.Parse(command[0]);
            int times = int.Parse(command[2]);
            switch (command[1])
            {
                case "up":               
                    smatrix = Up(smatrix, current, times, rc);
                    break;
                case "down":
                    smatrix = Down(smatrix, current, times, rc);
                    break;
                case "left":
                    smatrix = Left(smatrix, current, times, rc);
                    break;
                case "right":
                    smatrix = Right(smatrix, current, times, rc);
                    break;
                default:
                    break;
            }
            return smatrix;
        }
        private static int[,] Right(int[,] matrix, int currentRow, int times, int[] rc)
        {
            List<int> kys = new List<int>();
            for (int col = 0; col < rc[1]; col++)
            {
                kys.Add(matrix[currentRow, col]);
            }
            int[] shuffle = kys.ToArray();
            for (int i = 1; i <= times; i++)
            {
                int start = shuffle[shuffle.Length - 1];
                Array.Copy(shuffle, 0, shuffle, 1, shuffle.Length - 1);
                Array.Clear(shuffle, 0, 1);
                shuffle[0] = start;
            }
            for (int col = 0; col < rc[1]; col++)
            {
                matrix[currentRow, col] = shuffle[col];
            }
            return matrix;
        }
        private static int[,] Left(int[,] matrix, int currentRow, int times, int[] rc)
        {
            List<int> kys = new List<int>();
            for (int col = 0; col < rc[1]; col++)
            {
                kys.Add(matrix[currentRow, col]);
            }
            int[] shuffle = kys.ToArray();
            for (int i = 1; i <= times; i++)
            {
                int end = shuffle[0];
                Array.Copy(shuffle, 1, shuffle, 0, shuffle.Length - 1);
                Array.Clear(shuffle, shuffle.Length - 1, 1);
                shuffle[shuffle.Length - 1] = end;
            }
            for (int col = 0; col < rc[1]; col++)
            {
                matrix[currentRow, col] = shuffle[col];
            }
            return matrix;
        }
        private static int[,] Down(int[,] matrix, int currentCol, int times, int[] rc)
        {
            List<int> kys = new List<int>();
            for (int row = 0; row < rc[0]; row++)
            {
                kys.Add(matrix[row, currentCol]);
            }
            int[] shuffle = kys.ToArray();
            for (int i = 1; i <= times; i++)
            {
                int start = shuffle[shuffle.Length - 1];
                Array.Copy(shuffle, 0, shuffle, 1, shuffle.Length - 1);
                Array.Clear(shuffle, 0, 1);
                shuffle[0] = start;
            }
            for (int row = 0; row < rc[0]; row++)
            {
                matrix[row, currentCol] = shuffle[row];
            }
            return matrix;
        }
        private static int[,] Up(int[,] matrix, int currentCol, int times, int[] rc)
        {
            List<int> kys = new List<int>();
            for (int row = 0; row < rc[0]; row++)
            {
                kys.Add(matrix[row, currentCol]);
            }
            int[] shuffle = kys.ToArray();
            for (int i = 1; i <= times; i++)
            {
                int end = shuffle[0];
                Array.Copy(shuffle, 1, shuffle, 0, shuffle.Length - 1);
                Array.Clear(shuffle, shuffle.Length - 1, 1);
                shuffle[shuffle.Length - 1] = end;
            }
            for (int row = 0; row < rc[0]; row++)
            {
                matrix[row, currentCol] = shuffle[row];
            }
            return matrix;
        }
    }
}
