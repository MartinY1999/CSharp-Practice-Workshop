using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IPerson person = Citizen.Create();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }
    }
}
