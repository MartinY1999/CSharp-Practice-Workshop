using System;
using System.Linq;

namespace CardSuit
{
    public class CardSuiter
    {
        public CardSuiter()
        {

        }

        public void Print(string name)
        {
            Console.WriteLine($"{name}:");
            foreach (string cardName in Enum.GetNames(typeof(Suits)))
            {
                Console.WriteLine($"Ordinal value: {(int)Enum.Parse(typeof(Suits), cardName)}; Name value: {cardName}");
            }
        }
    }
}
