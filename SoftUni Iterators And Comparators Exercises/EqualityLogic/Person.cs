using System;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }

            return this.Age.CompareTo(other.Age);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Age.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (other == null)
            {
                return false;
            }
            return this.Age == other.Age && this.Name == other.Name;
        }

        public static Person Create()
        {
            string[] parts = Console.ReadLine().Split(' ');
            return new Person(parts[0], int.Parse(parts[1]));
        }
    }
}
