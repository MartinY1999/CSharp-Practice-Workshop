using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%([A-Z][a-z]+)\%.*[^%|$.]?\<(\w+)\>.*[^%|$.]?\|(\d+)\|(.*\$)$";
            List<Order> customers = new List<Order>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift") break;
                else
                {
                    Match m = Regex.Match(input, pattern);
                    if (m.Success)
                    {
                        string customer = m.Groups[1].Value;
                        string product = m.Groups[2].Value;
                        int count = int.Parse(m.Groups[3].Value);
                        string pattt = @"(\d*\.?\d*)\$$";
                        Match c = Regex.Match(m.Groups[4].Value, pattt);
                        if (c.Success)
                        {
                            double price = double.Parse(c.Groups[1].Value);
                            Order current = new Order(customer, product, count, price);
                            customers.Add(current);
                        }
                    }
                }
            }

            double sum = 0;
            foreach (Order ord in customers)
            {
                Console.WriteLine($"{ord.Customer}: {ord.Product} - {(ord.Count * ord.Price):F2}");
                sum += ord.Count * ord.Price;
            }

            Console.WriteLine($"Total income: {sum:F2}");
            Console.ReadLine();
        }
    }

    class Order
    {
        public string Customer { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public Order(string cust, string pr, int count, double price)
        {
            Customer = cust;
            Product = pr;
            Count = count;
            Price = price;
        }
    }
}
