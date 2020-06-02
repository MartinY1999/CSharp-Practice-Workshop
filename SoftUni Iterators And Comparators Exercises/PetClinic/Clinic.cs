using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PetClinic
{
    public class Clinic : IEnumerable<Pet>
    {
        private IList<Pet> pets;
        private readonly int addIndex;
        private readonly int releaseIndex;

        public string Name { get; private set; }

        public Clinic()
        {

        }

        public Clinic(string name, int rooms)
        {
            if (rooms % 2 == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            this.Name = name;
            this.pets = new Pet[rooms];
            this.addIndex = rooms / 2;
            this.releaseIndex = rooms / 2;
        }

        public bool Add(Pet pet)
        {
            if (pet == null)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            for (int i = 0; i <= addIndex; i++)
            {
                if (pets[addIndex - i] == null)
                {
                    pets[addIndex - i] = pet;
                    return true;
                }
                else if (pets[addIndex + i] == null)
                {
                    pets[addIndex + 1] = pet;
                    return true;
                }
            }
            return false;
        }

        public bool Release()
        {
            for (int i = 0; i < this.pets.Count - this.releaseIndex; i++)
            {
                if (pets[releaseIndex + i] != null)
                {
                    pets[releaseIndex + i] = null;
                    return true;
                }
            }
            for (int i = this.releaseIndex - 1; i >= 0; i--)
            {
                if (pets[i] != null)
                {
                    pets[i] = null;
                    return true;
                }
            }
            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.pets.Any(x => x == null);
        }

        public void Print()
        {
            foreach (Pet pet in this)
            {
                if (pet == null)
                    Console.WriteLine("Room empty");
                else
                    Console.WriteLine(pet);
            }
        }

        public void Print(int index)
        {
            Console.WriteLine(pets[index - 1]);
        }

        public IEnumerator<Pet> GetEnumerator()
        {
            for (int i = 0; i < this.pets.Count; i++)
            {
                yield return pets[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
