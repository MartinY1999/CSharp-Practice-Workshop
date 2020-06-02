using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> doneCommands = new Stack<string>();
            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                switch (command[0])
                {
                    case "1":
                        doneCommands.Push(text);
                        text += command[1];
                        break;
                    case "2":
                        doneCommands.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(command[1]));
                        break;
                    case "3":
                        Console.WriteLine(text[int.Parse(command[1]) - 1]);
                        break;
                    case "4":
                        text = doneCommands.Pop();
                        break;
                }
            }
        }
    }
}
