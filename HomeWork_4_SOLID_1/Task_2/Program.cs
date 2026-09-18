
//ocp:
//این اصل میگه برای اضافه کردن یک رفتار جدید نباید مجبور شویم کد کلاس موجود را تغییر بدیم
// یعنی باز برای توسعه بسته برای تغییر کد موجود

//اگر ocp رعایت نشه

class Payment
{
    private decimal Amount { get; set; }
    private int Type { get; set; }

    public Payment(decimal amount, int type)
    {
        Amount = amount;
        Type = type;
    }

    public void Pay()
    {
        switch (Type)
        {
            case 1:
                Console.WriteLine($"Payment {Amount} by Card");
                return;

            case 2:
                Console.WriteLine($"Payment {Amount} by  PayPal");
                return;
        }
    }

}

// الان در کلاس فوق اگر بخواهیم روش پرداخت جدید اضافه کنیم باید کلاس فوق رو تغییر بدهیم

//-------------------------------------------------------------------------

// رعایت اصل OCP

//تعریف قرار داد
interface IPayment
{
    public void Pay(decimal amount);
}

class CardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Payment {amount} by Card");
    }
}
class PayPalPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Payment {amount} by PayPal");
    }
}

class Payment2
{
    private decimal Amount { get; set; }
    private IPayment Payment { get; set; }


    public Payment2(decimal amount, IPayment payment)
    {
        Amount = amount;
        Payment = payment;
    }

    public void ProcessPay()
    {
        Payment.Pay(Amount);
    }

}

// اگر الان بخواهیم روش دیگر پرداخت اضافه کنیم، لازم نیست مجبور
// را تغییر دههیم "Payment2" شویم کد کلاس 
//بلکه کد زیر را اضافه میکنیم

class BitcoinPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Payment {amount} by Bitcoin");
    }
}
