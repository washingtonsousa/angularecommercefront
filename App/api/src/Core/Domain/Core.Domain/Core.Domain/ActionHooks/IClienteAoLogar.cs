using Core.Domain.EF.Entities;
using Core.Shared.Kernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ActionHooks
{
  public interface IClienteAoLogar
  {
    void hookClienteAoLogar(Cliente cliente);
  }
}
