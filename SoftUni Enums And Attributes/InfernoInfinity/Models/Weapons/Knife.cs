using System.Linq;
using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;

namespace InfernoInfinity.Models.Weapons
{
    public class Knife : IWeapon
    {
        public string Name { get; private set; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public IGem[] Sockets { get; private set; }

        public Knife(string name, WeaponClarity clarity)
        {
            Name = name;
            MinDamage = 4 * (int)clarity;
            MaxDamage = 6 * (int)clarity;
            Sockets = new IGem[3];
        }

        public void CombineGems()
        {
            var notNull = Sockets.Where(x => x != null).ToList();
            foreach (var gem in notNull)
            {
                MinDamage += gem.Strength * 2 + gem.Agility;
                MaxDamage += gem.Strength * 3 + gem.Agility * 4;
            }
        }

        public override string ToString()
        {
            var notNull = Sockets.Where(x => x != null).ToList();
            return $"{Name}: {MinDamage}-{MaxDamage} Damage," +
                   $" +{notNull.Sum(x => x.Strength)} Strength," +
                   $" +{notNull.Sum(x => x.Agility)} Agility," +
                   $" +{notNull.Sum(x => x.Vitality)} Vitality";
        }
    }
}
