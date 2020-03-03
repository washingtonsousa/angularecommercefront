using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbUsuario
    {
        public TbUsuario()
        {
            TbBackofficeSessao = new HashSet<TbBackofficeSessao>();
            TbClienteObservacao = new HashSet<TbClienteObservacao>();
            TbGraficoCockpit = new HashSet<TbGraficoCockpit>();
            TbPedidoHistorico = new HashSet<TbPedidoHistorico>();
            TbPedidoLog = new HashSet<TbPedidoLog>();
            TbProdutoLog = new HashSet<TbProdutoLog>();
            TbUsuarioIp = new HashSet<TbUsuarioIp>();
            TbUsuarioPraca = new HashSet<TbUsuarioPraca>();
        }

        public int IdUsuario { get; set; }
        public int IdUsuarioGrupo { get; set; }
        public bool FlStatus { get; set; }
        public decimal? PcComissaoTelevendas { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmUsuario { get; set; }
        public string DsLogin { get; set; }
        public string DsSenha { get; set; }
        public string DsEmail { get; set; }
        public string FlTipo { get; set; }
        public bool? FlSenhaAutomatica { get; set; }

        public virtual TbUsuarioGrupo IdUsuarioGrupoNavigation { get; set; }
        public virtual ICollection<TbBackofficeSessao> TbBackofficeSessao { get; set; }
        public virtual ICollection<TbClienteObservacao> TbClienteObservacao { get; set; }
        public virtual ICollection<TbGraficoCockpit> TbGraficoCockpit { get; set; }
        public virtual ICollection<TbPedidoHistorico> TbPedidoHistorico { get; set; }
        public virtual ICollection<TbPedidoLog> TbPedidoLog { get; set; }
        public virtual ICollection<TbProdutoLog> TbProdutoLog { get; set; }
        public virtual ICollection<TbUsuarioIp> TbUsuarioIp { get; set; }
        public virtual ICollection<TbUsuarioPraca> TbUsuarioPraca { get; set; }
    }
}
