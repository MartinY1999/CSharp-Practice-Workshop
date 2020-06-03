using System;
using System.Collections.Generic;
using System.Linq;
using CardGame.Models;

namespace CardGame.Commands
{
    public static class Executioner
    {
        public static Player PlayerCreate()
        {
            string name = Console.ReadLine();
            return new Player(name);
        }

        public static Card CardCreate(Deck deck)
        {
            string cardName = Console.ReadLine();
            string[] parts = cardName.Split(' ');
            if (!(Enum.GetNames(typeof(Rank)).Contains(parts[0])) &&
                !(Enum.GetNames(typeof(Suit)).Contains(parts[2])))
                throw new ArgumentException("No such card exists.");
            if (!deck.CardNames.Contains(cardName))
                throw new ArgumentException("Card is not in the deck.");
            deck.CardNames.Remove(cardName);
            return new Card(parts[0], parts[2]);
        }

        public static List<string> DeckCreate()
        {
            List<string> commands = new List<string>();
            foreach (string suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (string rank in Enum.GetNames(typeof(Rank)))
                {
                    commands.Add($"{rank} of {suit}");
                }
            }

            return commands;
        }

        public static void AddCards(Player player, Deck deck)
        {
            while (player.CountOfCards != 5)
            {
                try
                {
                    Card card = Executioner.CardCreate(deck);
                    player.ReceiveCard(card);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }

        public static void GetWinner(Player player1, Player player2)
        {
            int firstResult = player1.GetPoints();
            int secondResult = player2.GetPoints();
            if (firstResult > secondResult)
                Console.WriteLine(player1);
            else if (secondResult > firstResult)
                Console.WriteLine(player2);
            else
                Console.WriteLine("Draw");
        }
    }
}
