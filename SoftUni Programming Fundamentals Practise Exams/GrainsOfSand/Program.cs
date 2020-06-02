using System;
using System.Collections.Generic;
using System.Linq;

namespace GrainsOfSand
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "Mort") break;
                else numbers = DoActions(numbers, input);
            }
            Console.WriteLine(String.Join(" ", numbers));
            Console.ReadLine();
        }

        static List<int> DoActions(List<int> numbers, string[] input)
        {
            string command = input[0];
            switch (command)
            {
                case "Add":
                    numbers.Add(int.Parse(input[1]));
                    break;
                case "Remove":
                    bool contains = numbers.Any(x => x == int.Parse(input[1]));
                    if (contains == true)
                    {
                        numbers.Remove(int.Parse(input[1]));
                    }
                    else
                    {
                        if (0 <= int.Parse(input[1]) && int.Parse(input[1]) < numbers.Count) numbers.RemoveAt(int.Parse(input[1]));
                    }
                    break;
                case "Replace":
                    try
                    {
                        int index = numbers.FindIndex(x => x == int.Parse(input[1]));
                        numbers[index] = int.Parse(input[2]);
                    }
                    catch
                    {
                        goto Ignore;
                    }
                    Ignore:;
                    break;
                case "Increase":
                    try
                    {
                        int index = numbers.FindIndex(x => x == int.Parse(input[1]));
                        int increase = numbers[index];
                        numbers = numbers.Select(x => x + increase).ToList();
                    }
                    catch
                    {
                        int increase = numbers.Last();
                        numbers = numbers.Select(x => x + increase).ToList();
                    }
                    break;
                case "Collapse":
                    int value = int.Parse(input[1]);
                    numbers = numbers.Where(x => x >= value).ToList();
                    break;
                default:
                    break;
            }
            return numbers;
        }
    }
}
