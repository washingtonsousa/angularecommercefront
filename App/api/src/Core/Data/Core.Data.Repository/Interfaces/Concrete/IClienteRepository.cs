using Core.Domain.EF.Entities;
using Core.Domain.Repository.Interfaces;
using System.Threading.Tasks;

namespace Core.Data.Repository.Interfaces.Concrete
{
  public interface IClienteRepository : IRepositoryCRUD<Cliente>
  {

    Task<Cliente> GetForAuthentication(string UserName, string Password);
    Task<Cliente> GetByUsername(string UserName);

  }
}
