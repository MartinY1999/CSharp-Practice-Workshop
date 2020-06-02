using System;
using System.Numerics;

namespace ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int n = int.Parse(numbers[0]);
            string baseN = numbers[1];
            BigInteger number = (int)(BigInteger.Parse(baseN) / (BigInteger)(Math.Pow(10, baseN.Length - 1)));
            baseN = baseN.Remove(0, 1);
            while (baseN.Length > 0)
            {
                number *= n;
                number += int.Parse(baseN[0].ToString());
                baseN = baseN.Remove(0, 1);
            }
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
