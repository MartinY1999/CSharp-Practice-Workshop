using System;
using System.Xml;

namespace PersonsInfo
{
    public class Person
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly int age;
        public string FirstName => firstName;
        public string LastName => lastName;
        public int Age => age;
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
        public static Person CreatePerson()
        {
            string[] cmdArgs = Console.ReadLine().Split();
            Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
            return person;
        }
    }
}
