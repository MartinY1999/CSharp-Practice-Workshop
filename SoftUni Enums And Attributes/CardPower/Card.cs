using System;

namespace CardPower
{
    public class Card : IComparable<Card>
    {
        private string suit;
        private string rank;
        private int power;

        public Card(string rank, string club)
        {
            this.rank = rank;
            this.suit = club;
            power = (int) Enum.Parse<Ranks>(rank) + (int) Enum.Parse<Suits>(suit);
        }

        public int CompareTo(Card other) => this.power.CompareTo(other.power);

        public void CompareAndPrint(Card other)
        {
            if (this.CompareTo(other) > 0)
                Console.WriteLine(this);
            else
                Console.WriteLine(other);
        }

        public override string ToString()
        {
            return $"Card name: {rank} of {suit}; Card power: {power}";
        }
    }
}
