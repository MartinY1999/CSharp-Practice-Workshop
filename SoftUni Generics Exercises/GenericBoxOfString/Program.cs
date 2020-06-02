using System;

namespace GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Box<int> element = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
