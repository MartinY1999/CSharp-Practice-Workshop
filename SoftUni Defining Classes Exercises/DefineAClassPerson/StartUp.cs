using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person human = new Person(name, age);
            Console.WriteLine(human);
            Console.ReadLine();
        }
    }
}
