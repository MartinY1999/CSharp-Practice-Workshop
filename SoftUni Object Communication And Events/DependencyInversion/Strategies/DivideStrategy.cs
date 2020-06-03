using DependencyInversion.Strategies.Contract;

namespace DependencyInversion.Strategies
{
    public class DivideStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}
