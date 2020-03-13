using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Repository.Abstractions;
using Core.Data.EF.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Core.Domain.Repository
{
  public class ProdutoSkuRepository : RepositoryTemplate<ProdutoSku>, IProdutoSkuRepository
  {
    public ProdutoSkuRepository(MainContext context) : base(context)
    {
    }



 
    public async Task<ProdutoSku> Get(int Id)
    {
      return await Context.ProdutoSku.Include(u => u.IdProdutoNavigation).Include(p => p.ProdutoSkuImagem).FirstOrDefaultAsync(p => p.IdProdutoSku == Id);
    }

    public async Task<IList<ProdutoSku>> Get()
    {
      return await

        Context.ProdutoSku
        .Include(u => u.IdProdutoNavigation)
        .Include(p => p.ProdutoSkuImagem)
        .ToListAsync();
    }

    public async Task<ProdutoSku> GetFirstRecord()
    {
      return await Context.ProdutoSku.Include(u => u.IdProdutoNavigation).Include(p => p.ProdutoSkuImagem).FirstOrDefaultAsync();
    }
  }
}
