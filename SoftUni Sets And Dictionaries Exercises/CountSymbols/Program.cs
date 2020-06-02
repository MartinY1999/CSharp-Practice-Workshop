using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();
            string input = Console.ReadLine();
            foreach (char symbol in input)
            {
                if (!characters.ContainsKey(symbol)) characters.Add(symbol, 1);
                else characters[symbol]++;
            }

            foreach (var pair in characters.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }

            Console.ReadLine();
        }
    }
}
