using System;
using System.Collections.Generic;

namespace StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<long> fibb = new Queue<long>();
            fibb.Enqueue(0);
            fibb.Enqueue(1);
            for (int i = 1; i < n; i++)
            {
                long f0 = fibb.Dequeue();
                long f1 = fibb.Peek();
                fibb.Enqueue(f0 + f1);
            }
            fibb.Dequeue();
            Console.WriteLine(fibb.Peek());
            Console.ReadLine();
        }
    }
}
