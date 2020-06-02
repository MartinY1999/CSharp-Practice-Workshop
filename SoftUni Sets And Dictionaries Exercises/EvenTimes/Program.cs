using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number)) numbers.Add(number, 1);
                else numbers[number]++;
            }
            Console.WriteLine(numbers.Where(x => x.Value % 2 == 0).First().Key);
            Console.ReadLine();
        }
    }
}
