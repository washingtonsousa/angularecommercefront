using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Interfaces
{
  public interface IPedidoBuilder : IBuilder<Pedido>
  {
    void WithPraca(int? idPraca);
    void WithCliente(int? IdCliente);
    void WithProdutos(IList<PedidoProdutoSku> produtos);

    void AddProduto(PedidoProdutoSku produto);
  }
}
