using System;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) :base(name, age) { }

        public override int Age
        {
            get => base.Age;
            set
            {
                if (base.Age > 15)
                    throw new ArgumentException("Child's age must be less than 15!");
                base.Age = value;
            }
        }
    }
}
