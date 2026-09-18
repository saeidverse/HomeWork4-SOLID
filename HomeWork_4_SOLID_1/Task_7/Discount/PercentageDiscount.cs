

using Task_7.Interface;

namespace Task_7.Discount
{
    class PercentageDiscount : IDiscount
    {
        public decimal Percentage { get; private set; }

        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
        }


        public decimal ApplyDiscount(decimal price)
        {
            return price - (price * (Percentage / 100));
        }
    }
}
