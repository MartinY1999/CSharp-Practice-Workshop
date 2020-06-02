using System;
using System.Security.Cryptography.X509Certificates;

namespace HotelReservation
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal price = PriceCalculator.Calculate();
            PriceCalculator.PrintPrice(price);
            Console.ReadLine();
        }
    }
}
