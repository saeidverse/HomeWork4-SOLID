
//ISP: 
// این اصل میگه اینترفیس ها نباید متد های رو داشته باشند که برای برخی کلاس ها
// پیاده سازی آن لزومی نداشته باشه . بهتر است اینترفیس ها تقسیم بندی یا تفکیک شوند .


// مثال نقض

interface IEmployee
{
    public void Work();
    public void Eat();
    public void Drive();
    public void CalculateSalary();
}
class Driver : IEmployee
{
    public void Work() { }
    public void Eat() { }
    public void Drive() { }
    public void CalculateSalary() { } // در اینجا این متد لزومی نداره پباده شود اما به اجبار شده
}
class Accountant : IEmployee
{
    public void Work() { }
    public void Eat() { }

    public void Drive() { } // در اینجا این متد لزومی نداره پباده شود اما به اجبار شده
    public void CalculateSalary() { }
}


//مثال درست:

interface IEmployee2
{
    public void Work();
    public void Eat();
}

interface IDrive
{
    public void Drive();
}
interface ICalculate
{
    public void CalculateSalary();
}

class Driver2 : IEmployee2, IDrive
{
    public void Eat() { }
    public void Work() { }
    public void Drive() { }

}
class Accountant2 : IEmployee2, ICalculate
{
    public void Eat() { }

    public void Work() { }
    public void CalculateSalary() { }

}