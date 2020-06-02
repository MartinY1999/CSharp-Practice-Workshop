using System;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;
        public string Type
        {
            get => type;
            set
            {
                switch (value.ToLower())
                {
                    case "meat":
                        type = value;
                        break;
                    case "veggies":
                        type = value;
                        break;
                    case "cheese":
                        type = value;
                        break;
                    case "sauce":
                        type = value;
                        break;
                    default:
                        throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 50)
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                else weight = value;
            }
        }
        public Topping() { }
        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }
        public static Topping CreateTopping(string input)
        {
            string[] parts = input.Split(' ');
            return new Topping(parts[1], double.Parse(parts[2]));
        }
        public double ToppingCalories()
        {
            return Weight * ToppingExtension.ReturnModifier(this) * 2;
        }
    }
}
