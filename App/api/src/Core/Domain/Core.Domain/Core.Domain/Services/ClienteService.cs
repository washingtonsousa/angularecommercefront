using System.Threading.Tasks;
using Core.Domain.EF.Entities;
using Core.Domain.Interfaces.Concrete.Services;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.Services.Abstractions;
using Core.Shared.Kernel.Interfaces;

namespace Core.Domain.Services
{
  public class ClienteService : DomainService, IClienteService
  {

    IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository, IAssertionConcern assertionConcern, IDomainServiceContainerManager domainServiceContainerManager)
      : base(assertionConcern, domainServiceContainerManager)
    {
      _clienteRepository = clienteRepository;
    }


    public async Task<bool> VerifyIfAlreadyExists(string UserName)
    {
      bool exists = await _clienteRepository.CheckIfExists(UserName);

      if (exists)
        _domainServiceContainerManager.DomainNotify(_assertionConcern.AssertFalse(exists, "Cliente já possui Email e/ou CPF já cadastrado"));

      return exists;

    }
  }
}
