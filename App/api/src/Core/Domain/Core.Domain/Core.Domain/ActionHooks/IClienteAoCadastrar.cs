using Core.Domain.ActionHooks;
using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Interfaces.ActionHooks
{
  public interface IClienteAoCadastrar
  {

    void hookAoCadastrarExecute(Cliente model);
  }
}
