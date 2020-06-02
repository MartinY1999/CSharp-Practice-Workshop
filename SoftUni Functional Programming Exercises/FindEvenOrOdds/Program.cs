using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();
            for (int i = input[0]; i <= input[1]; i++)
                numbers.Add(i);
            string command = Console.ReadLine();
            int divideResult = 0;
            if (command == "odd") divideResult = 1;
            List<int> filteredList = Filter(numbers, x => Math.Abs(x) % 2 == divideResult);
            Console.WriteLine(String.Join(" ", filteredList));
            Console.ReadLine();
        }
        private static List<int> Filter(List<int> numbers, Predicate<int> p)
        {
            List<int> result = new List<int>();
            foreach (int num in numbers)
            {
                if (p(num)) result.Add(num);
            }
            return result;
        }
    }
}
