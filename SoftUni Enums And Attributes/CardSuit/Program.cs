using System;

namespace CardSuit
{
    class Program
    {
        static void Main(string[] args)
        {
            CardSuiter suiter = new CardSuiter();
            suiter.Print(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
