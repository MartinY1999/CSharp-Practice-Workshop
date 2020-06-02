using System;
using System.Collections.Generic;

namespace OpinionPoll
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Members family = new Members();
            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                family.AddMembers(new Person(input[0], int.Parse(input[1])));
            }
            List<Person> over30 = Members.ReturnOver30(family);
            foreach (Person member in over30)
            {
                Console.WriteLine(member);
            }
            Console.ReadLine();
        }
    }
}
