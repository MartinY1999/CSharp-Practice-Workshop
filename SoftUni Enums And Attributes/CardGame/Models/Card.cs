using System;

namespace CardGame.Models
{
    public class Card
    {
        public string Rank { get; private set; }
        public string Suit { get; private set; }
        public int Points { get; }

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
            Points = (int)Enum.Parse<Rank>(Rank) + (int)Enum.Parse<Suit>(Suit);
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
