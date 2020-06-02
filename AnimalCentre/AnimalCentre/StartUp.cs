using System;
using System.Collections;
using System.Collections.Generic;
using AnimalCentre.Controller;
using AnimalCentre.IO.Classes;
using AnimalCentre.IO.Contracts;

namespace AnimalCentre
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();
            Engine engine = new Engine(reader, writer);
            engine.Run();
            Console.ReadLine();
        }
    }
}
