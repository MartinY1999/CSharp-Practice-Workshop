using System;
using System.Collections.Generic;

namespace MathPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] circle = Console.ReadLine().Split(' ');
            Queue<string> queue = new Queue<string>(circle);
            int n = int.Parse(Console.ReadLine());
            int cycle = 1;
            while (queue.Count > 1)
            {
                bool prime = true;
                for (int i = 1; i < n; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                for (int i = 2; i <= Math.Sqrt(cycle); i++)
                {
                    if (cycle % i == 0)
                    {
                        prime = false;
                        goto Done;
                    }
                }
                Done:;
                if (cycle == 1 || prime == false) Console.WriteLine($"Removed {queue.Dequeue()}");
                else Console.WriteLine($"Prime {queue.Peek()}");
                cycle++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
            Console.ReadLine();
        }
    }
}
