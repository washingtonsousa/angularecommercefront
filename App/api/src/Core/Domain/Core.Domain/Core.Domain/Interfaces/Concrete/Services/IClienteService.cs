using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Interfaces.Concrete.Services
{
  public interface IClienteService
  {
    Task<bool> CheckIfExists(string dsEmail, string dsCpfCnpj);
    Task<Cliente> Authenticate(string userName, string password);
    void AddCliente(Cliente cliente);
    void UpdateCliente(Cliente clienteForUpdate, Cliente cliente);

    Task<Cliente> CheckIfNotExists(string dsEmail, string dsCpfCnpj);

  }
}
