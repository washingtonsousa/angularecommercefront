using Core.Domain.EF.Entities;
using Core.Domain.Repository.Interfaces;
using System.Threading.Tasks;

namespace Core.Domain.Repository.Interfaces.Concrete
{
  public interface IClienteRepository : IRepositoryCRUD<Cliente>
  {

    Task<Cliente> GetForAuthentication(string UserName, string Password);
    Task<Cliente> GetByUsername(string UserName);
    Task<bool> CheckIfExists(string DsEmail, string DsCpfCnpj);
    Task<Cliente> GetByEmailOrDocument(string DsEmail, string DsCpfCnpj);


  }
}
