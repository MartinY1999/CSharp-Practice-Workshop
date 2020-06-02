using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Regex.Split(Console.ReadLine(), " ").Select(int.Parse).ToArray();
            int[][] matrix = new int[input[0]][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            int columns = input[1];
            int maxSum = int.MinValue;
            List<int> upRow = new List<int>();
            List<int> midRow = new List<int>();
            List<int> downRow = new List<int>();
            for (int col = 0; col < columns - 2; col++)
            {
                for (int row = 0; row < matrix.Length - 2; row++)
                {
                    int currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                                     matrix[row + 1][col] +
                                     matrix[row + 1][col + 1] + matrix[row + 1][col + 2] + matrix[row + 2][col] +
                                     matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                    if (currentSum >= maxSum)
                    {
                        upRow.Clear();
                        midRow.Clear();
                        downRow.Clear();
                        upRow.Add(matrix[row][col]);
                        upRow.Add(matrix[row][col + 1]);
                        upRow.Add(matrix[row][col + 2]);
                        midRow.Add(matrix[row + 1][col]);
                        midRow.Add(matrix[row + 1][col + 1]);
                        midRow.Add(matrix[row + 1][col + 2]);
                        downRow.Add(matrix[row + 2][col]);
                        downRow.Add(matrix[row + 2][col + 1]);
                        downRow.Add(matrix[row + 2][col + 2]);
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(String.Join(" ", upRow));
            Console.WriteLine(String.Join(" ", midRow));
            Console.WriteLine(String.Join(" ", downRow));
            Console.ReadLine();
        }
    }
}
