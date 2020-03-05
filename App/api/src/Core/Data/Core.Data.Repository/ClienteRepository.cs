using Core.Data.EF.Context;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.EF.Entities;
using Core.Domain.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
  public class ClienteRepository : RepositoryTemplate, IClienteRepository
  {
    public ClienteRepository(MainContext context) : base(context)
    {
    }

    public void Add(Cliente item)
    {
      throw new NotImplementedException();
    }

    public void Add(IList<Cliente> item)
    {
      throw new NotImplementedException();
    }

    public Task<Cliente> Get(int Id)
    {
      throw new NotImplementedException();
    }

    public Task<IList<Cliente>> Get()
    {
      throw new NotImplementedException();
    }

    public Task<Cliente> GetFirstRecord()
    {
      throw new NotImplementedException();
    }

    public async Task<Cliente> GetForAuthentication(string UserName, string Password)
    {
      return await Context.Cliente.Where(u => (u.DsEmail == UserName || u.DsCpfCnpj == UserName) && u.DsSenha == Password).FirstOrDefaultAsync();
    }

    public async Task<Cliente> GetByUsername(string UserName)
    {
      return await Context.Cliente.Where(u => u.DsEmail == UserName || u.DsCpfCnpj == UserName).FirstOrDefaultAsync();
    }

    public Task Remove(Cliente item)
    {
      throw new NotImplementedException();
    }

    public Task Remove(IList<Cliente> item)
    {
      throw new NotImplementedException();
    }

    public Task Update(Cliente item)
    {
      throw new NotImplementedException();
    }

    public Task Update(IList<Cliente> item)
    {
      throw new NotImplementedException();
    }
  }
}
