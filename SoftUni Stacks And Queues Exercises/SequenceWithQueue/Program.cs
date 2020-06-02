using System;
using System.Collections.Generic;

namespace SequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            queue.Enqueue(N);
            List<long> sequence = new List<long>();
            sequence.Add(N);
            int counter = 2;
            for (int i = 1; i < 50; i++)
            {
                if (counter == 5)
                {
                    counter = 2;
                    queue.Dequeue();
                }
                if (counter == 2)
                {
                    sequence.Add(queue.Peek() + 1);
                    queue.Enqueue(queue.Peek() + 1);
                }
                else if (counter == 3)
                {
                    sequence.Add(queue.Peek() * 2 + 1);
                    queue.Enqueue(queue.Peek() * 2 + 1);
                }
                else if (counter == 4)
                {
                    sequence.Add(queue.Peek() + 2);
                    queue.Enqueue(queue.Peek() + 2);
                }
                counter++;
            }
            Console.WriteLine(String.Join(" ", sequence));
            Console.ReadLine();
        }
    }
}
