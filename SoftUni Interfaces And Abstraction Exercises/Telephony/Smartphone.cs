using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone
    {
        public void CallNumbers()
        {
            string[] phoneNums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string number in phoneNums)
            {
                if (ValidateNumber(number))
                    Call(number);
                else
                    Console.WriteLine("Invalid number!");
            }
        }
        private void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
        private bool ValidateNumber(string number)
        {
            if (number.All(x => Char.IsDigit(x) == true))
                return true;
            else
                return false;
        }
        public void BrowseSites()
        {
            string[] sites = Console.ReadLine().Split(' ');
            foreach (string site in sites)
            {
                if (ValidateSite(site))
                    Browse(site);
                else
                    Console.WriteLine("Invalid URL!");
            }
        }
        private void Browse(string site)
        {
            Console.WriteLine($"Browsing: {site}!");
        }
        private bool ValidateSite(string site)
        {
            if (site.Any(x => Char.IsDigit(x) == true))
                return false;
            else
                return true;
        }
    }
}
