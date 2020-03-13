using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application
{
  public class VitrineAppService : IVitrineAppService
  {
    public Task<IList<VitrineViewModel>> ObterVitrinesPrincipais()
    {
      throw new NotImplementedException();
    }
  }
}
