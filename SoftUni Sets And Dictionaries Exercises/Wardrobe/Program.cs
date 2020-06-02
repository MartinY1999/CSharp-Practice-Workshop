using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colorClothes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 1; i <= N; i++)
            {
                string[] parts = Regex.Split(Console.ReadLine(), " -> ");
                string color = parts[0];
                string[] clothes = parts[1].Split(',').ToArray();
                if (!colorClothes.ContainsKey(color)) colorClothes.Add(color, new Dictionary<string, int>());
                foreach (string cloth in clothes)
                {
                    if (!colorClothes[color].ContainsKey(cloth)) colorClothes[color].Add(cloth, 1);
                    else colorClothes[color][cloth]++;
                }
            }

            string[] lookedFor = Console.ReadLine().Split(' ');
            string lookedColor = lookedFor[0];
            string lookedCloth = lookedFor[1];
            foreach (var pair in colorClothes)
            {
                Console.WriteLine($"{pair.Key} clothes:");
                foreach (var kvp in pair.Value)
                {
                    if (pair.Key == lookedColor && kvp.Key == lookedCloth)
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value} (found!)");
                    else Console.WriteLine($"* {kvp.Key} - {kvp.Value}");
                }
            }

            Console.ReadLine();
        }
    }
}
