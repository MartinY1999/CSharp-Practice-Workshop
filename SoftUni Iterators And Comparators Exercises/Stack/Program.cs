using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                    break;
                else
                {
                    string[] parts = command.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                    DoCommands(stack, parts);
                }
            }
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        private static void DoCommands(Stack<string> stack, string[] parts)
        {
            switch (parts[0])
            {
                case "Push":
                    List<string> items = parts.Skip(1).Take(parts.Length - 1).ToList();
                    stack.Push(items);
                    break;
                case "Pop":
                    stack.Pop();
                    break;
                default:
                    break;
            }
        }
    }
}
