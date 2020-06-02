using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace Google
{
    public class Person
    {
        public string Name { get; set; }
        public Company Company { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Children> Childrens { get; set; }
        public Car Car { get; set; }
        public Person(string name, Company company, List<Pokemon> pokemons, List<Parent> parents, List<Children> childrens, Car car)
        {
            Name = name;
            Company = company;
            Pokemons = pokemons;
            Parents = parents;
            Childrens = childrens;
            Car = car;
        }
        public static void PrintPerson(Person civilian)
        {
            decimal salary = 0m;
            if (civilian.Company.Salary != string.Empty)
            {
                salary = Person.SalaryResult(civilian.Company.Salary);
            }
            Console.WriteLine($"{civilian.Name}");
            Console.WriteLine($"Company:");
            if (salary != 0) Console.WriteLine($"{civilian.Company.Name} {civilian.Company.Department} {salary:F2}");
            Console.WriteLine($"Car:");
            if (civilian.Car.Speed != 0) Console.WriteLine($"{civilian.Car.Model} {civilian.Car.Speed}");
            Console.WriteLine($"Pokemon:");
            foreach (Pokemon pokemon in civilian.Pokemons)
            {
                Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
            }
            Console.WriteLine($"Parents:");
            foreach (Parent parent in civilian.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }
            Console.WriteLine($"Children:");
            foreach (Children child in civilian.Childrens)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }
        public static decimal SalaryResult(string original)
        {
            if (original.Contains('.'))
            {
                decimal result = 0;
                int indexOfDot = original.IndexOf('.');
                string leftPart = original.Substring(0, indexOfDot);
                result += decimal.Parse(leftPart);
                string rightPart = original.Substring(indexOfDot + 1, original.Length - indexOfDot - 1);
                decimal sep = 0.1m;
                foreach (char digit in rightPart)
                {
                    result += sep * decimal.Parse(Convert.ToString(digit));
                    sep /= 10;
                }
                return result;
            }
            else
            {
                return decimal.Parse(original);
            }
        }
    }
}
