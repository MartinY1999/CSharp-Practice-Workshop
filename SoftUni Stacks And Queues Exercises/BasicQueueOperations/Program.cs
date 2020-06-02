using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int push = nsx[0];
            int pop = nsx[1];
            int lookFor = nsx[2];
            Queue<int> queue = new Queue<int>();
            int[] toPush = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < toPush.Length; i++)
            {
                queue.Enqueue(toPush[i]);
            }
            for (int i = 1; i <= pop; i++)
            {
                if (queue.Count > 0) queue.Dequeue();
                else break;
            }
            if (queue.Contains(lookFor)) Console.WriteLine("true");
            else if (queue.Count == 0) Console.WriteLine(0);
            else Console.WriteLine(queue.ToList().Min());
            Console.ReadLine();
        }
    }
}
