using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marketplace.Core.Domain.EF.Entities;
using Marketplace.Core.Data.EF.Context;
using Marketplace.Core.Domain.Repository.Abstractions;
using Marketplace.Core.Domain.Repository.Interfaces.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Core.Domain.Repository
{
  public class CategoriaRepository : RepositoryTemplate, ICategoriaRepository
  {
    public CategoriaRepository(MainContext context) : base(context)
    {
    }

    public async Task<Categoria> Get(int Id)
    {
      return await Context.Categoria.Where(c => c.IdCategoriaPai == null).Include(c => c.TbProdutoCategoriaIdSecaoNavigation).FirstOrDefaultAsync(c => c.IdCategoria == Id);
    }

    public async Task<IList<Categoria>> Get()
    {
      return await Context.Categoria.Include(c => c.TbProdutoCategoriaIdSecaoNavigation).Where(c => c.IdCategoriaPai == null).OrderByDescending(c => c.NuOrdem).ToListAsync();
    }



  }
}
