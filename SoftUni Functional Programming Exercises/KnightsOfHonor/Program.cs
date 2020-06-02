using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printKnight = p => Console.WriteLine($"Sir {p}");
            List<string> collection = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (string name in collection)
            {
                printKnight(name);
            }
            Console.ReadLine();
        }
    }
}
