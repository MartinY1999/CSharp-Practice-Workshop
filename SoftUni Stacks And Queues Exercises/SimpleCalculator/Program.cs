using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitted = input.Split(' ');
            int result = 0;
            Stack<int> numbers = new Stack<int>();
            Stack<string> operations = new Stack<string>();
            Array.Reverse(splitted);
            foreach (string symbol in splitted)
            {
                int value;
                if (int.TryParse(symbol, out value)) numbers.Push(Convert.ToInt32(symbol));
                else
                {
                    operations.Push(symbol);
                }
            }
            result += numbers.Pop();
            while (operations.Count > 0)
            {
                int current = numbers.Pop();
                string operation = operations.Pop();
                if (operation == "+") result += current;
                else result -= current;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
