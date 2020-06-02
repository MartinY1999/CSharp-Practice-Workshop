using System;
using System.Linq;

namespace GreedyTimes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bag bag = new Bag();
            bag.Capacity = long.Parse(Console.ReadLine());
            string[] safe = ParseArray(Console.ReadLine());
            for (int i = 0; i < safe.Length; i += 2)
            {
                string nameOfItem = safe[i];
                string type = Bag.GetType(safe[i]);
                if (type == string.Empty) continue;
                else
                {
                    long quantity = long.Parse(safe[i + 1]);
                    if (bag.Cash.Sum(x => x.Quantity) + bag.Gems.Sum(x => x.Quantity) +
                        bag.Gold.Sum(x => x.Quantity) > bag.Capacity) continue;
                    else
                    {
                        switch (type)
                        {
                            case "Gem":
                                if (!Bag.GemValidation(bag, nameOfItem, quantity)) continue;
                                break;
                            case "Cash":
                                if (!Bag.CashValidation(bag, nameOfItem, quantity)) continue;
                                break;
                            default:
                                break;
                        }
                        bag.FillBag(bag, type, nameOfItem, quantity);
                    }
                }
            }
            Bag.PrintItems(bag);
            Console.ReadLine();
        }
        private static string[] ParseArray(string input)
        {
            return input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
