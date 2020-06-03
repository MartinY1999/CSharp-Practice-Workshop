using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame.Models
{
    public class Player
    {
        private List<Card> cards;
        private int points;

        public string Name { get; private set; }
        public int CountOfCards { get; private set; }

        public Player(string name)
        {
            Name = name;
            this.points = 0;
            CountOfCards = 0;
            this.cards = new List<Card>();
        }

        public void ReceiveCard(Card card)
        {
            this.cards.Add(card);
            CountOfCards++;
        }

        public int GetPoints()
        {
            foreach (Card card in this.cards)
            {
                this.points += card.Points;
            }
            return this.points;
        }

        public override string ToString()
        {
            return $"{Name} wins with {this.cards.OrderBy(x => x.Points).LastOrDefault()}";
        }
    }
}
