using System;
using System.Collections.Generic;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            List<string> upperCase = words.Where(x => char.IsUpper(x.First())).ToList();
            upperCase.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
