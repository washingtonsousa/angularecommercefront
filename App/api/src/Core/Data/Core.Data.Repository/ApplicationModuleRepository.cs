using Core.Data.EF.Context;
using Core.Domain.Entities;
using Core.Domain.Interfaces.Concrete.Repository;
using Core.Domain.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
  public class ApplicationModuleRepository : RepositoryTemplate, IApplicationModuleRepository
  {
    public ApplicationModuleRepository(MainContext context) : base(context)
    {
    }

    public async Task Add(ApplicationModule item)
    {
      await Context.ApplicationModule.AddAsync(item);
    }

    public Task Add(IList<ApplicationModule> item)
    {
      throw new NotImplementedException();
    }

    public Task<ApplicationModule> Get(int Id)
    {
      throw new NotImplementedException();
    }

    public async Task<IList<ApplicationModule>> Get()
    {
      return await Context.ApplicationModule.AsNoTracking().ToListAsync();
    }

    public Task<ApplicationModule> GetFirstRecord()
    {
      throw new NotImplementedException();
    }

    public void Remove(ApplicationModule item)
    {
      throw new NotImplementedException();
    }

    public void Remove(IList<ApplicationModule> item)
    {
      throw new NotImplementedException();
    }

    public void Update(ApplicationModule item)
    {
      Context.ApplicationModule.Add(item);
    }

    public void Update(IList<ApplicationModule> item)
    {
      throw new NotImplementedException();
    }
  }
}
