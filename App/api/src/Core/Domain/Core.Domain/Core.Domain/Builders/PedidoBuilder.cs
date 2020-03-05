using Core.Domain.EF.Entities;
using Core.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Core.Domain.Builders
{
  public class PedidoBuilder : IPedidoBuilder
  {

    private IList<PedidoProdutoSku> Produtos;
    private int? IdPraca;
    private int? IdCliente;

    public PedidoBuilder()
    {
      Produtos = new List<PedidoProdutoSku>();
    }

    public void AddProduto(PedidoProdutoSku produto)
    {
      var tempProduto = Produtos.Where(p => p.IdProdutoSku == p.IdProdutoSku).FirstOrDefault();

      if (produto  == null)
      {
        Produtos.Add(produto);
      } else
      {
        tempProduto.NuQuantidade += produto.NuQuantidade;
      }
    }

    public void WithCliente(int? idCliente)
    {
      IdCliente = idCliente;
    }

    public void WithPraca(int? idPraca)
    {
      IdPraca = idPraca;
    }

    public void WithProdutos(IList<PedidoProdutoSku> produtos)
    {
      Produtos = produtos;
    }


    public Pedido Build()
    {
      Pedido pedido = new Pedido();

      pedido.IdCliente = IdCliente;
      pedido.IdPraca = IdPraca;
      pedido.PedidoProdutosSku = Produtos;

      return pedido;

    }

  }
}
