using System;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            PrintUpperPart(N);
            PrintLowerPart(N);
            Console.ReadLine();
        }
        private static void PrintLowerPart(int n)
        {
            int whitespaces = 1;
            for (int i = n - 1; i >= 1; i--)
            {
                PrintRow(i, n, whitespaces);
                whitespaces++;
            }
        }
        private static void PrintUpperPart(int n)
        {
            int whitespaces = n - 1;
            for (int i = 1; i <= n; i++)
            {
                PrintRow(i, n, whitespaces);
                whitespaces--;
            }
        }
        private static void PrintRow(int i, int n, int whitespaces)
        {
            Console.Write(new string(' ', whitespaces));
            for (int k = 1; k <= i; k++)
            {
                if (k != i) Console.Write("* ");
                else Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
