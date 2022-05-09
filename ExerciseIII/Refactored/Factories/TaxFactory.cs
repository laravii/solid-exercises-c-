using ExerciseIII.Refactored.Calculators;
using ExerciseIII.Refactored.Constants;
using ExerciseIII.Refactored.Interfaces;

namespace ExerciseIII.Refactored.Factories
{
    public class TaxFactory : ITaxFactory
    {
        public ITaxCountryCalculate Factory(string country)
        {
            switch (country)
            {
                case Countries.Brazil:
                    return new CountryTaxCalculator(CountriesTax.BrazilTax);                
                case Countries.USA:
                    return new CountryTaxCalculator(CountriesTax.USATax);                
                case Countries.UK:
                    return new CountryTaxCalculator(CountriesTax.UKTax);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
