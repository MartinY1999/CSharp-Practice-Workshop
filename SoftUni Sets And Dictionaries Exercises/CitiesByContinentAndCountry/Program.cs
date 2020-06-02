using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string town = input[2];
                if (!continents.ContainsKey(continent)) continents.Add(continent, new Dictionary<string, List<string>>());
                if (!continents[continent].ContainsKey(country)) continents[continent].Add(country, new List<string>());
                continents[continent][country].Add(town);
            }

            foreach (var pair in continents)
            {
                Console.WriteLine($"{pair.Key}:");
                foreach (var kvp in pair.Value)
                {
                    Console.WriteLine($"{kvp.Key} -> {String.Join(", ", kvp.Value)}");
                }
            }

            Console.ReadLine();

        }
    }
}
