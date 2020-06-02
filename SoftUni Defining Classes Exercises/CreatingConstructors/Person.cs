using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name = "No name";
        private int age = 1;
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public int Age
        {
            get => this.age;
            set => this.age = value;
        }
        public Person() { }
        public Person(int age) :this("No name", age) { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
