using System;
using System.Collections.Generic;
using System.Linq;
using AnimalCentre.IO.Contracts;

namespace AnimalCentre.Controller
{
    public class Engine
    {
        private AnimalCentre animalCentre;
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.animalCentre = new AnimalCentre();
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string command = this.reader.ReadData();
                    if (command == "End") break;
                    else
                    {
                        ReadCommand(command);
                    }
                }
                catch (ArgumentException e)
                {
                    this.writer.WriteLine("ArgumentException: " + e.Message);
                }
                catch (InvalidOperationException e)
                {
                    this.writer.WriteLine("InvalidOperationException: " + e.Message);
                }
            }

            this.writer.WriteLine(this.animalCentre.PrintAdoptedAnimals());
        }
        private void ReadCommand(string command)
        {
            IList<string> tokens = command.Split(" ");
            string output = String.Empty;
            string[] regData = tokens.Skip(1).ToArray();

            switch (tokens[0])
            {
                case "RegisterAnimal":

                    var animal = regData[0];
                    var name = regData[1];
                    var energy = int.Parse(regData[2]);
                    var happiness = int.Parse(regData[3]);
                    var playTime = int.Parse(regData[4]);
                    output = this.animalCentre.RegisterAnimal(animal, name, energy, happiness, playTime);
                    break;
                case "Chip":
                    string animalName = regData[0];
                    int procedureTime = int.Parse(regData[1]);
                    output = this.animalCentre.Chip(animalName, procedureTime);
                    break;
                case "Play":
                    string playName = regData[0];
                    int playProcTime = int.Parse(regData[1]);
                    output = this.animalCentre.Play(playName, playProcTime);
                    break;
                case "Fitness":
                    string fitnessName = regData[0];
                    int fitnessTime = int.Parse(regData[1]);
                    output = this.animalCentre.Fitness(fitnessName, fitnessTime);
                    break;
                case "NailTrim":
                    string nailTrimName = regData[0];
                    int nailTrimTime = int.Parse(regData[1]);
                    output = this.animalCentre.NailTrim(nailTrimName, nailTrimTime);
                    break;
                case "Vaccinate":
                    string vaccinateName = regData[0];
                    int vaccinateTime = int.Parse(regData[1]);
                    output = this.animalCentre.Vaccinate(vaccinateName, vaccinateTime);
                    break;
                case "DentalCare":
                    string dentalName = regData[0];
                    int dentalTime = int.Parse(regData[1]);
                    output = this.animalCentre.DentalCare(dentalName, dentalTime);
                    break;
                case "Adopt":
                    string adoptAnimal = regData[0];
                    string owner = regData[1];
                    output = this.animalCentre.Adopt(adoptAnimal, owner);
                    break;
                case "History":
                    output = this.animalCentre.History(tokens[1]);
                    break;
            }

            if (output != string.Empty)
                this.writer.WriteLine(output);
        }
    }
}
