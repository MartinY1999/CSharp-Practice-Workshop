using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> odd = numbers.Where(x => Math.Abs(x) % 2 != 0).ToList();
            List<int> even = numbers.Where(x => Math.Abs(x) % 2 == 0).ToList();
            odd.Sort();
            even.Sort();
            List<int> result = new List<int>();
            result.AddRange(even);
            result.AddRange(odd);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();
        }
    }
}
