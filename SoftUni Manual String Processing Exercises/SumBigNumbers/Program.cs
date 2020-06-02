using System;
using System.Collections.Generic;
using System.Linq;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine().Trim();
            string number2 = Console.ReadLine().Trim();
            string minNumber = TakeMin(number1, number2);
            string maxNumber = TakeMax(number1, number2);
            string zeroes = new string('0', maxNumber.Length - minNumber.Length);
            minNumber = minNumber.Insert(0, zeroes);
            int toAdd = 0;
            List<int> newNumber = new List<int>();
            for (int i = minNumber.Length - 1; i >= 0; i--)
            {
                int current = Convert.ToInt32(minNumber[i].ToString()) + Convert.ToInt32(maxNumber[i].ToString()) + toAdd;
                if (current >= 10)
                {
                    if (i != 0)
                    {
                        current = current % 10;
                        toAdd = 1;
                    }
                }
                else toAdd = 0;
                newNumber.Insert(0, current);
            }
            int leftZeroes = 0;
            for (int i = 0; i < newNumber.Count; i++)
            {
                if (newNumber[i] == 0) leftZeroes++;
                else goto Done;
            }
            Done:
            newNumber = newNumber.Skip(leftZeroes).ToList();
            Console.WriteLine(String.Join("", newNumber));
            Console.ReadLine();
        }
        static string TakeMax(string number1, string number2)
        {
            if (number1.Length > number2.Length) return number1;
            else return number2;
        }
        static string TakeMin(string number1, string number2)
        {
            if (number1.Length > number2.Length) return number2;
            else return number1;
        }
    }
}
