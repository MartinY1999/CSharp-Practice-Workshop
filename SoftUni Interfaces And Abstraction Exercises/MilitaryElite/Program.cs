using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                else
                {
                    try
                    {
                        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        FillList(soldiers, parts);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            soldiers.ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
        private static void FillList(List<Soldier> soldiers, string[] parts)
        {
            switch (parts[0])
            {
                case "Private":
                    soldiers.Add(Private.Create(parts));
                    break;
                case "LieutenantGeneral":
                    soldiers.Add(LieutenantGeneral.Create(parts, soldiers));
                    break;
                case "Engineer":
                    soldiers.Add(Engineer.Create(parts));
                    break;
                case "Commando":
                    soldiers.Add(Commando.Create(parts));
                    break;
                case "Spy":
                    soldiers.Add(Spy.Create(parts));
                    break;
                default:
                    break;
            }
        }
    }
}
