using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            BackofficeSessao = new HashSet<BackofficeSessao>();
            ClienteObservacao = new HashSet<ClienteObservacao>();
            GraficoCockpit = new HashSet<GraficoCockpit>();
            PedidoHistorico = new HashSet<PedidoHistorico>();
            PedidoLog = new HashSet<PedidoLog>();
            ProdutoLog = new HashSet<ProdutoLog>();
            UsuarioIp = new HashSet<UsuarioIp>();
            UsuarioPraca = new HashSet<UsuarioPraca>();
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

        public virtual UsuarioGrupo IdUsuarioGrupoNavigation { get; set; }
        public virtual ICollection<BackofficeSessao> BackofficeSessao { get; set; }
        public virtual ICollection<ClienteObservacao> ClienteObservacao { get; set; }
        public virtual ICollection<GraficoCockpit> GraficoCockpit { get; set; }
        public virtual ICollection<PedidoHistorico> PedidoHistorico { get; set; }
        public virtual ICollection<PedidoLog> PedidoLog { get; set; }
        public virtual ICollection<ProdutoLog> ProdutoLog { get; set; }
        public virtual ICollection<UsuarioIp> UsuarioIp { get; set; }
        public virtual ICollection<UsuarioPraca> UsuarioPraca { get; set; }
    }
}
