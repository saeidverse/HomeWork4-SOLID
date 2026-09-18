
//DIP
// کلاس ها نباید به جزئیات وابسته باشند بلکه باید به یک انتزاع وابسته باشند


//نقض DIP
class Email
{
    public void ShowEmail()
    {
        // نمایش ایمیل
    }
}

class Notification
{
    public void NotifEmail()
    {
        Email email = new Email();
        email.ShowEmail();
    }
}

//اصلاح

interface IShowMessage
{
    public void ShowMessage();
}

class SendEmail2 : IShowMessage
{
    public void ShowMessage()
    {
        // نمایش ایمیل
    }
}


class NotificationMaassage
{
    private IShowMessage _message;

    public NotificationMaassage(IShowMessage message)
    {
        _message = message;
    }



    public void NotifMaasage()
    {
        _message.ShowMessage();
    }
}