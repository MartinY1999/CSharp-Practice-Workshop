using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            SortedSet<string> chemicals = new SortedSet<string>();
            for (int i = 1; i <= N; i++)
            {
                Stack<string> stack = new Stack<string>(Console.ReadLine().Split(' '));
                while (stack.Count > 0)
                {
                    chemicals.Add(stack.Pop());
                }
            }
            Console.WriteLine(String.Join(" ", chemicals));
            Console.ReadLine();
        }
    }
}
