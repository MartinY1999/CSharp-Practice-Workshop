using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ICreature> creatures = new List<ICreature>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                else
                {
                    FillList(creatures, input);
                }
            }
            string fakeIdEnd = Console.ReadLine();
            for (int i = 0; i < creatures.Count; i++)
            {
                if (creatures[i].TestFakeId(fakeIdEnd))
                {
                    Console.WriteLine(creatures[i].Id);
                    creatures.RemoveAt(i);
                    i--;
                }
            }
            Console.ReadLine();
        }
        private static void FillList(List<ICreature> creatures, string input)
        {
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2)
                creatures.Add(Robot.Create(parts));
            else if (parts.Length == 3)
                creatures.Add(Citizen.Create(parts));
        }
    }
}
