using System;
using System.Collections.Generic;
using System.Linq;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0) Console.WriteLine(0);
            else
            {
                Stack<int> stack = new Stack<int>();
                while (number != 0)
                {
                    stack.Push(number % 2);
                    number /= 2;
                }
                stack.ToList().ForEach(Console.Write);
            }
            Console.ReadLine();
        }
    }
}
