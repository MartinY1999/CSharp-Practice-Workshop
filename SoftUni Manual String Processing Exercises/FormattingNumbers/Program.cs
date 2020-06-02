using System;
using System.Text;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            StringBuilder binaryBuild = new StringBuilder();
            string binary = Convert.ToString(a, 2);
            if (binary.Length >= 10) binaryBuild.Append(binary.Substring(0, 10));
            else binaryBuild.Append(new string('0', 10 - binary.Length) + binary);
            Console.WriteLine(String.Format(
                "|{0, -10}|{1}|{2, 10:F2}|{3, -10:F3}|",
                a.ToString("X"), binaryBuild.ToString(), b, c));
            Console.ReadLine();
        }
    }
}
