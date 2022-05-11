using ExerciseIV.Interfaces;

namespace ExerciseIV.Sales
{
    public class ValentineDaySales : ISale
    {
        public decimal GrossPrice { get; set; }

        public ValentineDaySales(decimal grossPrice)
        {
            GrossPrice = grossPrice;
        }

        public decimal SalePrice()
        {
            return GrossPrice - (GrossPrice * 25 / 100 - 3.99m);
        }
    }
}
