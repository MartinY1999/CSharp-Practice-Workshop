using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 1; i <= N; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                switch (input[0])
                {
                    case 1:
                        stack.Push(input[1]);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        Console.WriteLine(stack.ToList().Max());
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
