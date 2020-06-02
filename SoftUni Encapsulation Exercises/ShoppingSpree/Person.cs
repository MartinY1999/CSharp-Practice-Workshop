using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
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
        public double Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public List<Product> Products { get; set; } = new List<Product>();
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
        }
        public static Person CreatePerson(string name, double money)
        {
            return new Person(name, money);
        }
        public void PrintData()
        {
            if (Products.Count == 0)
                Console.WriteLine($"{Name} - Nothing bought");
            else
            {
                List<string> names = new List<string>();
                Products.ForEach(x => names.Add(x.Name));
                Console.WriteLine($"{Name} - {String.Join(", ", names)}");
            }
        }
    }
}
