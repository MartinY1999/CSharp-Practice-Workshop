using System;
using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;
using InfernoInfinity.Models.Weapons;

namespace InfernoInfinity.Factories
{
    public class WeaponFactory
    {
        public IWeapon Create(string rarity, string type, string name)
        {
            IWeapon weapon = null;
            switch (type)
            {
                case "Axe":
                    weapon = new Axe(name, Enum.Parse<WeaponClarity>(rarity));
                    break;
                case "Knife":
                    weapon = new Knife(name, Enum.Parse<WeaponClarity>(rarity));
                    break;
                case "Sword":
                    weapon = new Sword(name, Enum.Parse<WeaponClarity>(rarity));
                    break;
            }
            return weapon;
        }
    }
}
