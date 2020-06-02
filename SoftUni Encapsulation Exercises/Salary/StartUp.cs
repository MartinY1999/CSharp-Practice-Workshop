using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 1; i <= lines; i++)
            {
                Person current = Person.CreatePerson(Console.ReadLine().Split(' '));
                persons.Add(current);
            }
            decimal bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
