using System;

namespace CardRank
{
    public class Program
    {
        static void Main(string[] args)
        {
            CardRanker ranker = new CardRanker();
            ranker.Print(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
