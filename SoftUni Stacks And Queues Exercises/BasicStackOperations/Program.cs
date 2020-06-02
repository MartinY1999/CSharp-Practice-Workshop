using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int push = nsx[0];
            int pop = nsx[1];
            int lookFor = nsx[2];
            Stack<int> stack = new Stack<int>();
            int[] toPush = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < toPush.Length; i++)
            {
                stack.Push(toPush[i]);
            }
            for (int i = 1; i <= pop; i++)
            {
                if (stack.Count > 0) stack.Pop();
                else break;
            }
            if (stack.Contains(lookFor)) Console.WriteLine("true");
            else if (stack.Count == 0) Console.WriteLine(0);
            else Console.WriteLine(stack.ToList().Min());
            Console.ReadLine();
        }
    }
}
