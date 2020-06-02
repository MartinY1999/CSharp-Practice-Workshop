using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> collection = new ListyIterator<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END") break;
                else
                {
                    string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    DoCommands(parts, collection);
                }
            }
            Console.ReadLine();
        }
        static void DoCommands(string[] parts, ListyIterator<string> collection)
        {
            switch (parts[0])
            {
                case "Create":
                    if (parts.Length == 1)
                        collection.List = new List<string>();
                    else
                    {
                        parts = parts.Skip(1).Take(parts.Length - 1).ToArray();
                        collection.List = new List<string>(parts);
                    }
                    break;
                case "Move":
                    Console.WriteLine(collection.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(collection.HasNext());
                    break;
                case "Print":
                    collection.Print();
                    break;
                case "PrintAll":
                    collection.PrintAll();
                    break;
                default:
                    break;
            }
        }
    }
}
