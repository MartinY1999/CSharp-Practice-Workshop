using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int Badges = 0;
        public List<Pokemon> Pokemons { get; set; }
        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            Pokemons = pokemons;
        }
        public static List<Trainer> TrainerStatus(List<Trainer> trainers, string element)
        {
            foreach (Trainer trainer in trainers)
            {
                if (trainer.Pokemons.Any(x => x.Element == element)) trainer.Badges++;
                else
                {
                    for (int i = 0; i < trainer.Pokemons.Count; i++)
                    {
                        trainer.Pokemons[i].Health -= 10;
                        if (trainer.Pokemons[i].Health <= 0)
                        {
                            trainer.Pokemons.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            return trainers;
        }
        public static void PrintTrainers(List<Trainer> trainers)
        {
            foreach (Trainer player in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine(player);
            }
        }
        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count}";
        }
    }
}
