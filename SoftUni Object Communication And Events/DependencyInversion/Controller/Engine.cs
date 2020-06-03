using System;
using System.Collections.Generic;
using DependencyInversion.Calculators.Contract;
using DependencyInversion.IO;

namespace DependencyInversion.Controller
{
    public class Engine
    {
        private IReader reader;
        private IWriter writer;
        private ICalculator calculator;

        public Engine(ICalculator calculator, IReader reader, IWriter writer)
        {
            this.calculator = calculator;
            this.reader = reader;
            this.writer = writer;
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
                    if (parts[0] == "mode")
                        this.calculator.ChangeStrategy(char.Parse(parts[1]));
                    else
                        writer.WriteLine(this.calculator.PerformCalculation(int.Parse(parts[0]),
                            int.Parse(parts[1])));
                }
            }
        }
    }
}
