using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<string>> print = p => p.ForEach(Console.WriteLine);
            List<string> collection = Console.ReadLine().Split(' ').ToList();
            print(collection);
            Console.ReadLine();
        }
    }
}
