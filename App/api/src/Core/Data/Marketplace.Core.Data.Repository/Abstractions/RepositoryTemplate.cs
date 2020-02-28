using Marketplace.Core.Data.EF.Context;

namespace Marketplace.Core.Domain.Repository.Abstractions
{
  public class RepositoryTemplate
  {

    protected MainContext Context;

    public RepositoryTemplate(MainContext context)
    {
      Context = context;
    }

  }
}
