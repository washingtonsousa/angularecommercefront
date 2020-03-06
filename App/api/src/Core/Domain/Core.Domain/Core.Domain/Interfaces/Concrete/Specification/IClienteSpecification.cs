using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Interfaces.Concrete.Specification
{
  public interface IClienteSpecification
  {
    bool ValidateForSubscription(Cliente cliente);

    bool ValidateEnterpriseForSubscription(Cliente cliente);
  }
}
