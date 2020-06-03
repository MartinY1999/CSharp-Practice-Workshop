using System;

namespace CardRank
{
    public class CardRanker
    {
        public CardRanker()
        {
            
        }

        public void Print(string name)
        {
            Console.WriteLine($"{name}:");
            foreach (string cardName in Enum.GetNames(typeof(Ranks)))
            {
                Console.WriteLine($"Ordinal value: {(int)Enum.Parse(typeof(Ranks), cardName)}; Name value: {cardName}");
            }
        }
    }
}
