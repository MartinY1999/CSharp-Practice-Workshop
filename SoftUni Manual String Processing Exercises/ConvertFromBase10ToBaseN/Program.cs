using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> nums = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            int n = (int) nums[0];
            BigInteger number = nums[1];
            string result = String.Empty;
            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    result = (number % n).ToString() + result;
                    number /= n;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
