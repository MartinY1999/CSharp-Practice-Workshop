using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Buy
    {
        public static void Purchase(List<Person> persons, List<Product> products)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;
                else
                {
                    string[] split = input.Split(' ');
                    string name = split[0];
                    string product = split[1];
                    int index = persons.FindIndex(x => x.Name == name);
                    int indexOfP = products.FindIndex(x => x.Name == product);
                    if (TryToPurchase(persons[index], products[indexOfP]))
                    {
                        persons[index].Products.Add(products[indexOfP]);
                        Console.WriteLine($"{persons[index].Name} bought {products[indexOfP].Name}");
                    }
                    else
                        Console.WriteLine($"{persons[index].Name} can't afford {products[indexOfP].Name}");
                }
            }
        }
        public static bool TryToPurchase(Person person, Product product)
        {
            if (person.Money >= product.Price)
            {
                person.Money -= product.Price;
                return true;
            }
            else return false;
        }
    }
}
