using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
            int[][] matrix = new int[input[0]][];
            int sum = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
                sum += matrix[i].Sum();
            }
            Console.WriteLine(input[0]);
            Console.WriteLine(input[1]);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
