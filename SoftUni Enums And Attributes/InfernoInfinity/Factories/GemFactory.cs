using System;
using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;
using InfernoInfinity.Models.Gems;

namespace InfernoInfinity.Factories
{
    public class GemFactory
    {
        public IGem Create(string clarity, string gem)
        {
            IGem g = null;
            switch (gem)
            {
                case "Amethyst":
                    g = new Amethyst(Enum.Parse<GemClarity>(clarity));
                    break;
                case "Emerald":
                    g = new Emerald(Enum.Parse<GemClarity>(clarity));
                    break;
                case "Ruby":
                    g = new Ruby(Enum.Parse<GemClarity>(clarity));
                    break;
                default:
                    break;
            }
            return g;
        }
    }
}
