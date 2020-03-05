
using Core.Domain.EF.Entities;
using System.Security.Claims;

namespace Core.Domain.Singleton
{
  public class ApplicationContext
  {
    public DadosLoja LojaInContext { get; set; }
    public Praca PracaAtual { get; set; }
    public  ClaimsPrincipal UserInContext { get; set; }
    public int PedidoIdSessao { get; set; }

  }

}
