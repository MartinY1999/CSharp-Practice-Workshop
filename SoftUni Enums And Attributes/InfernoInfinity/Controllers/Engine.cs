using System;
using InfernoInfinity.Interfaces;
using InfernoInfinity.IO;

namespace InfernoInfinity.Controllers
{
    public class Engine
    {
        public void Run()
        {
            IReader reader = new Reader();
            WeaponsManager manager = new WeaponsManager();
            while (true)
            {
                string input = reader.ReadLine();
                if (input == "END") break;
                else
                    DoCommands(manager, input);
            }
            manager.PrintAll();
        }

        private static void DoCommands(WeaponsManager manager, string input)
        {
            string[] parts = input.Split(';');
            switch (parts[0])
            {
                case "Create":
                    manager.Create(parts[1], parts[2]);
                    break;
                case "Add":
                    manager.AddGem(parts[1], int.Parse(parts[2]), parts[3]);
                    break;
                case "Remove":
                    manager.RemoveGem(parts[1], int.Parse(parts[2]));
                    break;
                case "Print":
                    manager.Print(parts[1]);
                    break;
            }
        }
    }
}
