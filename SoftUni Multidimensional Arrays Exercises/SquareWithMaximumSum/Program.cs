using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
            int[][] matrix = new int[input[0]][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
            }
            int columns = input[1];
            int maxSum = int.MinValue;
            List<int> upRow = new List<int>();
            List<int> downRow = new List<int>();
            for (int col = 0; col < columns - 1; col++)
            {
                for (int row = 0; row < matrix.Length - 1; row++)
                {
                    int currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] +
                                     matrix[row + 1][col + 1];
                    if (currentSum > maxSum)
                    {
                        upRow.Clear();
                        downRow.Clear();
                        upRow.Add(matrix[row][col]);
                        upRow.Add(matrix[row][col + 1]);
                        downRow.Add(matrix[row + 1][col]);
                        downRow.Add(matrix[row + 1][col + 1]);
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", upRow));
            Console.WriteLine(String.Join(" ", downRow));
            Console.WriteLine(maxSum);
            Console.ReadLine();
        }
    }
}
