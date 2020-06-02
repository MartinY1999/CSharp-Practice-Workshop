using System;

namespace Ferrari
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ferrari ferrari = Ferrari.Create();
            Console.WriteLine(ferrari);
            Console.ReadLine();
        }
    }
}
