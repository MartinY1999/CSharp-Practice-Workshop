using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Team team = new Team("Peasants");
            List<Person> persons = new List<Person>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lines; i++)
            {
                Person current = Person.CreatePerson();
                persons.Add(current);
            }
            persons.ForEach(x => team.AddPlayer(x));
            team.PrintTeam();
            Console.ReadLine();
        }
    }
}
