using System;

namespace CardPower
{
    public static class Creator
    {
        public static Card CreateCard()
        {
            string rank = Console.ReadLine();
            string suit = Console.ReadLine();
            return new Card(rank, suit);
        }
    }
}
