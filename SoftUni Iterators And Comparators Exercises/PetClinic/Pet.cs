using System;

namespace PetClinic
{
    public class Pet
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Kind { get; private set; }

        public Pet(string name, int age, string kind)
        {
            Name = name;
            Age = age;
            Kind = kind;
        }

        public static Pet Create(string[] parts)
        {
            return new Pet(parts[2], int.Parse(parts[3]), parts[4]);
        }

        public override string ToString()
        {
            return $"{Name} {Age} {Kind}";
        }
    }
}
