using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            IList<Person> civilians = new List<Person>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                    break;
                else
                    civilians.Add(Person.Create(input.Split(' ')));
            }
            int index = int.Parse(Console.ReadLine());
            int equals = GetEqual.Equal(civilians, index);
            if (equals > 0)
                Console.WriteLine($"{equals} {civilians.Count - equals} {civilians.Count}");
            else
                Console.WriteLine("No matches");
            Console.ReadLine();
        }
    }
}
