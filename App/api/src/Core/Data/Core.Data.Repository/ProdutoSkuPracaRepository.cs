using Core.Data.EF.Context;
using Core.Domain.EF.Entities;
using Core.Domain.Interfaces.Concrete.Repository;
using Core.Domain.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
  public class ProdutoSkuPracaRepository : RepositoryTemplate<ProdutoSkuPraca>, IProdutoSkuPracaRepository
  {
    public ProdutoSkuPracaRepository(MainContext context) : base(context)
    {
    }

    /// <summary>
    /// Busca os produtos pela praça e demais filtros padrão
    /// </summary>
    /// <param name="IdPraca"></param>
    /// <param name="departamentoId"></param>
    /// <param name="sessaoId"></param>
    /// <param name="page"></param>
    /// <param name="take"></param>
    /// <returns></returns>
    public async Task<IList<ProdutoSkuPraca>> SearchProdutosSkuPracaByPracaId(int IdPraca, int? departamentoId, int? sessaoId, int? page, int take = 60)
      => await ApplyFilters(BuildDefaultQueryable(), departamentoId,  sessaoId).Where(p => p.IdPraca == IdPraca).Take(take).ToListAsync(); 

    /// <summary>
    /// Busca os produtos e ordena pelo que conter o menor preço
    /// </summary>
    /// <param name="departamentoId"></param>
    /// <param name="sessaoId"></param>
    /// <param name="page"></param>
    /// <param name="take"></param>
    /// <returns></returns>
    public async Task<IList<ProdutoSkuPraca>> SearchProdutosSkuPracaOrderedByPrice(int? departamentoId, int? sessaoId, int? page, int take = 60)
    {

      IQueryable<ProdutoSkuPraca> inQuery = ApplyFilters(BuildDefaultQueryable(), departamentoId, sessaoId); /// Query reservada para a chamada dos ids mais baratos de cada praça

      //Traz as chaves primarias da tabela de sku_praca que correspondem aos produtos de menor valor para exibição na busca
      IList<int> Ids = await inQuery.Select(p => p.IdProdutoSku)
        .Distinct().AsQueryable().Select(key => Context.ProdutoSkuPraca.Where(pp => pp.IdProdutoSku == key)
           .OrderByDescending(ppu => (ppu.FlPromocao.Value) ? ppu.VlProdutoSkuPromocaoPor : ppu.VlProdutoSkuPor)
           .Select(p => p.IdProdutoSkuPraca).FirstOrDefault())
       .ToListAsync();

      //Com base na lista de chaves obtidas traz os produtos mais baratos de cada praca
      IQueryable<ProdutoSkuPraca> queryBuilder = BuildDefaultQueryable()
      .Include(p => p.IdProdutoSkuNavigation.ProdutoSkuImagem)
      .Where(p => Ids.Any(inP => p.IdProdutoSkuPraca == inP))
      .AsQueryable();

      return await queryBuilder.Take(take).ToListAsync(); //Retorna o valor porém com limite de resultados para não sobrecarregar o SQL

    }

    /// <summary>
    /// Aplica os filtros para a query
    /// </summary>
    /// <param name="query"></param>
    /// <param name="departamentoId"></param>
    /// <param name="sessaoId"></param>
    /// <returns></returns>
    private static IQueryable<ProdutoSkuPraca> ApplyFilters(IQueryable<ProdutoSkuPraca> query, int? departamentoId, int? sessaoId)
    {

      /// Caso parametro de departamento seja preenchido filtra o departamento
      if (departamentoId != null)
        query = query.Where(p => p.IdProdutoSkuNavigation.IdProdutoNavigation.ProdutoCategoria.Any(c => c.IdDepartamento == departamentoId.Value)).AsQueryable();

      /// Caso parametro de sessao preenchido filtra a sessao
      if (sessaoId != null)
        query = query.Where(p => p.IdProdutoSkuNavigation.IdProdutoNavigation.ProdutoCategoria.Any(c => c.IdSecao == sessaoId.Value)).AsQueryable();

      return query;
    }


    /// <summary>
    /// Constroi a Query Default para auxiliar nos métodos de consulta
    /// Feito em forma de rafatoração
    /// </summary>
    /// <returns></returns>
    private IQueryable<ProdutoSkuPraca> BuildDefaultQueryable() =>  Context.ProdutoSkuPraca
        .AsNoTracking()
        .Include(p => p.IdProdutoSkuNavigation)
        .Include(p => p.IdProdutoSkuNavigation.IdProdutoNavigation)
        .Include(p => p.IdProdutoSkuNavigation.IdProdutoNavigation.ProdutoCategoria)
        .ThenInclude(c => c.IdSecaoNavigation)
        .ThenInclude(c => c.ProdutoCategoriaIdDepartamentoNavigation)
        .AsQueryable();
  }
}
