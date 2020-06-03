using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;

namespace InfernoInfinity.Models.Gems
{
    public class Amethyst : IGem
    {
        public int Strength { get; private set; }
        public int Agility { get; private set; }
        public int Vitality { get; private set; }

        public Amethyst(GemClarity clarity)
        {
            this.Strength = 2 + (int)clarity;
            this.Agility = 8 + (int)clarity;
            this.Vitality = 4 + (int)clarity;
        }
    }
}
