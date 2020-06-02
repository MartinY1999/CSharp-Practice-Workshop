using System;
using System.Collections.Generic;

namespace Animals
{
    public class Program
    {
        public static void Main()
        {
            Queue<Animals> animals = GetAnimals();
            Console.WriteLine(string.Join(Environment.NewLine, animals));
        }
        private static Queue<Animals> GetAnimals()
        {
            Queue<Animals> animals = new Queue<Animals>();
            string kind = Console.ReadLine();
            while (kind != "Beast!")
            {
                string[] animalDetails = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = animalDetails[0];
                int age = int.Parse(animalDetails[1]);
                string gender = animalDetails[2];
                try
                {
                    var animal = AnimalFactory.GetAnimal(kind, name, age, gender);
                    animals.Enqueue(animal);
                }
                catch (CustomException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                kind = Console.ReadLine();
            }
            return animals;
        } 
    }
}
