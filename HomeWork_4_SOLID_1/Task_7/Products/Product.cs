using Task_7.Interface;

namespace Task_7.Products
{
    abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IDiscount Discount { get; set; }
        public decimal PriceWithDiscount { get; set; }


        public decimal GetPriceWithDiscount()
        {
            if (Discount != null)
                return Discount.ApplyDiscount(Price);

            return Price;
        }

    }





}
