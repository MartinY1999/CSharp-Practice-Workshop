using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SumMatrixColumn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
            int[][] matrix = new int[input[0]][];
            int columns = input[1];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Regex.Split(Console.ReadLine(), " ").Select(int.Parse).ToArray();
            }

            for (int col = 0; col < columns; col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.Length; row++)
                {
                    sum += matrix[row][col];
                }
                Console.WriteLine(sum);
            }

            Console.ReadLine();

        }
    }
}
