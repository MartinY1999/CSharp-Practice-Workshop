using System;

namespace StrategyPattern
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public static Person Create()
        {
            string[] input = Console.ReadLine().Split(' ');
            return new Person(input[0], int.Parse(input[1]));
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
