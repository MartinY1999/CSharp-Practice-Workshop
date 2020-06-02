using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HotelReservation
{
    public static class PriceCalculator
    {
        public static decimal Calculate()
        {
            string[] input = Console.ReadLine().Split(' ');
            decimal pricePerDay = decimal.Parse(input[0]);
            int days = int.Parse(input[1]);
            Season season = Enum.Parse<Season>(input[2]);
            Discount discount = Discount.None;
            if (input.Length == 4)
            {
                discount = Enum.Parse<Discount>(input[3]);
            }
            return (pricePerDay * days * (int) season) * (1 - (decimal) discount / 100);
        }
        
        public static void PrintPrice(decimal price)
        {
            Console.WriteLine($"{price:F2}");
        }
    }
}
