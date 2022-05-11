using ExerciseIV.Constants;
using ExerciseIV.Interfaces;
using ExerciseIV.Sales;

namespace ExerciseIV.Factories
{
    public class SalesFactory : ISalesFactory
    {
        private readonly string _saleType;
        private readonly decimal _productPrice;
        public SalesFactory(string salesType, decimal productPrice)
        {
            _productPrice = productPrice;
            _saleType = salesType;
        }
        public ISale Factory()
        {
            switch (_saleType)
            {
                case SalesType.MothersDaySales:
                    return new MothersDaySales(_productPrice);                
                case SalesType.ValentineDaySales:
                    return new ValentineDaySales(_productPrice);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
