using Core.Shared.Kernel.Enum;
using Core.Shared.Kernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Core.Shared.Kernel.Events
{
  public  class AssertionConcern :IAssertionConcern
  {
    private IDomainServiceContainerManager _domainServiceContainerManager;

    public AssertionConcern(IDomainServiceContainerManager domainServiceContainerManager) {
      _domainServiceContainerManager = domainServiceContainerManager;
    }

    public  bool IsSatisfiedBy(params DomainNotification[] validations)
    {
      var notificationsNotNull = validations.Where(validation => validation != null);

      NotifyAll(notificationsNotNull);

      return notificationsNotNull.Count().Equals(0);
    }

    private  void NotifyAll(IEnumerable<DomainNotification> notificationsNotNull)
    {
      notificationsNotNull.ToList().ForEach(validation =>
      {
        _domainServiceContainerManager.Notify(validation);
      });
    }

    public  DomainNotification AssertLength(string stringValue, int minimum, int maximum, string message)
    {
      int length = stringValue.Trim().Length;

      return (length < minimum || length > maximum)
          ? new DomainNotification("AssertArgumentLength", message)
          : null;
    }

    public  DomainNotification AssertListLength<T>(IEnumerable<T> list, int minimum, string message, RankNotification rank = RankNotification.Low)
    {
      return (list == null || list.Count() <= minimum)
          ? new DomainNotification("AssertArgumentLength", message, rank)
          : null;
    }

    public  DomainNotification AssertMatches(string pattern, string stringValue, string message)
    {
      Regex regex = new Regex(pattern);

      return (!regex.IsMatch(stringValue))
          ? new DomainNotification("AssertArgumentLength", message)
          : null;
    }

    public  DomainNotification AssertNotEmpty(string stringValue, string message)
    {
      return (stringValue == null || stringValue.Trim().Length == 0)
          ? new DomainNotification("AssertArgumentNotEmpty", message)
          : null;
    }

    public  DomainNotification AssertNotNull(object object1, string message, RankNotification rank = RankNotification.Low)
    {
      return (object1 == null)
          ? new DomainNotification("AssertArgumentNotNull", message, rank)
          : null;
    }

    public  DomainNotification AssertTrue(bool boolValue, string message, RankNotification rank = RankNotification.Low)
    {
      return (!boolValue)
          ? new DomainNotification("AssertArgumentTrue", message, rank)
          : null;
    }

    public  DomainNotification AssertFalse(bool boolValue, string message, RankNotification rank = RankNotification.Low)
    {
      return (boolValue)
          ? new DomainNotification("AssertArgumentTrue", message, rank)
          : null;
    }

    public  DomainNotification AssertGenericException(string message)
    {
      return (message != null && message != "")
          ? new DomainNotification("AssertArgumentGenericException", message)
          : null;
    }
  
}
}
