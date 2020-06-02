using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] matrix = new int[N][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            int firstSum = 0;
            int secondSum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                firstSum += matrix[row][row];
            }
            int counter = 0;
            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                secondSum += matrix[counter][row];
                counter++;
            }
            Console.WriteLine(Math.Abs(firstSum - secondSum));
            Console.ReadLine();
        }
    }
}
