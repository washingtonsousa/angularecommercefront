using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.EF.Entities;
using Core.Domain.Repository.Abstractions;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Data.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace Core.Domain.Repository
{
  public class CategoriaRepository : RepositoryTemplate<Categoria>, ICategoriaRepository
  {
    public CategoriaRepository(MainContext context) : base(context)
    {
    }

    public async Task<Categoria> GetCategoriaDepartamento(int Id)
    {
      return await Context.Categoria.Include(c => c.ProdutoCategoriaIdCategoriaNavigation).Where(c => c.FlStatus == true && c.IdCategoriaPai == null).FirstOrDefaultAsync(c => c.IdCategoria == Id);
    }

    public async Task<IList<Categoria>> GetCategoriaDepartamentos()
    {
      return await Context.Categoria.Include(p => p.SessoesNavigation).Include(c => c.IdProdutoSkuDestaqueNavigation)
        .Where(c => c.FlStatus == true && c.IdCategoriaPai == null).OrderBy(c => c.NuOrdem).ToListAsync();
    }



  }
}
