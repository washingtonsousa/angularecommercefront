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

    public async Task<Categoria> GetCategoriaDepartamento(int Id)
    {
      return await Context.Categoria.Include(c => c.TbProdutoCategoriaIdCategoriaNavigation).Where(c => c.FlStatus == true && c.IdCategoriaPai == null).FirstOrDefaultAsync(c => c.IdCategoria == Id);
    }

    public async Task<IList<Categoria>> GetCategoriaDepartamentos()
    {
      return await Context.Categoria.Include(p => p.SessoesNavigation)
        .Where(c => c.FlStatus == true && c.IdCategoriaPai == null).OrderByDescending(c => c.NuOrdem).ToListAsync();
    }



  }
}
