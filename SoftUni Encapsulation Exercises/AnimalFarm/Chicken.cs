using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalFarm
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;
        private string name;
        private int age;
        public Chicken(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get => this.name;
            internal set => this.name = value;
        }
        public int Age
        {
            get => this.age;
            protected set => this.age = value;
        }
        public double ProductPerDay
        {
            get => this.CalculateProductPerDay();
        }
        public double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
        public static Chicken CreateChicken()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            return new Chicken(name, age);
        }
        public override string ToString()
        {
            return $"Chicken {this.Name} (age {this.Age}) can produce {this.ProductPerDay} eggs per day.";
        }
        public bool ValidateAge()
        {
            if (this.Age < 0 || this.Age > 15)
            {
                Console.WriteLine("Age should be between 0 and 15.");
                return false;
            }
            else return true;
        }
        public bool ValidateName()
        {
            if (this.Name.All(x => x == ' '))
            {
                Console.WriteLine("Name cannot be empty.");
                return false;
            }
            else return true;
        }
    }
}
