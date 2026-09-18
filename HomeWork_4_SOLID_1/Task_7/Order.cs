
using Task_7.Interface;
using Task_7.Products;

namespace Task_7
{
    class Order
    {
        public List<Product> products { get; set; } = new List<Product>();
        public decimal TotalPrice { get; private set; }

        private IInvoice _invoice;
        private IMessage _message;

        public Order(IInvoice invoice, IMessage message)
        {
            _invoice = invoice;
            _message = message;
        }

       
        public decimal CalculateTotalPrice()
        {
            TotalPrice = 0;
            if (products != null && products.Count > 0)
            {
                foreach (var product in products)
                {
                    TotalPrice += product.GetPriceWithDiscount();
                }
            }
            else
            {
                Console.WriteLine("products null or there not");
            }

            return TotalPrice;

        }

        public void Buy()
        {
            CalculateTotalPrice();
            _invoice.Print();
            _message.Send();
        }




    }
}

