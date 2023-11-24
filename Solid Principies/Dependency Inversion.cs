using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principies
{
  
}
public interface INotifier
{
    void Notify(string message);
}

public class EmailNotifier : INotifier
{
    public void Notify(string message)
    {
        // email
    }
}

public class SMSNotifier : INotifier
{
    public void Notify(string message)
    {
        // sms
    }
}

public class NotificationService
{
    private readonly INotifier _notifier;

    public NotificationService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void SendNotification(string message)
    {
        
        _notifier.Notify(message);
    }
}

//Burda notification olaraq basqa bir servis qurmaq istesek INotifierden implement etmek bes edir 
//kodda deyisikliye ehtiyac yoxdur