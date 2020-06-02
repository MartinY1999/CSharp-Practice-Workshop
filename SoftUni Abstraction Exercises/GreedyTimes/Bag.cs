using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedyTimes
{
    public class Bag
    {
        public long Capacity { get; set; } = 0;
        public List<CashItem> Cash { get; set; } = new List<CashItem>();
        public List<GemItem> Gems { get; set; } = new List<GemItem>();
        public List<GoldItem> Gold { get; set; } = new List<GoldItem>();

        public static string GetType(string name)
        {
            if (name.Length == 3) return "Cash";
            else if (name.ToLower().EndsWith("gem")) return "Gem";
            else if (name.ToLower() == "gold") return "Gold";
            else return String.Empty;
        }
        public static bool GemValidation(Bag bag, string nameOfItem, long quantity)
        {
            if (bag.Gems.Any(x => x.Name == nameOfItem) == false)
            {
                if (bag.Gems.Sum(x => x.Quantity) + quantity > bag.Gold.Sum(x => x.Quantity)) return false;
                else return true;
            }
            else if (bag.Gems.Sum(x => x.Quantity) + quantity > bag.Gold.Sum(x => x.Quantity))
            {
                return false;
            }
            else return true;
        }
        public static bool CashValidation(Bag bag, string nameOfItem, long quantity)
        {
            if (bag.Cash.Any(x => x.Name == nameOfItem) == false)
            {
                if (bag.Cash.Sum(x => x.Quantity) + quantity > bag.Gems.Sum(x => x.Quantity)) return false;
                else return true;
            }
            else if (bag.Cash.Sum(x => x.Quantity) + quantity > bag.Gems.Sum(x => x.Quantity))
            {
                return false;
            }
            else return true;
        }
        public void FillBag(Bag bag, string type, string nameOfItem, long quantity)
        {
            switch (type)
            {
                case "Gem":
                    GemItem.ChangeGemItems(Gems, nameOfItem, quantity);
                    break;
                case "Cash":
                    CashItem.ChangeCashItems(Cash, nameOfItem, quantity);
                    break;
                case "Gold":
                    GoldItem.ChangeGoldItems(Gold, nameOfItem, quantity);
                    break;
                default:
                    break;
            }
        }
        public static void PrintItems(Bag bag) //fucked up a little
        {
            Dictionary<string, long> totalAmount = new Dictionary<string, long>();
            totalAmount.Add("GemItem", bag.Gems.Sum(x => x.Quantity));
            totalAmount.Add("CashItem", bag.Cash.Sum(x => x.Quantity));
            totalAmount.Add("GoldItem", bag.Gold.Sum(x => x.Quantity));
            foreach (var pair in totalAmount.OrderByDescending(x => x.Value))
            {
                if (pair.Key == "GemItem")
                {
                    if (bag.Gems.Sum(x => x.Quantity) != 0)
                    {
                        Console.WriteLine($"<Gem> ${bag.Gems.Sum(x => x.Quantity)}");
                        foreach (GemItem gem in bag.Gems.OrderByDescending(x => x.Name).ThenBy(x => x.Quantity))
                        {
                            Console.WriteLine($"##{gem.Name} - {gem.Quantity}");
                        }
                    }
                }
                else if (pair.Key == "CashItem")
                {
                    if (bag.Cash.Sum(x => x.Quantity) != 0)
                    {
                        Console.WriteLine($"<Cash> ${bag.Cash.Sum(x => x.Quantity)}");
                        foreach (CashItem cash in bag.Cash.OrderByDescending(x => x.Name).ThenBy(x => x.Quantity))
                        {
                            Console.WriteLine($"##{cash.Name} - {cash.Quantity}");
                        }
                    }
                }
                else
                {
                    if (bag.Gold.Sum(x => x.Quantity) != 0)
                    {
                        Console.WriteLine($"<Gold> ${bag.Gold.Sum(x => x.Quantity)}");
                        foreach (GoldItem gold in bag.Gold.OrderByDescending(x => x.Name).ThenBy(x => x.Quantity))
                        {
                            Console.WriteLine($"##{gold.Name} - {gold.Quantity}");
                        }
                    }
                }
            }
        }
    }
}