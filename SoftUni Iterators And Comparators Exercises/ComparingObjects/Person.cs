﻿using System;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Town { get; private set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }
        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result != 0)
            {
                result = this.Age.CompareTo(other.Age);
                if (result != 0)
                    return this.Town.CompareTo(other.Town);
                return 0;
            }
            return 0;
        }

        public static Person Create(string[] parts)
        {
            return new Person(parts[0], int.Parse(parts[1]), parts[2]);
        }
    }
}