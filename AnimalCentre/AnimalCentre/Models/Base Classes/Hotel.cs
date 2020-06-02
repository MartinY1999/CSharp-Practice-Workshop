using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Base_Classes
{
    public class Hotel : IHotel
    {
        private int capacity;
        public IDictionary<string, IAnimal> animals;

        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>();
            this.capacity = 10;
        }
        public void Accommodate(IAnimal animal)
        {
            if (this.animals.Any(x => x.Value.Name == animal.Name))
                throw new ArgumentException($"Animal {animal.Name} already exist");
            if (this.animals.Count + 1 > capacity)
                throw new InvalidOperationException("Not enough capacity");
            this.animals.Add(animal.Name, animal);
        }

        public void Adopt(string animalName, string owner)
        {
            if (this.animals.Any(x => x.Value.Name == animalName) == false)
                throw new ArgumentException($"Animal {animalName} does not exist");
            IAnimal adopted = this.animals[animalName];
            adopted.Owner = owner;
            adopted.IsAdopt = true;
        }
        public IReadOnlyDictionary<string, IAnimal> Animals
        {
            get => new ReadOnlyDictionary<string, IAnimal>(this.animals);

        }
    }
}
