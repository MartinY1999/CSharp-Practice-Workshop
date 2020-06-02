using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split('@');
            int leftSum = GetSum(parts[0]);
            int rightSum = GetSum(parts[1]);
            if (leftSum - rightSum >= 0) Console.WriteLine("Call her!");
            else Console.WriteLine("She is not the one.");
            Console.ReadLine();
        }
         static int GetSum(string v)
         {
             return v.Sum(x => Convert.ToInt32(Convert.ToChar(x)));
         }
    }
}
