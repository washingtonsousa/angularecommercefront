using Core.Domain.EF.Entities;
using Core.Domain.Interfaces.Concrete.Services;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.Services.Abstractions;
using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;
using Encryption;
using System.Threading.Tasks;

namespace Core.Domain.Services
{
  public class ClienteService : DomainService, IClienteService
  {

    IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository,
      IDomainEventContainer domainServiceContainerManager)
      : base(domainServiceContainerManager)
    {
      _clienteRepository = clienteRepository;
    }

    public async Task<bool> CheckIfExists(string dsEmail, string dsCpfCnpj)
    {
      bool exists = await _clienteRepository.CheckIfExists(dsEmail, dsCpfCnpj);

      if (exists)
        DomainEvent.DomainNotify(AssertionConcern.AssertFalse(exists, "Cliente já possui Email e/ou CPF já cadastrado"));

      return exists;

    }

    public async Task<Cliente> CheckIfNotExists(int idCliente)
    {
      Cliente cliente = await _clienteRepository.Get(idCliente);

      if (!AssertionConcern.IsSatisfiedBy(AssertionConcern.AssertNotNull(cliente, "Cliente não encontrado")))
        return null;

      return cliente;

    }

    public async Task<Cliente> Authenticate(string userName, string password)
    {
      Cliente cliente = await _clienteRepository.GetForAuthentication(userName, Crypto.ActionEncrypt(password));

      ///Valida se autenticação funcionou e gera notificação
      if (!AssertionConcern.IsSatisfiedBy(AssertionConcern.AssertNotNull(cliente, "Usuário ou senha inválidos")))
        return null;

      return cliente;
    }

  }
}
