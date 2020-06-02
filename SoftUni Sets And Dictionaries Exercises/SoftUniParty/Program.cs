using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> checkList = new SortedSet<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "PARTY") break;
                else checkList.Add(input);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;
                else checkList.Remove(input);
            }

            Console.WriteLine(checkList.Count);
            foreach (string res in checkList)
            {
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }
}
