using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentsGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> data = new Dictionary<string, List<double>>();
            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);
                if (!data.ContainsKey(name)) data.Add(name, new List<double>());
                data[name].Add(grade);
            }

            foreach (var pair in data)
            {
                Console.Write($"{pair.Key} -> ");
                foreach (double n in pair.Value)
                {
                    Console.Write($"{n:F2} ");
                }
                Console.WriteLine($"(avg: {pair.Value.Average():F2})");
            }

            Console.ReadLine();
        }
    }
}
