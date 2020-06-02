using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end") break;
                else
                {
                    string[] split = command.Split(' ');
                    switch (split[0])
                    {
                        case "exchange":
                            if (int.Parse(split[1]) < 0 || int.Parse(split[1]) >= numbers.Count)
                                Console.WriteLine("Invalid index");
                            else numbers = ExchangeArray(numbers, int.Parse(split[1]));
                            break;
                        case "max":
                            int indexMax = GetIndexOfMax(numbers, split[1]);
                            if (indexMax == -1) Console.WriteLine("No matches");
                            else Console.WriteLine(indexMax);
                            break;
                        case "min":
                            int indexMin = GetIndexOfMin(numbers, split[1]);
                            if (indexMin == -1) Console.WriteLine("No matches");
                            else Console.WriteLine(indexMin);
                            break;
                        case "first":
                            if (int.Parse(split[1]) > numbers.Count) Console.WriteLine("Invalid count");
                            else
                            {
                                List<int> first = GetFirstNums(numbers, int.Parse(split[1]), split[2]);
                                Console.WriteLine($"[{String.Join(", ", first)}]");
                            }
                            break;
                        case "last":
                            if (int.Parse(split[1]) > numbers.Count) Console.WriteLine("Invalid count");
                            else
                            {
                                List<int> last = GetLastNums(numbers, int.Parse(split[1]), split[2]);
                                Console.WriteLine($"[{String.Join(", ", last)}]");
                            }
                            break;
                    }
                }
            }
            Console.WriteLine($"[{String.Join(", ", numbers)}]");
            Console.ReadLine();
        }
        private static List<int> GetLastNums(List<int> numbers, int count, string type)
        {
            List<int> nums = new List<int>();
            if (type == "odd") nums = numbers.Where(x => x % 2 != 0).ToList();
            else nums = numbers.Where(x => x % 2 == 0).ToList();
            if (count > nums.Count) return nums;
            else return nums.Skip(nums.Count - count).Take(count).ToList();
        }
        private static List<int> GetFirstNums(List<int> numbers, int count, string type)
        {
            List<int> nums = new List<int>();
            if (type == "odd") nums = numbers.Where(x => x % 2 != 0).ToList();
            else nums = numbers.Where(x => x % 2 == 0).ToList();
            return nums.Take(count).ToList();
        }
        private static int GetIndexOfMin(List<int> numbers, string type)
        {
            if (type == "odd")
            {
                List<int> odds = numbers.Where(x => x % 2 != 0).ToList();
                if (odds.Count == 0) return -1;
                else
                {
                    int min = odds.Min();
                    return numbers.LastIndexOf(min);
                }
            }
            else
            {
                List<int> evens = numbers.Where(x => x % 2 == 0).ToList();
                if (evens.Count == 0) return -1;
                else
                {
                    int min = evens.Min();
                    return numbers.LastIndexOf(min);
                }
            }
        }
        private static int GetIndexOfMax(List<int> numbers, string type)
        {;
            if (type == "odd")
            {
                List<int> odds = numbers.Where(x => x % 2 != 0).ToList();
                if (odds.Count == 0) return -1;
                else
                {
                    int max = odds.Max();
                    return numbers.LastIndexOf(max);
                }
            }
            else
            {
                List<int> evens = numbers.Where(x => x % 2 == 0).ToList();
                if (evens.Count == 0) return -1;
                else
                {
                    int max = evens.Max();
                    return numbers.LastIndexOf(max);
                }
            }
        }
        private static List<int> ExchangeArray(List<int> numbers, int index)
        {
            List<int> left = numbers.Take(index + 1).ToList();
            List<int> right = numbers.Skip(index + 1).Take(numbers.Count - index - 1).ToList();
            List<int> newList = new List<int>();
            newList.AddRange(right);
            newList.AddRange(left);
            return newList;
        }
    }
}
