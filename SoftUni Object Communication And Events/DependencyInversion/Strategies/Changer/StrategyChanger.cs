using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DependencyInversion.Strategies.Contract;

namespace DependencyInversion.Strategies.Changer
{
    public class StrategyChanger
    {
        private char @operator;
        private IDictionary<char, Func<IStrategy>> changer;

        public StrategyChanger(char @operator)
        {
            this.@operator = @operator;
            this.changer = new Dictionary<char, Func<IStrategy>>()
            {
                {'-', () => new SubtractionStrategy()},
                {'*', () => new MultiplicationStrategy()},
                {'/', () => new DivideStrategy()}
            };
        }

        public IStrategy GetStrategy()
        {
            return this.changer[@operator].Invoke();
        }
    }
}
