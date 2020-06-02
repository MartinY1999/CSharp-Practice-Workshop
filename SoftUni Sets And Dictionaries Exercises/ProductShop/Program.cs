using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Product>> shops = new Dictionary<string, List<Product>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(',', '\t');
                if (input[0] == "Revision") break;
                else
                {
                    string shop = input[0];
                    Product product = new Product(input[1], double.Parse(input[2]));
                    if (!shops.ContainsKey(shop)) shops.Add(shop, new List<Product>());
                    shops[shop].Add(product);
                }
            }

            foreach (var pair in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}->");
                foreach (Product pr in pair.Value)
                {
                    Console.WriteLine($"Product:{pr.Name}, Price: {pr.Price}");
                }
            }

            Console.ReadLine();
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string n, double p)
        {
            Name = n;
            Price = p;
        }
    }
}
