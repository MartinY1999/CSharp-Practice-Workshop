using System.Collections.Generic;
using CardGame.Commands;

namespace CardGame.Models
{
    public class Deck
    {
        public List<string> CardNames { get; private set; }

        public Deck()
        {
            CardNames = Executioner.DeckCreate();
        }
    }
}
