using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> add = x => x.Select(t => t += 1).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(t => t * 2).ToList();
            Func<List<int>, List<int>> substract = x => x.Select(t => t -= 1).ToList();
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end") break;
                else
                {
                    switch (command)
                    {
                        case "add":
                            integers = add(integers);
                            break;
                        case "multiply":
                            integers = multiply(integers);
                            break;
                        case "subtract":
                            integers = substract(integers);
                            break;
                        case "print":
                            Console.WriteLine(String.Join(" ", integers));
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
