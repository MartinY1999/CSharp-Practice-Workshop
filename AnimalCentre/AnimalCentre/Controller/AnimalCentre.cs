using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalCentre.Models.Base_Classes;
using AnimalCentre.Models.Child_Classes.AnimalDerived;
using AnimalCentre.Models.Child_Classes.ProcedureDerived;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Controller
{
    public class AnimalCentre
    {
        private IHotel hotel;
        private IDictionary<string, IProcedure> services;
        private IReadOnlyDictionary<string, List<IAnimal>> adoptedAnimals;

        public AnimalCentre()
        {
            this.hotel = new Hotel();
            services = new Dictionary<string, IProcedure>();
            this.adoptedAnimals = new Dictionary<string, List<IAnimal>>();
            InitializeServices();
        }
        private void InitializeServices()
        {
            services.Add("Chip", new Chip());
            services.Add("DentalCare", new DentalCare());
            services.Add("Fitness", new Fitness());
            services.Add("NailTrim", new NailTrim());
            services.Add("Play", new Play());
            services.Add("Vaccinate", new Vaccinate());
        }
        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            IAnimal currentAnimal = null;
            switch (type)
            {
                case "Cat":
                    currentAnimal = new Cat(name, energy, happiness, procedureTime);
                    break;
                case "Dog":
                    currentAnimal = new Dog(name, energy, happiness, procedureTime);
                    break;
                case "Lion":
                    currentAnimal = new Lion(name, energy, happiness, procedureTime);
                    break;
                case "Pig":
                    currentAnimal = new Pig(name, energy, happiness, procedureTime);
                    break;
            }

            this.hotel.Accommodate(currentAnimal);
            return $"Animal {currentAnimal.Name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            IReadOnlyDictionary<string, IAnimal> animals = this.hotel.Animals;
            services["Chip"].DoService(animals[name], procedureTime);
            return $"{animals[name].Name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
            IReadOnlyDictionary<string, IAnimal> animals = this.hotel.Animals;
            services["Vaccinate"].DoService(animals[name], procedureTime);
            return $"{animals[name].Name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {
            IReadOnlyDictionary<string, IAnimal> animals = this.hotel.Animals;
            services["Fitness"].DoService(animals[name], procedureTime);
            return $"{animals[name].Name} had fitness procedure";
        }

        public string Play(string name, int procedureTime)
        {
            IReadOnlyDictionary<string, IAnimal> animals = this.hotel.Animals;
            services["Play"].DoService(animals[name], procedureTime);
            return $"{animals[name].Name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            IReadOnlyDictionary<string, IAnimal> animals = this.hotel.Animals;
            services["DentalCare"].DoService(animals[name], procedureTime);
            return $"{animals[name].Name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            IReadOnlyDictionary<string, IAnimal> animals = this.hotel.Animals;
            services["NailTrim"].DoService(animals[name], procedureTime);
            return $"{animals[name].Name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            IReadOnlyDictionary<string, IAnimal> animals = this.hotel.Animals;
            this.hotel.Adopt(animalName, owner);
            IAnimal toAdopt = animals[animalName];
            if (animals is Dictionary<string, IAnimal> temp)
            {
                temp.Remove(toAdopt.Name);
            }

            if (!adoptedAnimals.ContainsKey(owner))
                {
                    var temporary = adoptedAnimals as IDictionary<string, List<IAnimal>>;
                    temporary?.Add(owner, new List<IAnimal>());
                }

            if (adoptedAnimals[owner].Any(x => x.Name == animalName))
                throw new ArgumentException($"Already adopted {animalName}");
            adoptedAnimals[owner].Add(toAdopt);
            if (toAdopt.IsChipped)
                return $"{owner} adopted animal with chip";
            else
                return $"{owner} adopted animal without chip";

        }

        public string History(string type)
        {
            return services[type].History();
        }

        public string PrintAdoptedAnimals()
        {
            if (adoptedAnimals.Count != 0)
            {
                StringBuilder builder = new StringBuilder();
                foreach (var pair in adoptedAnimals.OrderBy(x => x.Key))
                {
                    IList<string> names = new List<string>();
                    builder.AppendLine($"--Owner: {pair.Key}");
                    foreach (IAnimal animal in pair.Value)
                    {
                        names.Add(animal.Name);
                    }

                    builder.AppendLine($"    - Adopted animals: {String.Join(" ", names)}");
                }

                return builder.ToString().TrimEnd();
            }
            else return string.Empty;
        }
    }
}
