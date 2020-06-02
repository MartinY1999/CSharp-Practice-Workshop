using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();
            for (int i = 1; i <= N; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 3)
                    buyers.Add(Rebel.Create(parts));
                else if (parts.Length == 4)
                    buyers.Add(Citizen.Create(parts));
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                else
                {
                    if (buyers.Any(x => x.Name == input))
                    {
                        int index = buyers.FindIndex(x => x.Name == input);
                        buyers[index].BuyFood();
                    }
                }
            }
            Console.WriteLine(buyers.Sum(x => x.Food));
            Console.ReadLine();
        }
    }
}