using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLessons = Console.ReadLine().Split(',').ToList();
            initialLessons = initialLessons.Select(x => x.Trim()).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "course start") break;
                else
                {
                    string[] command = input.Split(':');
                    initialLessons = DoActions(initialLessons, command);
                }
            }
            int count = 1;
            foreach (string lesson in initialLessons)
            {
                Console.WriteLine($"{count}.{lesson}");
                count++;
            }
            Console.ReadLine();
        }
        static List<string> DoActions(List<string> initialLessons, string[] command)
        {
            switch (command[0])
            {
                case "Add":
                    string title = command[1];
                    if (initialLessons.Any(x => x == title) == false) initialLessons.Add(title);
                    break;
                case "Insert":
                    string title1 = command[1];
                    int index = int.Parse(command[2]);
                    if (initialLessons.Any(x => x == title1) == false && index >= 0 && index < initialLessons.Count)
                        initialLessons.Insert(index, title1);
                    break;
                case "Remove":
                    string title2 = command[1];
                    if (initialLessons.Any(x => x.Contains(title2) == true))
                    {
                        int index1 = initialLessons.FindIndex(x => x.Contains(title2));
                        initialLessons.RemoveAt(index1);
                    }
                    break;
                case "Swap":
                    string swapTitle1 = command[1];
                    string swapTitle2 = command[2];
                    if (initialLessons.Any(x => x.Contains(swapTitle1) == true) &&
                        initialLessons.Any(x => x.Contains(swapTitle2) == true))
                    {
                        int index1 = initialLessons.FindIndex(x => x.Contains(swapTitle1));
                        int index2 = initialLessons.FindIndex(x => x.Contains(swapTitle2));
                        var change = initialLessons[index2];
                        initialLessons[index2] = initialLessons[index1];
                        initialLessons[index1] = change;
                        if (swapTitle1 != initialLessons[index2]) initialLessons.Insert(index2, swapTitle1);
                        if (swapTitle2 != initialLessons[index1]) initialLessons.Insert(index1, swapTitle2);
                    }
                    break;
                case "Exercise":
                    string title3 = command[1];
                    if (!initialLessons.Contains($"{title3}-Exercise"))
                    {
                        if (initialLessons.Any(x => x == title3))
                        {
                            int index1 = initialLessons.FindIndex(x => x == title3);
                            initialLessons[index1] += "-Exercise";
                        }
                        else initialLessons.Add($"{title3}-Exercise");
                    }
                    break;
                default:
                    break;
            }
            return initialLessons;
        }
    }
}
