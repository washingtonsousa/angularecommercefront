using Core.Data.EF.Context;

namespace Core.Domain.Repository.Abstractions
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
