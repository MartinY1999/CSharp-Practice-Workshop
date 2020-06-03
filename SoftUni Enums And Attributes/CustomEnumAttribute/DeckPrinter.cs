using System;
using System.Collections.Generic;
using System.Text;

namespace CustomEnumAttribute
{
    public class DeckPrinter
    {
        public void Print()
        {
            List<string> commands = new List<string>();
            foreach (string suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (string rank in Enum.GetNames(typeof(Rank)))
                {
                    commands.Add(Return(rank, suit));
                } 
            }
            commands.ForEach(x => Console.WriteLine(x));
        }

        private static string Return(string rank, string suit)
        {
            return $"{rank} of {suit}";
        }
    }
}
