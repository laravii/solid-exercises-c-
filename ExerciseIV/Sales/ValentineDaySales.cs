using ExerciseIV.Interfaces;

namespace ExerciseIV.Sales
{
    public class ValentineDaySales : ISale
    {
        public decimal SalePrice(decimal grossPrice)
        {
            return grossPrice - (grossPrice * 25 / 100 - 3.99m);
        }
    }
}
