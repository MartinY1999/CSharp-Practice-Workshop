using System;
using System.Text.RegularExpressions;

namespace ValidTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^((([0]\d)|([1][012]))|([2][0123])):([012345]\d):([012345]\d)\s[AP]M$";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;
                else
                {
                    Match time = Regex.Match(input, pattern);
                    if (time.Success) Console.WriteLine("valid");
                    else Console.WriteLine("invalid");
                }
            }
            Console.ReadLine();
        }
    }
}
