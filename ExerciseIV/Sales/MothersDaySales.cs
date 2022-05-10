using ExerciseIV.Interfaces;

namespace ExerciseIV.Sales
{
    internal class MothersDaySales : ISale
    {
        public decimal SalePrice(decimal grossPrice)
        {
            return grossPrice - (grossPrice * 50 / 100);
        }
    }
}
