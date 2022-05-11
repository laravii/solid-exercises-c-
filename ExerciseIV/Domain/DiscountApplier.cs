using ExerciseIV.Factories;
using ExerciseIV.Interfaces;

namespace ExerciseIV.Domain
{
    public class DiscountApplier
    {
        private ISale _saleType;
        private readonly decimal _grossPrice;

        public DiscountApplier(string saleType, decimal grossPrice)
        {
            _saleType = GetSaleType(saleType, grossPrice);
            _grossPrice = grossPrice;
        }
        public decimal FinalPrice()
        {
            return _saleType.SalePrice();
        }

        public decimal Find(string saleType, decimal grossPrice = 0)
        {
            var initialPrice = InitialPrice(grossPrice);
            _saleType = GetSaleType(saleType, initialPrice);
            return FinalPrice();
        }

        private decimal InitialPrice(decimal grossPrice)
        {
            return grossPrice != 0 ? grossPrice : _grossPrice;
        }

        private ISale GetSaleType(string searchType, decimal grossPrice = 0)
        {
            var initialPrice = InitialPrice(grossPrice);
            return new SalesFactory(searchType, initialPrice).Factory();
        }
    }
}
