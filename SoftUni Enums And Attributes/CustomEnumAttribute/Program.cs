using System;

namespace CustomEnumAttribute
{
    public class Program
    {
        static void Main(string[] args)
        {
            DeckPrinter printer = new DeckPrinter();
            printer.Print();
            Console.ReadLine();
        }
    }
}
