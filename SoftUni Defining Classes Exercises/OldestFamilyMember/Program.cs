using System;
using System.Collections.Generic;

namespace OldestFamilyMember
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                family.AddMembers(new Person(input[0], int.Parse(input[1])));
            }
            Console.WriteLine($"{Family.GetOldestMember(family).Name} {Family.GetOldestMember(family).Age}");
            Console.ReadLine();
        }
    }
}
