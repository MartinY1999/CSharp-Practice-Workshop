using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string[,] matrix = new string[input[0], input[1]];
            for (int row = 0; row < input[0]; row++)
            {
                for (int column = 0; column < input[1]; column++)
                {
                    matrix[row, column] = $"{alphabet[row]}{alphabet[row + column]}{alphabet[row]}";
                }
            }
            int counter = 1;
            foreach (var element in matrix)
            {
                Console.Write($"{element} ");
                if (counter == input[1])
                {
                    counter = 1;
                    Console.WriteLine();
                }
                else counter++;
            }
            Console.ReadLine();
        }
    }
}
