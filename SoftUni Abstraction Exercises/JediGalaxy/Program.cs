using System;
using System.Linq;

namespace JediGalaxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = ReturnMatrix();
            FillMatrix(matrix, matrix.GetLength(0), matrix.GetLength(1));
            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoCoordinates = ReturnCoordinates(command);
                int[] evilCoordinates = ReturnCoordinates(Console.ReadLine());
                EvilSpread(matrix, evilCoordinates);
                sum = ReturnSum(sum, matrix, ivoCoordinates);
                command = Console.ReadLine();
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        private static int[,] ReturnMatrix()
        {
            int[] dimensions = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int x = dimensions[0];
            int y = dimensions[1];
            return new int[x, y];
        }
        private static void FillMatrix(int[,] matrix, int row, int column)
        {
            int value = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }
        private static int[] ReturnCoordinates(string input)
        {
            return input.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
        }
        public static void EvilSpread(int[,] matrix, int[] evilCoordinates)
        {
            int evilX = evilCoordinates[0];
            int evilY = evilCoordinates[1];
            while (evilX >= 0 && evilY >= 0)
            {
                if (evilX >= 0 && evilX < matrix.GetLength(0) && evilY >= 0 && evilY < matrix.GetLength(1))
                {
                    matrix[evilX, evilY] = 0;
                }
                evilX--;
                evilY--;
            }
        }
        public static long ReturnSum(long sum, int[,] matrix, int[] ivoCoordinates)
        {
            int ivoX = ivoCoordinates[0];
            int ivoY = ivoCoordinates[1];
            while (ivoX >= 0 && ivoY < matrix.GetLength(1))
            {
                if (ivoX >= 0 && ivoX < matrix.GetLength(0) && ivoY >= 0 && ivoY < matrix.GetLength(1))
                {
                    sum += matrix[ivoX, ivoY];
                }
                ivoY++;
                ivoX--;
            }
            return sum;
        }
    }
}
