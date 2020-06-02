using System;
using System.Collections.Generic;
using System.Linq;

namespace LegoBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] leftPart = new int[N][];
            int[][] rightPart = new int[N][];
            for (int row = 0; row < N; row++)
            {
                leftPart[row] = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            for (int row = 0; row < N; row++)
            {
                rightPart[row] = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                Array.Reverse(rightPart[row]);
            }
            int[][] matrix = new int[N][];
            for (int row = 0; row < N; row++)
            {
                List<int> currentRow = new List<int>();
                currentRow.AddRange(leftPart[row]);
                currentRow.AddRange(rightPart[row]);
                matrix[row] = currentRow.ToArray();
            }
            int length = matrix[0].Length;
            int cells = 0;
            int wrongs = 0;
            foreach (int[] row in matrix)
            {
                cells += row.Length;
                if (row.Length != length) wrongs++;
            }
            if (wrongs == 0)
            {
                foreach (int[] row in matrix)
                {
                    Console.WriteLine($"[{String.Join(", ", row)}]");
                }
            }
            else Console.WriteLine($"The total number of cells is: {cells}");
            Console.ReadLine();
        }
    }
}
