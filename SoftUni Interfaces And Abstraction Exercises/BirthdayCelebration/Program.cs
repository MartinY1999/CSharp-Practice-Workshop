using System;
using System.Collections.Generic;
using System.Globalization;

namespace BirthdayCelebration
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthday> birthdayContainers = new List<IBirthday>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                else
                {
                    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    FillList(parts, birthdayContainers);
                }
            }
            int year = int.Parse(Console.ReadLine());
            foreach (IBirthday creature in birthdayContainers)
            {
                if (creature.BirthDate.Year == year)
                    Console.WriteLine(creature.BirthDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
        private static void FillList(string[] parts, List<IBirthday> birthdayContainers)
        {
            DateTime time = new DateTime();
            switch (parts[0])
            {
                case "Citizen":
                    time = DateTime.ParseExact( parts[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    birthdayContainers.Add(Citizen.Create(parts, time));
                    break;
                case "Robot":
                    break;
                case "Pet":
                    time = DateTime.ParseExact(parts[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    birthdayContainers.Add(Pet.Create(parts, time));
                    break;
                default:
                    break;
            }
        }
    }
}
