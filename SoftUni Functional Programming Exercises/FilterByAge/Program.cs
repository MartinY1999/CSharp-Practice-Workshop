using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> persons = new Dictionary<string, int>();
            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                persons.Add(name, age);
            }
            PrintResults(persons);
            Console.ReadLine();
        }
        private static void PrintResults(Dictionary<string, int> persons)
        {
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            switch (condition)
            {
                case "younger":
                    persons = persons.Where(x => x.Value < age).ToDictionary(x => x.Key, y => y.Value);
                    PrintInFormat(persons, command);
                    break;
                case "older":
                    persons = persons.Where(x => x.Value >= age).ToDictionary(x => x.Key, y => y.Value);
                    PrintInFormat(persons, command);
                    break;
                default:
                    break;
            }
        }
        private static void PrintInFormat(Dictionary<string, int> persons, string command)
        {
            switch (command)
            {
                case "name":
                    foreach (KeyValuePair<string, int> name in persons)
                    {
                        Console.WriteLine(name.Key);
                    }
                    break;
                case "age":
                    foreach (KeyValuePair<string, int> age in persons)
                    {
                        Console.WriteLine(age.Value);
                    }
                    break;
                case "name age":
                    foreach (KeyValuePair<string, int> pair in persons)
                    {
                        Console.WriteLine($"{pair.Key} - {pair.Value}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
