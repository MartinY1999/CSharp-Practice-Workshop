using System;

namespace CardPower
{
    public class Program
    {
        static void Main(string[] args)
        {
            Card firstCard = Creator.CreateCard();
            Card secondCard = Creator.CreateCard();
            firstCard.CompareAndPrint(secondCard);
            Console.ReadLine();
        }
    }
}
