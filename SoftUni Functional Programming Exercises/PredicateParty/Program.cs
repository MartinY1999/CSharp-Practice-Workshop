using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Party!") break;
                else if (input.Split(' ').Length <= 3)
                {
                    string[] split = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    List<string> current = new List<string>();
                    current = GetList(names, split);
                    names = current;
                }
            }
            if (names.Count == 0) Console.WriteLine("Nobody is going to the party!");
            else Console.WriteLine($"{String.Join(", ", names)} are going to the party!");
            Console.ReadLine();
        }
        private static List<string> GetList(List<string> names, string[] split)
        {
            List<string> current = new List<string>();
            switch (split[0])
            {
                case "Remove":
                    current = DoRemoveAction(names, split[1], split[2]);
                    break;
                case "Double":
                    current = DoDoubleAction(names, split[1], split[2]);
                    break;
                default:
                    break;
            }
            return current;
        }
        private static List<string> DoRemoveAction(List<string> names, string v1, string v2)
        {
            List<string> current = new List<string>();
            switch (v1)
            {
                case "StartsWith":
                    foreach (string name in names)
                    {
                        string n = name.Substring(0, v2.Length);
                        if (n != v2) current.Add(name);
                    }
                    break;
                case "EndsWith":
                    foreach (string name in names)
                    {
                        string n = name.Substring(name.Length - v2.Length);
                        if (n != v2) current.Add(name);
                    }
                    break;
                case "Length":
                    current = names.Where(x => x.Length != int.Parse(v2)).ToList();
                    break;
                default:
                    break;
            }
            return current;
        }
        private static List<string> DoDoubleAction(List<string> names, string v1, string v2)
        {
            List<string> current = new List<string>();
            switch (v1)
            {
                case "StartsWith":
                    foreach (string name in names)
                    {
                        string n = name.Substring(0, v2.Length);
                        if (n == v2)
                        {
                            for (int i = 1; i <= 2; i++)
                            {
                                current.Add(name);
                            }
                        }
                    }
                    break;
                case "EndsWith":
                    foreach (string name in names)
                    {
                        string n = name.Substring(name.Length - v2.Length);
                        if (n == v2)
                        {
                            for (int i = 1; i <= 2; i++)
                            {
                                current.Add(name);
                            }
                        }
                    }
                    break;
                case "Length":
                    foreach (string name in names)
                    {
                        if (name.Length == int.Parse(v2))
                        {
                            current.Add(name);
                            current.Add(name);
                        }
                        else current.Add(name);
                    }
                    break;
                default:
                    break;
            }
            return current;
        }
    }
}
