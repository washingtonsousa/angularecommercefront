using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Marketplace.Core.BaseWeb.ViewModel;
using Marketplace.Core.Domain.EF.Entities;

namespace Marketplace.Core.BaseWeb.AutoMapper
{
    public class DomainToViewModel : Profile
  {

 
      public DomainToViewModel()
      {
          CreateMap<Categoria, DepartamentoViewModel>()
        .ForMember(dst => dst.Sessoes, opt => opt.MapFrom(src => src.SessoesNavigation))
        .ForMember(dst => dst.ProdutoDestaque, opt => opt.MapFrom(src => src.IdProdutoSkuDestaqueNavigation));
      CreateMap<Categoria, SessaoViewModel>();
      CreateMap<TbProdutoSku, ProdutoSkuViewModel>();
    }

    
  }
}
