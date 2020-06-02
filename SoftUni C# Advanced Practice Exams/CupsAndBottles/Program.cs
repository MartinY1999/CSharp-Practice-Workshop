using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> capacity = new Queue<int>();
            Stack<int> bottleLtrs = new Stack<int>();
            int[] cups = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (int cup in cups)
            {
                capacity.Enqueue(cup);
            }
            int[] bottleWater = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (int water in bottleWater)
            {
                bottleLtrs.Push(water);
            }
            int wastedWater = 0;
            int filled = 0;
            while (capacity.Count > 0 && bottleLtrs.Count > 0)
            {
                int current = capacity.Dequeue();
                bool full = false;
                while (!full && bottleLtrs.Count > 0)
                {
                    int bottle = bottleLtrs.Pop();
                    if (current - bottle <= 0)
                    {
                        filled++;
                        wastedWater += Math.Abs(current - bottle);
                        full = true;
                    }
                    else current -= bottle;
                }
            }
            if (capacity.Count == 0)
            {
                List<int> left = new List<int>();
                while (bottleLtrs.Count > 0)
                {
                    left.Add(bottleLtrs.Pop());
                }
                Console.WriteLine($"Bottles: {String.Join(" ", left)}");
            }
            else if (bottleLtrs.Count == 0)
            {
                List<int> left = new List<int>();
                while (capacity.Count > 0)
                {
                    left.Add(capacity.Dequeue());
                }
                Console.WriteLine($"Cups: {String.Join(" ", left)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
            Console.ReadLine();
        }
    }
}
