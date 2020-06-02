using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> addVat = d => 6 * d / 5;
            double[] prices = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();
            prices = prices.Select(x => addVat(x)).ToArray();
            foreach (double price in prices.OrderBy(x => x))
            {
                Console.WriteLine($"{price:F2}");
            }
            Console.ReadLine();
        }
    }
}
