using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;

namespace InfernoInfinity.Models.Gems
{
    public class Ruby : IGem
    {
        public int Strength { get; private set; }
        public int Agility { get; private set; }
        public int Vitality { get; private set; }

        public Ruby(GemClarity clarity)
        {
            this.Strength = 7 + (int)clarity;
            this.Agility = 2 + (int)clarity;
            this.Vitality = 5 + (int)clarity;
        }
    }
}
