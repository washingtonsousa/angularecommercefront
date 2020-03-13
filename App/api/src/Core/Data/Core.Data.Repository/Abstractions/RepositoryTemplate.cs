using Core.Data.EF.Context;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Core.Domain.Repository.Abstractions
{
  public class RepositoryTemplate<T> where T : class
  {

    protected MainContext Context;

    public RepositoryTemplate(MainContext context)
    {
      Context = context;
    }


    public async Task<int> GetTotalRegisters() => await Context.Set<T>().CountAsync();

  }
}
