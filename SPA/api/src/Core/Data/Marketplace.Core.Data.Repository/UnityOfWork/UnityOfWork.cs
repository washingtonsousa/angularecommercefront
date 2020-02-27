using Marketplace.Core.Domain.EF.Entities.Context;
using Marketplace.Core.Domain.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace Marketplace.Core.Domain.Repository.UnityOfWork
{
  public class UnityOfWork : IUnityOfWork
  {

    private MainContext Context;

    public UnityOfWork(MainContext context)
    {
      Context = context;
    }

    public void Commit()
    {

            try
            {

              Context.SaveChanges();

            }
            catch(Exception ex)
            {
                  
            }

      }

    public async Task CommitAsync()
    {
      try
      {

        await Context.SaveChangesAsync();

      }
      catch (Exception ex)
      {

      }
    }
  }
}
