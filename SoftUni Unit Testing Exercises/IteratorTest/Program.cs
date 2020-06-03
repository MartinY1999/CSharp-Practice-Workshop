using System;

namespace IteratorTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            CommandCenter center = new CommandCenter();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                    break;
                else
                    center.Run(command);
            }

            Console.ReadLine();
        }
    }
}
