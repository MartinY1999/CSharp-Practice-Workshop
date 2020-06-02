using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[][] matrix = new Char[N][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }
            char symbol = Convert.ToChar(Console.ReadLine());
            bool found = false;
            int lookedRow = -1;
            int lookedCol = -1;
            for (int row = 0; row < matrix.Length; row++)
            {
                if (matrix[row].Contains(symbol))
                {
                    found = true;
                    lookedRow = row;
                    lookedCol = matrix[row].ToList().IndexOf(symbol);
                    break;
                }
            }
            if (found) Console.WriteLine($"({lookedRow}, {lookedCol})");
            else Console.WriteLine($"{symbol} does not occur in m");
            Console.ReadLine();
        }
    }
}
