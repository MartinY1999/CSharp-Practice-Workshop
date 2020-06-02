using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Tournament") break;
                else
                {
                    string[] parts = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    if (trainers.Any(x => x.Name == parts[0]) == false)
                    {
                        Trainer current = new Trainer(parts[0], new List<Pokemon>());
                        Pokemon currentPokemon = new Pokemon(parts[1], parts[2], int.Parse(parts[3]));
                        current.Pokemons.Add(currentPokemon);
                        trainers.Add(current);
                    }
                    else
                    {
                        int index = trainers.FindIndex(x => x.Name == parts[0]);
                        Pokemon currentPokemon = new Pokemon(parts[1], parts[2], int.Parse(parts[3]));
                        trainers[index].Pokemons.Add(currentPokemon);
                    }
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                else Trainer.TrainerStatus(trainers, input);
            }
            Trainer.PrintTrainers(trainers);
            Console.ReadLine();
        }
    }
}
