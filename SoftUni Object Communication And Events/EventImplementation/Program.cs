using System;

namespace EventImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                    break;
                else
                    dispatcher.Name = input;
            }

            Console.ReadLine();
        }
    }
}
