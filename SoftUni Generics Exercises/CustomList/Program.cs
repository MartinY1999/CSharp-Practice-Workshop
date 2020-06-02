using System;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> currentList = new CustomList<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                    break;
                else
                {
                    string[] parts = command.Split(' ');
                    DoCommands(currentList, parts);
                }
            }
            Console.ReadLine();
        }

        private static void DoCommands(CustomList<string> list, string[] parts)
        {
            switch (parts[0])
            {
                case "Add":
                    list.Add(parts[1]);
                    break;
                case "Remove":
                    Console.WriteLine(list.Remove(int.Parse(parts[1])));
                    break;
                case "Contains":
                    Console.WriteLine(list.Contains(parts[1]));
                    break;
                case "Swap":
                    list.Swap(int.Parse(parts[1]), int.Parse(parts[2]));
                    break;
                case "Greater":
                    Console.WriteLine(list.CountGreaterThan(parts[1]));
                    break;
                case "Max":
                    Console.WriteLine(list.Max());
                    break;
                case "Min":
                    Console.WriteLine(list.Min());
                    break;
                case "Print":
                    list.Print();
                    break;
                case "Sort":
                    list.Sort();
                    break;
                default:
                    break;
            }
        }
    }
}
