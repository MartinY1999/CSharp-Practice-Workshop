using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            Smartphone phone = new Smartphone();
            phone.CallNumbers();
            phone.BrowseSites();
            Console.ReadLine();
        }
    }
}
