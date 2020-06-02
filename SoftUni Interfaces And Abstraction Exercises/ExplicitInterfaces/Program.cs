using System;

namespace ExplicitInterfaces
{
    public class Program
    {
        public static void Main()
        {
            // PrintNamesAsDifferentInterfaces(); // Both variants work
            PrintNamesWithTypeCasting(); // Both variants work
        }
        private static void PrintNamesWithTypeCasting()
        {
            string[] name = Console.ReadLine().Split();

            while (name[0] != "End")
            {
                var human = new Citizen(name[0]);

                Console.WriteLine(((IPerson)human).GetName());
                Console.WriteLine(((IResident)human).GetName());

                name = Console.ReadLine().Split();
            }
        }
        private static void PrintNamesAsDifferentInterfaces()
        {
            string[] name = Console.ReadLine().Split();
            while (name[0] != "End")
            {
                IPerson person = new Citizen(name[0]);
                Console.WriteLine(person.GetName());

                IResident resident = new Citizen(name[0]);
                Console.WriteLine(resident.GetName());

                name = Console.ReadLine().Split();
            }
        }
    }
}
