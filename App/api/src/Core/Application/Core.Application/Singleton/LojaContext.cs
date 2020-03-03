
using Core.Domain.EF.Entities;

namespace Core.Application.Singleton
{
  public class ApplicationContext
  {

    public DadosLoja LojaInContext { get; set; }
    public Praca PracaAtual { get; set; }

  }

}
