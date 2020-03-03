using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Shared.Kernel.Handles
{
  public class DomainNotificationHandler : IDomainNotificationHandler<DomainNotification>
  {
    private List<DomainNotification> _notifications = new List<DomainNotification>();

    public void Handle(DomainNotification args)
    {
      _notifications.Add(args);
    }

    public List<DomainNotification> Notify()
    {
      return GetValue();
    }

    private List<DomainNotification> GetValue()
    {
      return _notifications;
    }


    public bool HasNotifications()
    {
      return GetValue().Count > 0;
    }

    public string GetFirstNotification()
    {
      if (HasNotifications())
      {
        if (_notifications.OrderBy(x => x.Rank).FirstOrDefault().Key != "PBM")
        {
          return _notifications.OrderBy(x => x.Rank).FirstOrDefault().Value;
        }

      }

      return string.Empty;
    }
  }
}
