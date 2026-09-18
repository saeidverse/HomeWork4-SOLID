
using Task_7;
using Task_7.Discount;
using Task_7.Interface;
using Task_7.Invoice;
using Task_7.Message;
using Task_7.Products;

IInvoice invoice = new Invoice();
IMessage message = new Email();

Order order = new Order(invoice, message);

order.products.Add(new Laptop { Name = "Dell", Price = 500000, Discount = new PercentageDiscount(20)});
order.products.Add(new Mobile { Name = "Samsung", Price = 300000, Discount = new PercentageDiscount(10)});
order.products.Add(new Headphone { Name = "Sony", Price = 500000, Discount = new PercentageDiscount(15)});


order.Buy();


