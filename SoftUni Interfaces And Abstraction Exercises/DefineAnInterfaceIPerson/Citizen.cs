using System;

namespace PersonInfo
{
    public class Citizen : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static Citizen Create()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            return new Citizen(name, age);
        }
    }
}
