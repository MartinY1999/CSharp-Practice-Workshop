using System.Linq;
using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;

namespace InfernoInfinity.Models.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; private set; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public IGem[] Sockets { get; private set; }

        public Axe(string name, WeaponClarity clarity)
        {
            Name = name;
            MinDamage = 5 * (int)clarity;
            MaxDamage = 10 * (int)clarity;
            Sockets = new IGem[4];
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
