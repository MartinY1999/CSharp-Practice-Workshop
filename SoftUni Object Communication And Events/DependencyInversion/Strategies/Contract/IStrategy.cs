namespace DependencyInversion.Strategies.Contract
{
    public interface IStrategy
    {
        int Calculate(int firstOperand, int secondOperand);
    }
}
