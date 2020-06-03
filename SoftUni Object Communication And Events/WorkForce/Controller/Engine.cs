using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using WorkForce.Factories;
using WorkForce.Interfaces;
using WorkForce.IO;
using WorkForce.Models;

namespace WorkForce.Controller
{
    public class Engine
    {
        private readonly IReader reader;
        private readonly Executioner executioner;
        private JobCentre centre;
        private IDictionary<string, Action<string[]>> functions;

        public Engine(IReader reader, Executioner executioner, JobCentre centre)
        {
            this.reader = reader;
            this.executioner = executioner;
            this.centre = centre;
            this.functions =
            new Dictionary<string, Action<string[]>>()
            {
                {"Job", strings => this.executioner.CreateJob(this.centre, strings.Skip(1).ToArray())},
                {"StandardEmployee", strings => this.executioner.CreateEmployee(this.centre, strings)},
                {"PartTimeEmployee", strings => this.executioner.CreateEmployee(this.centre, strings)},
                {"Pass", strings => this.executioner.PassWeek(this.centre)},
                {"Status", strings => this.executioner.PrintStatus(this.centre)}
            };
        }

        public void Run()
        {
            while (true)
            {
                string input = reader.ReadLine();
                if (input == "End")
                    break;
                else
                {
                    string[] parts = reader.Split(input);
                    ExecuteCommands(parts);
                }
            }
        }

        private void ExecuteCommands(string[] parts)
        {
            functions[parts[0]].Invoke(parts);
        }
    }
}
