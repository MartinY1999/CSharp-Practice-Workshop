using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreedyTimes
{
    public class CashItem
    {
        public string Name { get; set; } = string.Empty;
        public long Quantity { get; set; } = 0;
        public CashItem(string name)
        {
            Name = name;
        }
        public static List<CashItem> ChangeCashItems(List<CashItem> cash, string item, long quantity)
        {
            if (cash.Any(x => x.Name == item))
            {
                int index = cash.FindIndex(x => x.Name == item);
                cash[index].Quantity += quantity;
            }
            else
            {
                CashItem currentCash = new CashItem(item);
                currentCash.Quantity = quantity;
                cash.Add(currentCash);
            }
            return cash;
        }
    }
}
