using ExerciseIII.Refactored.Interfaces;

namespace ExerciseIII.Refactored.Calculators
{
    public class BaseTaxCalculator : IBaseTaxCalculate
    {
        public double BaseTaxCalculater(double receivedValue, double deductionValue)
        {
            return receivedValue - deductionValue;
        }
    }
}
