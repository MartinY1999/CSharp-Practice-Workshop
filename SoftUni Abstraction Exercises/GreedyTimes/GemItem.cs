using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreedyTimes
{
    public class GemItem
    {
        public string Name { get; set; } = string.Empty;
        public long Quantity { get; set; } = 0;
        public GemItem(string name)
        {
            Name = name;
        }
        public static List<GemItem> ChangeGemItems(List<GemItem> gems, string item, long quantity)
        {
            if (gems.Any(x => x.Name == item))
            {
                int index = gems.FindIndex(x => x.Name == item);
                gems[index].Quantity += quantity;
            }
            else
            {
                GemItem currentGem = new GemItem(item);
                currentGem.Quantity = quantity;
                gems.Add(currentGem);
            }
            return gems;
        }
    }
}
