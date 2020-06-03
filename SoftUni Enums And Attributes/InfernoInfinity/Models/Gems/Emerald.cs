using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;

namespace InfernoInfinity.Models.Gems
{
    public class Emerald : IGem
    {
        public int Strength { get; private set; }
        public int Agility { get; private set; }
        public int Vitality { get; private set; }

        public Emerald(GemClarity clarity)
        {
            this.Strength = 1 + (int) clarity;
            this.Agility = 4 + (int) clarity;
            this.Vitality = 9 + (int) clarity;
        }
    }
}
