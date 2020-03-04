using Core.Shared.Kernel.Enum;
using Core.Shared.Kernel.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Shared.Kernel.Interfaces
{
   public interface IAssertionConcern
  {
    bool IsSatisfiedBy(params DomainNotification[] validations);


    DomainNotification AssertLength(string stringValue, int minimum, int maximum, string message);

    DomainNotification AssertListLength<T>(IEnumerable<T> list, int minimum, string message, RankNotification rank = RankNotification.Low);

    DomainNotification AssertMatches(string pattern, string stringValue, string message);

    DomainNotification AssertNotEmpty(string stringValue, string message);

    DomainNotification AssertNotNull(object object1, string message, RankNotification rank = RankNotification.Low);

    DomainNotification AssertTrue(bool boolValue, string message, RankNotification rank = RankNotification.Low);

    DomainNotification AssertFalse(bool boolValue, string message, RankNotification rank = RankNotification.Low);

    DomainNotification AssertGenericException(string message);
  }
}
