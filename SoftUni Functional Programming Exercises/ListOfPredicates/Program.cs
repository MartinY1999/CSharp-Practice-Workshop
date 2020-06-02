using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> check = (i, y) => i % y == 0; 
            int N = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                bool correct = true;
                foreach (int divider in dividers)
                {
                    if (!check(i, divider))
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct) result.Add(i);
            }
            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();
        }
    }
}
