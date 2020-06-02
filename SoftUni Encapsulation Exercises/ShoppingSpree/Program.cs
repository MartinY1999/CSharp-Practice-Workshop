using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {';', '='}, StringSplitOptions.RemoveEmptyEntries);
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            try
            {
                for (int i = 0; i < input.Length; i += 2)
                {
                    Person person = Person.CreatePerson(input[i], double.Parse(input[i + 1]));
                    persons.Add(person);

                }
                string[] inputProducts =
                    Console.ReadLine().Split(new char[] {';', '='}, StringSplitOptions.RemoveEmptyEntries);
                products = Product.FillList(inputProducts);
                Buy.Purchase(persons, products);
                persons.ForEach(x => x.PrintData());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
