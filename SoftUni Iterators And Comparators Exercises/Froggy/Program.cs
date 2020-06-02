using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> numbers = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            Lake lake = new Lake(numbers);
            Console.WriteLine(String.Join(", ", lake));
            Console.ReadLine();
        }
    }
}
