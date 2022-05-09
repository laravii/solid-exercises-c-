using ExerciseIII.Refactored.Interfaces;

namespace ExerciseIII.Refactored.Calculators
{
    public class CountryTaxCalculator : ITaxCountryCalculate
    {
        private readonly double _tax;

        public CountryTaxCalculator(double tax)
        {
            _tax = tax;
        }

        public double TaxPerCountryCalculater(double baseTax)
        {
            return baseTax * _tax / 100;
        }
    }
}
