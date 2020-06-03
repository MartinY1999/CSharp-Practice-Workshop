using System;
using System.Collections.Generic;
using System.Linq;
using InfernoInfinity.Factories;
using InfernoInfinity.Interfaces;
using InfernoInfinity.IO;

namespace InfernoInfinity.Controllers
{
    public class WeaponsManager
    {
        private List<IWeapon> weapons;
        private GemFactory gemFactory;
        private WeaponFactory weaponFactory;
        private IWriter<IWeapon> writer;

        public WeaponsManager()
        {
            this.weapons = new List<IWeapon>();
            this.gemFactory = new GemFactory();
            this.weaponFactory = new WeaponFactory();
            this.writer = new Writer<IWeapon>();
        }

        public void Create(string weapon, string name)
        {
            string[] parts = weapon.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            IWeapon current = weaponFactory.Create(parts[0], parts[1], name);
            weapons.Add(current);
        }

        public void AddGem(string weaponName, int index, string gemName)
        {
            string[] parts = gemName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (weapons.Any(x => x.Name == weaponName))
            {
                try
                {
                    int indexOfWeapon = weapons.FindIndex(x => x.Name == weaponName);
                    weapons[indexOfWeapon].Sockets[index] = gemFactory.Create(parts[0], parts[1]);
                }
                catch { }
            }
        }

        public void RemoveGem(string weaponName, int index)
        {
            try
            {
                int indexOfWeapon = weapons.FindIndex(x => x.Name == weaponName);
                weapons[indexOfWeapon].Sockets[index] = null;
            }
            catch { }
        }

        public void Print(string weaponName)
        {
            try
            {
                int indexOfWeapon = weapons.FindIndex(x => x.Name == weaponName);
                weapons[indexOfWeapon].CombineGems();
                writer.WriteLine(weapons[indexOfWeapon]);
                weapons.RemoveAt(indexOfWeapon);
            }
            catch { }
        }

        public void PrintAll()
        {
            foreach (IWeapon weapon in weapons)
            {
                weapon.CombineGems();
                writer.WriteLine(weapon);
            }
        }
    }
}
