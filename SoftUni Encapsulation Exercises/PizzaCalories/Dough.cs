using System;

namespace PizzaCalories
{
    public class Dough
    {
        private string flour;
        private string bakingTechnique;
        private double weight;
        public string Flour
        {
            get => flour;
            set
            {
                switch (value.ToLower())
                {
                    case "white":
                        flour = value;
                        break;
                    case "wholegrain":
                        flour = value;
                        break;
                    default:
                        throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public string Technique
        {
            get => bakingTechnique;
            set
            {
                switch (value.ToLower())
                {
                    case "crispy":
                        bakingTechnique = value;
                        break;
                    case "chewy":
                        bakingTechnique = value;
                        break;
                    case "homemade":
                        bakingTechnique = value;
                        break;
                    default:
                        throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 200)
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                else
                    weight = value;
            }
        }
        public Dough() { }
        public Dough(string flour, string technique, double weight)
        {
            Flour = flour;
            Technique = technique;
            Weight = weight;
        }
        public static Dough CreateDough()
        {
            string[] parts = Console.ReadLine().Split(' ');
            return new Dough(parts[1], parts[2], double.Parse(parts[3]));
        }
        public double DoughCalories()
        {
            return (2 * Weight) * DoughExtension.ReturnFlourModifier(this) *
                   DoughExtension.ReturnTechniqueModifier(this);
        }
    }
}
