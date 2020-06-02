using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private double price;
        public string Name
        {
            get => name;
            set
            {
                if (value.All(x => x == ' '))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                price = value;
            }
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public static List<Product> FillList(string[] input)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < input.Length; i+= 2)
            {
                Product current = new Product(input[i], double.Parse(input[i + 1]));
                products.Add(current);

            }
            return products;
        } 
    }
}
