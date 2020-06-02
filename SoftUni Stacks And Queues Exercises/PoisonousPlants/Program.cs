using System;
using System.Collections.Generic;
using System.Linq;

namespace PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 1;
            int number = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> defaultLook = new Queue<int>(plants);
            Stack<int> after = new Stack<int>();
            bool noDeath = false;
            while (!noDeath)
            {
                after.Push(defaultLook.Peek());
                int deaths = 0;
                while (true)
                {
                    try
                    {
                        int left = defaultLook.Peek();
                        defaultLook.Dequeue();
                        int right = defaultLook.Peek();
                        if (left < right) deaths++;
                        else after.Push(right);
                    }
                    catch
                    {
                        break;
                    }
                }
                if (deaths == 0) noDeath = true;
                else
                {
                    defaultLook = new Queue<int>(after.Reverse());
                    after.Clear();
                    days++;
                }
            }
            Console.WriteLine(days - 1);
        }
    }
}
