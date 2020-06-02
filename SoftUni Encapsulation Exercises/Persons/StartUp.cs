using System;
using System.Collections.Generic;
using System.Linq;

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
            persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList()
                .ForEach(p => Console.WriteLine(p));
            Console.ReadLine();
        }
    }
}
