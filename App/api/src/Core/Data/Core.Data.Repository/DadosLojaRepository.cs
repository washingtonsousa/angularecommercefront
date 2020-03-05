using Core.Data.EF.Context;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.EF.Entities;
using Core.Domain.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
  public class DadosLojaRepository : RepositoryTemplate, IDadosLojaRepository
  {
    public DadosLojaRepository(MainContext context) : base(context)
    {
    }

    public async Task<DadosLoja> Get(int Id)
    {
      return await Context.DadosLoja.FirstOrDefaultAsync(d => d.IdDadosLoja == Id);
    }

    public async Task<IList<DadosLoja>> Get()
    {
      return await Context.DadosLoja.ToListAsync();
    }

    public async Task<DadosLoja> GetFirstRecord()
    {
      return await Context.DadosLoja.FirstOrDefaultAsync();
    }
  }
}
