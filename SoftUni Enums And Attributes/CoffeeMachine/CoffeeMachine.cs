using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeMachine
{
    public class CoffeeMachine
    {
        private List<Coin> coins;

        public List<CoffeeType> CoffeesSold { get; }

        public CoffeeMachine()
        {
            this.CoffeesSold = new List<CoffeeType>();
            this.coins = new List<Coin>();
        }

        public void BuyCoffee(string size, string type)
        {
            CoffeeType currentType = Enum.Parse<CoffeeType>(type);
            CoffeePrice price = Enum.Parse<CoffeePrice>(size);
            int currentBudget = 0;
            this.coins.ForEach(x => currentBudget += (int)x);
            if (currentBudget >= (int)price)
            {
                this.CoffeesSold.Add(currentType);
                this.coins.Clear();
            }
        }

        public void InsertCoin(string coin)
        {
            this.coins.Add(Enum.Parse<Coin>(coin));
        }
    }
}
