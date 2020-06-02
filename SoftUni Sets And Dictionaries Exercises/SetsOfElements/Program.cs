using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] length = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            HashSet<int> all = new HashSet<int>();
            HashSet<int> repeated = new HashSet<int>();
            for (int i = 1; i <= length[0] + length[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (all.Contains(number)) repeated.Add(number);
                else all.Add(number);
            }
            Console.WriteLine(String.Join(" ", repeated));
            Console.ReadLine();
        }
    }
}
