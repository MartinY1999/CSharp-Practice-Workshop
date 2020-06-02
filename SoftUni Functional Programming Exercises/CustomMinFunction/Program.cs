using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> smallest = x => x.Min();
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(smallest(integers));
            Console.ReadLine();
        }
    }
}
