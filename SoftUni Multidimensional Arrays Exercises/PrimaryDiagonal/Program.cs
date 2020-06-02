using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] matrix = new int[N][];
            int sum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Regex.Split(Console.ReadLine(), " ").Select(int.Parse).ToArray();
                sum += matrix[row][row];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
