using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashSet = new HashSet<Person>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Person current = Person.Create();
                sortedSet.Add(current);
                hashSet.Add(current);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
            Console.ReadLine();
        }
    }
}
