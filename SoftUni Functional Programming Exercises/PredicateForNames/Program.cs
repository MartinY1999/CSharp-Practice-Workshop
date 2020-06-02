using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLength = int.Parse(Console.ReadLine());
            List<string> words = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> result = words.Where(x => x.Length <= maxLength).ToList();
            result.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
