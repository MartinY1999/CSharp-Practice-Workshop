namespace DependencyInversion.Calculators.Contract
{
    public interface ICalculator
    {
        void ChangeStrategy(char mode);
        int PerformCalculation(int firstOperand, int secondOperand);
    }
}
