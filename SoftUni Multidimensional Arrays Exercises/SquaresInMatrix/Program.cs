using System;
using System.ComponentModel.Design;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[][] matrix = new char[input[0]][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }
            int columns = input[1];
            int counter = 0;
            for (int col = 0; col < columns - 1; col++)
            {
                for (int row = 0; row < matrix.Length - 1; row++)
                {
                    bool equalElements = Check(matrix, row, col);
                    if (equalElements) counter++;
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
        private static bool Check(char[][] matrix, int row, int col)
        {
            if (matrix[row][col] == matrix[row][col + 1] && matrix[row][col + 1] == matrix[row + 1][col] &&
                matrix[row + 1][col] == matrix[row + 1][col + 1]) 
                return true;
            else 
                return false;
            //matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] +
            //matrix[row + 1][col + 1];//
        }
    }
}