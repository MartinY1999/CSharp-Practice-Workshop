using System;
using System.Collections.Generic;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[][] matrix = new long[N][];
            for (int row = 0; row < matrix.Length; row++)
            {
                List<long> current = new List<long>();
                for (int column = 0; column <= row; column++)
                {
                    if (column == 0 || column == row) current.Add(1);
                    else current.Add(matrix[row - 1][column - 1] + matrix[row - 1][column]);
                }
                matrix[row] = current.ToArray();
            }
            foreach (long[] row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
            Console.ReadLine();
        }
    }
}
