using ExerciseIV.Interfaces;

namespace ExerciseIV.Sales
{
    internal class MothersDaySales : ISale
    {
        public decimal GrossPrice { get; set; }

        public MothersDaySales(decimal grossPrice)
        {
            GrossPrice = grossPrice;
        }

        public decimal SalePrice()
        {
            return GrossPrice - (GrossPrice * 50 / 100);
        }
    }
}
