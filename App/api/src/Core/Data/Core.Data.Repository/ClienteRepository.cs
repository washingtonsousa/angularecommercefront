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
  public class ClienteRepository : RepositoryTemplate<Cliente>, IClienteRepository
  {
    public ClienteRepository(MainContext context) : base(context)
    {
    }

    public async Task Add(Cliente item)
    {
      await Context.Cliente.AddAsync(item);
    }

    public async Task Add(IList<Cliente> item)
    {
     await  Context.Cliente.AddRangeAsync(item);
    }

    public async Task<Cliente> Get(int Id)
    {
      return await Context.Cliente.FirstOrDefaultAsync(c => c.IdCliente == Id);
    }

    public async Task<IList<Cliente>> Get()
    {
      return await Context.Cliente.ToListAsync();
    }

    public async Task<Cliente> GetFirstRecord()
    {
      return await Context.Cliente.FirstOrDefaultAsync();
    }

    public async Task<Cliente> GetForAuthentication(string UserName, string Password)
    {
      return await Context.Cliente.Where(u => (u.DsEmail == UserName || u.DsCpfCnpj == UserName) && u.DsSenha == Password).FirstOrDefaultAsync();
    }

    public async Task<Cliente> GetByUsername(string UserName)
    {
      return await Context.Cliente.Where(u => u.DsEmail == UserName || u.DsCpfCnpj == UserName).FirstOrDefaultAsync();
    }

    public async Task<Cliente> GetByEmailOrDocument(string DsEmail, string DsCpfCnpj)
    {
      return await Context.Cliente.FirstOrDefaultAsync(u => u.DsEmail == DsEmail || u.DsCpfCnpj == DsCpfCnpj);
    }

    public async Task<bool> CheckIfExists(string DsEmail, string DsCpfCnpj)
    {
      return await Context.Cliente.Where(u => u.DsEmail == DsEmail || u.DsCpfCnpj == DsCpfCnpj).AnyAsync();
    }

    public void Remove(Cliente item)
    {
      Context.Remove(item);
    }

    public void Remove(IList<Cliente> item)
    {
      Context.RemoveRange(item);
    }

    public void Update(Cliente item)
    {
      Context.Update(item);
    }

    public void Update(IList<Cliente> item)
    {
      Context.UpdateRange(item);
    }
  }
}
