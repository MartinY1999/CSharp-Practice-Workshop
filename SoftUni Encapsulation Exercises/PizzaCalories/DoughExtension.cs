using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class DoughExtension
    {
        public static double ReturnFlourModifier(Dough dough)
        {
            double modifier = 0;
            switch (dough.Flour.ToLower())
            {
                case "white":
                    modifier = 1.5;
                    break;
                case "wholegrain":
                    modifier = 1;
                    break;
                default:
                    break;
            }
            return modifier;
        }
        public static double ReturnTechniqueModifier(Dough dough)
        {
            double modifier = 0;
            switch (dough.Technique.ToLower())
            {
                case "crispy":
                    modifier = 0.9;
                    break;
                case "chewy":
                    modifier = 1.1;
                    break;
                case "homemade":
                    modifier = 1;
                    break;
                default:
                    break;
            }
            return modifier;
        }
    }
}
