using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IIdentifiable identifiable = Citizen.Create();
            IBirthable birthable = Citizen.Create();
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);
            Console.ReadLine();
        }
    }
}
