using Core.Domain.EF.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Domain.Repository.Interfaces.Concrete
{
  public interface ICategoriaRepository 
  {

      Task<Categoria> GetCategoriaDepartamento(int Id);

      Task<IList<Categoria>> GetCategoriaDepartamentos();

  }
}
