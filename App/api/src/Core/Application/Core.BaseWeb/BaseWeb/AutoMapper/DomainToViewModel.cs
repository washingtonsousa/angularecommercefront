using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Core.BaseWeb.ViewModel;
using Core.Domain.EF.Entities;

namespace Core.BaseWeb.AutoMapper
{
  public class DomainToViewModel : Profile
  {
    public DomainToViewModel()
    {
      CreateMap<Categoria, DepartamentoViewModel>()
     .ForMember(dst => dst.Sessoes, opt => opt.MapFrom(src => src.SessoesNavigation))
     .ForMember(dst => dst.ProdutoDestaque, opt => opt.MapFrom(src => src.IdProdutoSkuDestaqueNavigation));
      CreateMap<Categoria, SessaoViewModel>();
      CreateMap<ProdutoSku, ProdutoSkuViewModel>();
      CreateMap<DadosLoja, DadosLojaviewModel>();
      CreateMap<Cliente, ClienteViewModel>()/* AutoMapper Ignora, pois serve apenas para retorno da autenticação*/.ForMember(m => m.Token, opt => opt.Ignore());
    }
  }
}
