using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> firstList = new SortedSet<Person>(new FirstComparator());
            SortedSet<Person> secondList = new SortedSet<Person>(new SecondComparator());
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Person current = Person.Create();
                firstList.Add(current);
                secondList.Add(current);
            }
            foreach (Person person in firstList)
            {
                Console.WriteLine(person);
            }
            foreach (Person person in secondList)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
}
