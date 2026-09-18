// دلیل استفاده از SRP:
// تفکیک مسئولیت‌ها
// کاهش پیچیدگی و افزایش خوانایی کد
// آسان‌تر شدن نگهداری و توسعه کد

// در صورت عدم رعایت SRP:
// تغییر هر مسئولیت می‌تواند باعث تغییر در همان کلاس شود.

// مثالی که نقض کننده SRP
class Order
{
    public int OrderId { get; set; }
    public List<Product> Products = new List<Product>();
    public decimal TotalPrice { get; set; }

    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        TotalPrice = total;
        return total;
    }

    public void SaveToDatabase()
    {
        // save to data base
    }

    public void ApplySendEmail()
    {
        //Send Email
    }
}

//-------------------------------------------------------
// SRP
// با تفکیک مسئولیت‌ها، اصل رعایت می‌شود.

// اصلاح کد
class Order_SRP
{

    public int OrderId { get; set; }
    public List<Product> Products = new List<Product>();
    public decimal TotalPrice { get; set; }


    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        TotalPrice = total;
        return total;
    }
}

class SendEmail
{
    public void ApplySendEmail()
    {
        //Send Email
    }
}

class SaveToDataBase
{
    public void ApplySaveDataBase()
    {
        //Save To DataBase
    }
}

