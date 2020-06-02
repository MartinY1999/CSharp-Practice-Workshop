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
                Person current = Person.CreatePerson();
                persons.Add(current);
            }
            decimal bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(x => Person.IncreaseSalary(x, bonus));
            persons.ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
    }
}
