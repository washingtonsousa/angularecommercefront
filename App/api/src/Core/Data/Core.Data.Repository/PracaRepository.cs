using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Data.EF.Context;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.EF.Entities;
using Core.Domain.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Core.Data.Repository
{
  public class PracaRepository : RepositoryTemplate, IPracaRepository
  {
    public PracaRepository(MainContext context) : base(context)
    {
    }

    public async Task<Praca> Get(int Id)
    {
      return await Context.Praca.FirstOrDefaultAsync(p => p.IdPraca == Id);
    }

    public async Task<IList<Praca>> Get()
    {
      return await Context.Praca.ToListAsync();
    }

    public async Task<Praca> GetFirstRecord()
    {
      return await Context.Praca.FirstOrDefaultAsync();
    }
  }
}
