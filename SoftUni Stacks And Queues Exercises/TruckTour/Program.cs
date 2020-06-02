using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int stations = int.Parse(Console.ReadLine());
            Queue<Tuple<long, long, int>> queue = new Queue<Tuple<long, long, int>>();
            for (int i = 0; i < stations; i++)
            {
                long[] input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                long amount = input[0];
                long distance = input[1];
                queue.Enqueue(new Tuple<long, long, int>(amount, distance, i));
            }
            int index = 0;
            while (true)
            {
                bool found = true;
                List<Tuple<long, long, int>> currentSequence = queue.ToList();
                long leftPetrol = 0;
                for (int i = 0; i < currentSequence.Count; i++)
                {
                    long amount = currentSequence[i].Item1;
                    long distance = currentSequence[i].Item2;
                    amount += leftPetrol;
                    if (amount > distance)
                    {
                        leftPetrol = amount - distance;
                        continue;
                    }
                    else
                    {
                        found = false;
                        queue.Enqueue(queue.Dequeue());
                        break;
                    }
                }
                if (found == true)
                {
                    index = currentSequence.First().Item3;
                    goto Done;;
                }
            }
            Done: Console.WriteLine(index);
            Console.ReadLine();
        }
    }
}
