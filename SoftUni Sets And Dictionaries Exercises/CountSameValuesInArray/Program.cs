using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> data = new Dictionary<double, int>();
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (double num in numbers)
            {
                if (!data.ContainsKey(num)) data.Add(num, 1);
                else data[num]++;
            }

            foreach (var pair in data)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }

            Console.ReadLine();
        }
    }
}
