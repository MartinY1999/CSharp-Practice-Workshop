using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterMode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            List<string> atStart = new List<string>();
            atStart.AddRange(names);
            List<string> filtered = new List<string>();
            string input = Console.ReadLine();
            while (input != "Print")
            {
                string[] split = input.Split(';');
                switch (split[0])
                {
                    case "Add filter":
                        AddFilter(names, filtered, split);
                        break;
                    case "Remove filter":
                        RemoveFilter(names, filtered, split);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < atStart.Count; i++)
            {
                if (names.Any(x => x == atStart[i])) continue;
                else
                {
                    atStart.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(String.Join(" ", atStart));
            Console.ReadLine();
        }
        private static void AddFilter(List<string> names, List<string> filtered, string[] split)
        {
            switch (split[1])
            {
                case "Starts with":
                    filtered.AddRange(names.Where(x => x.Substring(0, split[2].Length) == split[2]).ToList());
                    names.RemoveAll(x => x.Substring(0, split[2].Length) == split[2]);
                    break;
                case "Ends with":
                    filtered.AddRange(names.Where(x => x.Substring(x.Length - split[2].Length) == split[2]).ToList());
                    names.RemoveAll(x => x.Substring(x.Length - split[2].Length) == split[2]);
                    break;
                case "Length":
                    filtered.AddRange(names.Where(x => x.Length == int.Parse(split[2])).ToList());
                    names.RemoveAll(x => x.Length == int.Parse(split[2]));
                    break;
                case "Contains":
                    filtered.AddRange(names.Where(x => x.Contains(split[2])).ToList());
                    names.RemoveAll(x => x.Contains(split[2]));
                    break;
                default:
                    break;
            }
        }
        private static void RemoveFilter(List<string> names, List<string> filtered, string[] split)
        {
            switch (split[1])
            {
                case "Starts with":
                    names.AddRange(filtered.Where(x => x.Substring(0, split[2].Length) == split[2]).ToList());
                    filtered.RemoveAll(x => x.Substring(0, split[2].Length) == split[2]);
                    break;
                case "Ends with":
                    names.AddRange(filtered.Where(x => x.Substring(x.Length - split[2].Length) == split[2]).ToList());
                    filtered.RemoveAll(x => x.Substring(x.Length - split[2].Length) == split[2]);
                    break;
                case "Length":
                    names.AddRange(filtered.Where(x => x.Length == int.Parse(split[2])).ToList());
                    filtered.RemoveAll(x => x.Length == int.Parse(split[2]));
                    break;
                case "Contains":
                    names.AddRange(filtered.Where(x => x.Contains(split[2])).ToList());
                    filtered.RemoveAll(x => x.Contains(split[2]));
                    break;
                default:
                    break;
            }
        }
    }
}
