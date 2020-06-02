using System;
using System.Collections.Generic;
using System.Linq;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 1; i <= N; i++)
            {
                names.Add(Console.ReadLine());
            }
            names.ToList().ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
