using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreedyTimes
{
    public class GoldItem
    {
        public string Name { get; set; } = string.Empty;
        public long Quantity { get; set; } = 0;
        public GoldItem(string name)
        {
            Name = name;
        }
        public static List<GoldItem> ChangeGoldItems(List<GoldItem> gold, string item, long quantity)
        {
            if (gold.Any(x => x.Name == item))
            {
                int index = gold.FindIndex(x => x.Name == item);
                gold[index].Quantity += quantity;
            }
            else
            {
                GoldItem currentGold = new GoldItem(item);
                currentGold.Quantity = quantity;
                gold.Add(currentGold);
            }
            return gold;
        }
    }
}
