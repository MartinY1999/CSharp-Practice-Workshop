using System.Collections.Generic;
using DependencyInversion.Calculators.Contract;
using DependencyInversion.Strategies;
using DependencyInversion.Strategies.Changer;
using DependencyInversion.Strategies.Contract;

namespace DependencyInversion.Calculators
{
    public class PrimitiveCalculator : ICalculator
    {
        private IStrategy defaultStrategy;

        public PrimitiveCalculator()
        {
            this.defaultStrategy = new AdditionStrategy();
        }

        public void ChangeStrategy(char mode)
        {
            StrategyChanger changer = new StrategyChanger(mode);
            this.defaultStrategy = changer.GetStrategy();
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.defaultStrategy.Calculate(firstOperand, secondOperand);
        }
    }
}
