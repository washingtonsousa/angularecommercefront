using Core.Domain.Repository.Interfaces;
using Core.Data.EF.Context;
using System;
using System.Threading.Tasks;

namespace Core.Domain.Repository.UnityOfWork
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
