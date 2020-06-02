using System;

namespace AnimalFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = Chicken.CreateChicken();
            if (chicken.ValidateAge() && chicken.ValidateName())
                Console.WriteLine(chicken);
            Console.ReadLine();
        }
    }
}
