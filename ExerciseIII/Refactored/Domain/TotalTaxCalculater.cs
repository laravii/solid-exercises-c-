using ExerciseIII.Refactored.Interfaces;

namespace ExerciseIII.Refactored.Domain
{
    public class TotalTaxCalculater
    {
        private ITaxFactory _taxFactory;
        private IBaseTaxCalculate _baseTaxCalculate;
        public TotalTaxCalculater(ITaxFactory taxFactory, IBaseTaxCalculate baseTaxCalculate)
        {
            _taxFactory = taxFactory;
            _baseTaxCalculate = baseTaxCalculate;
        }

        public double TaxCalculator(string country, double receivedValue, double deductionValue)
        {
            var baseTax = _baseTaxCalculate.BaseTaxCalculater(receivedValue, deductionValue);
            var countryTax = _taxFactory.Factory(country);

            return countryTax.TaxPerCountryCalculater(baseTax);        }
    }
}