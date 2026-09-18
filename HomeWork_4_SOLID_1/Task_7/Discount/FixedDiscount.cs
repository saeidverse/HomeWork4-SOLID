

using Task_7.Interface;

namespace Task_7.Discount
{
    class FixedDiscount : IDiscount
    {
        public decimal FixedAmount { get; private set; }

        public FixedDiscount(decimal fixedAmount)
        {
            FixedAmount = fixedAmount;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price - FixedAmount;
        }
    }
}
