using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DataTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int data = 0;
            for (int i = 1; i <= N; i++)
            {
                string line = Console.ReadLine();
                Match correctFormat = Regex.Match(String.Join("", line), @"(s:)(.*)(;r:)(.*)(;m--)(.*)");
                if (correctFormat.Success)
                {
                    string[] input = line.Split(new string[] { "s:", ";r:", ";m--" }, StringSplitOptions.RemoveEmptyEntries);
                    string sender = input[0];
                    string receiver = input[1];
                    string message = input[2];
                    StringBuilder s = new StringBuilder();
                    foreach (char symbol in sender)
                    {
                        if (symbol >= 'a' && symbol <= 'z' || symbol >= 'A' && symbol <= 'Z' || symbol == ' ')
                            s.Append(symbol);
                    }
                    StringBuilder r = new StringBuilder();
                    foreach (char symbol in receiver)
                    {
                        if (symbol >= 'a' && symbol <= 'z' || symbol >= 'A' && symbol <= 'Z' || symbol == ' ')
                            r.Append(symbol);
                    }
                    StringBuilder m = new StringBuilder();
                    foreach (char symbol in message)
                    {
                        if (symbol >= 'a' && symbol <= 'z' || symbol >= 'A' && symbol <= 'Z' || symbol == ' ')
                            m.Append(symbol);
                    }
                    if (s.Length == 0 || r.Length == 0 || m.Length == 0) continue;
                    else
                    {
                        Console.WriteLine($"{s.ToString()} says \"{m.ToString()}\" to {r.ToString()}");
                        foreach (char symbol in String.Join("", input))
                        {
                            if (symbol >= '0' && symbol <= '9') data += Convert.ToInt32(Convert.ToString(symbol));
                        }
                    }
                }
                else continue;
            }
            Console.WriteLine($"Total data transferred: {data}MB");
            Console.ReadLine();
        }
    }
}
