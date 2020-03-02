using Marketplace.Core.Domain.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Marketplace.Core.Data.EF.Context
{
        public partial class MainContext : DbContext
        {

        private string ConnectionString;

        public MainContext(IConfiguration config)
        {
          ConnectionString = config.GetValue<string>("ConnectionStrings:BaseSistema");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          if (!optionsBuilder.IsConfigured)
          {
            optionsBuilder.UseSqlServer(ConnectionString);
          }
        }


    public virtual DbSet<ScLog> ScLog { get; set; }
        public virtual DbSet<TbAcesso> TbAcesso { get; set; }
        public virtual DbSet<TbAcessoAplicativo> TbAcessoAplicativo { get; set; }
        public virtual DbSet<TbAplicativo> TbAplicativo { get; set; }
        public virtual DbSet<TbAuditFrete> TbAuditFrete { get; set; }
        public virtual DbSet<TbAuditPedido> TbAuditPedido { get; set; }
        public virtual DbSet<TbAutorizador> TbAutorizador { get; set; }
        public virtual DbSet<TbBackofficeSessao> TbBackofficeSessao { get; set; }
        public virtual DbSet<TbBanner> TbBanner { get; set; }
        public virtual DbSet<TbBannerBusca> TbBannerBusca { get; set; }
        public virtual DbSet<TbBannerCategoria> TbBannerCategoria { get; set; }
        public virtual DbSet<TbBannerPraca> TbBannerPraca { get; set; }
        public virtual DbSet<TbBannerProduto> TbBannerProduto { get; set; }
        public virtual DbSet<TbBannerTarget> TbBannerTarget { get; set; }
        public virtual DbSet<TbBannerVitrine> TbBannerVitrine { get; set; }
        public virtual DbSet<TbBusca> TbBusca { get; set; }
        public virtual DbSet<TbCartaoClientePbm> TbCartaoClientePbm { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<TbCategoriaSeo> TbCategoriaSeo { get; set; }
        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbClienteEndereco> TbClienteEndereco { get; set; }
        public virtual DbSet<TbClienteEnderecoTipo> TbClienteEnderecoTipo { get; set; }
        public virtual DbSet<TbClienteObservacao> TbClienteObservacao { get; set; }
        public virtual DbSet<TbClienteToken> TbClienteToken { get; set; }
        public virtual DbSet<TbConexao> TbConexao { get; set; }
        public virtual DbSet<TbConexaoPraca> TbConexaoPraca { get; set; }
        public virtual DbSet<TbConteudo> TbConteudo { get; set; }
        public virtual DbSet<TbConteudoCategoria> TbConteudoCategoria { get; set; }
        public virtual DbSet<TbConteudoConteudoLocal> TbConteudoConteudoLocal { get; set; }
        public virtual DbSet<TbConteudoLocal> TbConteudoLocal { get; set; }
        public virtual DbSet<TbConteudoSeo> TbConteudoSeo { get; set; }
        public virtual DbSet<TbConteudoTarget> TbConteudoTarget { get; set; }
        public virtual DbSet<TbConteudoTipo> TbConteudoTipo { get; set; }
        public virtual DbSet<TbDadosLoja> TbDadosLoja { get; set; }
        public virtual DbSet<TbDeparaClientesVfarma> TbDeparaClientesVfarma { get; set; }
        public virtual DbSet<TbDeparaFmp> TbDeparaFmp { get; set; }
        public virtual DbSet<TbDiaSemana> TbDiaSemana { get; set; }
        public virtual DbSet<TbEanListaTmp> TbEanListaTmp { get; set; }
        public virtual DbSet<TbEbit> TbEbit { get; set; }
        public virtual DbSet<TbEmail> TbEmail { get; set; }
        public virtual DbSet<TbEmailTag> TbEmailTag { get; set; }
        public virtual DbSet<TbEmailTipo> TbEmailTipo { get; set; }
        public virtual DbSet<TbEspecificacao> TbEspecificacao { get; set; }
        public virtual DbSet<TbEspecificacaoTipo> TbEspecificacaoTipo { get; set; }
        public virtual DbSet<TbEtiqueta> TbEtiqueta { get; set; }
        public virtual DbSet<TbEtiquetaTipo> TbEtiquetaTipo { get; set; }
        public virtual DbSet<TbFaq> TbFaq { get; set; }
        public virtual DbSet<TbFaqCategoria> TbFaqCategoria { get; set; }
        public virtual DbSet<TbFiltro> TbFiltro { get; set; }
        public virtual DbSet<TbFiltroTipo> TbFiltroTipo { get; set; }
        public virtual DbSet<TbFiltroTipoCategoria> TbFiltroTipoCategoria { get; set; }
        public virtual DbSet<TbFormaPagamento> TbFormaPagamento { get; set; }
        public virtual DbSet<TbFormaPagamentoTipo> TbFormaPagamentoTipo { get; set; }
        public virtual DbSet<TbGateway> TbGateway { get; set; }
        public virtual DbSet<TbGatewayPraca> TbGatewayPraca { get; set; }
        public virtual DbSet<TbGatewayTipo> TbGatewayTipo { get; set; }
        public virtual DbSet<TbGatewayTipoFormaPagamento> TbGatewayTipoFormaPagamento { get; set; }
        public virtual DbSet<TbGondola> TbGondola { get; set; }
        public virtual DbSet<TbGondolaProdutoSku> TbGondolaProdutoSku { get; set; }
        public virtual DbSet<TbGraficoCockpit> TbGraficoCockpit { get; set; }
        public virtual DbSet<TbImpAtualizaEstoquePreco> TbImpAtualizaEstoquePreco { get; set; }
        public virtual DbSet<TbImpAtualizaTitleMeta> TbImpAtualizaTitleMeta { get; set; }
        public virtual DbSet<TbLayout> TbLayout { get; set; }
        public virtual DbSet<TbLayoutPosicao> TbLayoutPosicao { get; set; }
        public virtual DbSet<TbListaDesejo> TbListaDesejo { get; set; }
        public virtual DbSet<TbListaDesejoPeriodo> TbListaDesejoPeriodo { get; set; }
        public virtual DbSet<TbListaDesejoProdutoSku> TbListaDesejoProdutoSku { get; set; }
        public virtual DbSet<TbLog> TbLog { get; set; }
        public virtual DbSet<TbLogProcedure> TbLogProcedure { get; set; }
        public virtual DbSet<TbLogTelevendas> TbLogTelevendas { get; set; }
        public virtual DbSet<TbLojaEspecial> TbLojaEspecial { get; set; }
        public virtual DbSet<TbLojaEspecialBanner> TbLojaEspecialBanner { get; set; }
        public virtual DbSet<TbLojaEspecialCategoria> TbLojaEspecialCategoria { get; set; }
        public virtual DbSet<TbLojaEspecialDepartamento> TbLojaEspecialDepartamento { get; set; }
        public virtual DbSet<TbLojaEspecialMarca> TbLojaEspecialMarca { get; set; }
        public virtual DbSet<TbLojaEspecialPosicao> TbLojaEspecialPosicao { get; set; }
        public virtual DbSet<TbLojaEspecialProduto> TbLojaEspecialProduto { get; set; }
        public virtual DbSet<TbLojaEspecialSecao> TbLojaEspecialSecao { get; set; }
        public virtual DbSet<TbLojaEspecialVitrine> TbLojaEspecialVitrine { get; set; }
        public virtual DbSet<TbLojaEspecialVitrineProduto> TbLojaEspecialVitrineProduto { get; set; }
        public virtual DbSet<TbLojaFisica> TbLojaFisica { get; set; }
        public virtual DbSet<TbMapeamentoUrl> TbMapeamentoUrl { get; set; }
        public virtual DbSet<TbMarca> TbMarca { get; set; }
        public virtual DbSet<TbMensagem> TbMensagem { get; set; }
        public virtual DbSet<TbMensagemCategoria> TbMensagemCategoria { get; set; }
        public virtual DbSet<TbMensagemMarca> TbMensagemMarca { get; set; }
        public virtual DbSet<TbMensagemPrincipioAtivo> TbMensagemPrincipioAtivo { get; set; }
        public virtual DbSet<TbMensagemProdutoControle> TbMensagemProdutoControle { get; set; }
        public virtual DbSet<TbMensagemProdutoFamilia> TbMensagemProdutoFamilia { get; set; }
        public virtual DbSet<TbMensagemProdutoTipo> TbMensagemProdutoTipo { get; set; }
        public virtual DbSet<TbModalidadeEntrega> TbModalidadeEntrega { get; set; }
        public virtual DbSet<TbModalidadeEntregaAgenda> TbModalidadeEntregaAgenda { get; set; }
        public virtual DbSet<TbModalidadeEntregaCep> TbModalidadeEntregaCep { get; set; }
        public virtual DbSet<TbModalidadeEntregaLoja> TbModalidadeEntregaLoja { get; set; }
        public virtual DbSet<TbModalidadeEntregaRestricao> TbModalidadeEntregaRestricao { get; set; }
        public virtual DbSet<TbModalidadeEntregaTipo> TbModalidadeEntregaTipo { get; set; }
        public virtual DbSet<TbNewsletter> TbNewsletter { get; set; }
        public virtual DbSet<TbOfertaEspecial> TbOfertaEspecial { get; set; }
        public virtual DbSet<TbPagamento> TbPagamento { get; set; }
        public virtual DbSet<TbPagamentoGateway> TbPagamentoGateway { get; set; }
        public virtual DbSet<TbPagamentoParcela> TbPagamentoParcela { get; set; }
        public virtual DbSet<TbParceiro> TbParceiro { get; set; }
        public virtual DbSet<TbParceiroXmlProduto> TbParceiroXmlProduto { get; set; }
        public virtual DbSet<TbPedido> TbPedido { get; set; }
        public virtual DbSet<TbPedidoEntrega> TbPedidoEntrega { get; set; }
        public virtual DbSet<TbPedidoGestaoRisco> TbPedidoGestaoRisco { get; set; }
        public virtual DbSet<TbPedidoHistorico> TbPedidoHistorico { get; set; }
        public virtual DbSet<TbPedidoLog> TbPedidoLog { get; set; }
        public virtual DbSet<TbPedidoOrigem> TbPedidoOrigem { get; set; }
        public virtual DbSet<TbPedidoPagamento> TbPedidoPagamento { get; set; }
        public virtual DbSet<TbPedidoPagamentoLog> TbPedidoPagamentoLog { get; set; }
        public virtual DbSet<TbPedidoProdutoKit> TbPedidoProdutoKit { get; set; }
        public virtual DbSet<TbPedidoProdutoSku> TbPedidoProdutoSku { get; set; }
        public virtual DbSet<TbPedidoSevenpdv> TbPedidoSevenpdv { get; set; }
        public virtual DbSet<TbPedidoStatus> TbPedidoStatus { get; set; }
        public virtual DbSet<TbPedidoStatusPbm> TbPedidoStatusPbm { get; set; }
        public virtual DbSet<TbPosicao> TbPosicao { get; set; }
        public virtual DbSet<TbPraca> TbPraca { get; set; }
        public virtual DbSet<TbPracaCep> TbPracaCep { get; set; }
        public virtual DbSet<TbPrincipioAtivo> TbPrincipioAtivo { get; set; }
        public virtual DbSet<TbProduto> TbProduto { get; set; }
        public virtual DbSet<TbProdutoAtrStagging> TbProdutoAtrStagging { get; set; }
        public virtual DbSet<TbProdutoAvaliacao> TbProdutoAvaliacao { get; set; }
        public virtual DbSet<TbProdutoCategoria> TbProdutoCategoria { get; set; }
        public virtual DbSet<TbProdutoControle> TbProdutoControle { get; set; }
        public virtual DbSet<TbProdutoControleStagging> TbProdutoControleStagging { get; set; }
        public virtual DbSet<TbProdutoDescricao> TbProdutoDescricao { get; set; }
        public virtual DbSet<TbProdutoDescricaoTipo> TbProdutoDescricaoTipo { get; set; }
        public virtual DbSet<TbProdutoEtiqueta> TbProdutoEtiqueta { get; set; }
        public virtual DbSet<TbProdutoFamilia> TbProdutoFamilia { get; set; }
        public virtual DbSet<TbProdutoFamiliaModalidade> TbProdutoFamiliaModalidade { get; set; }
        public virtual DbSet<TbProdutoFamiliaStagging> TbProdutoFamiliaStagging { get; set; }
        public virtual DbSet<TbProdutoKit> TbProdutoKit { get; set; }
        public virtual DbSet<TbProdutoLancamento> TbProdutoLancamento { get; set; }
        public virtual DbSet<TbProdutoLog> TbProdutoLog { get; set; }
        public virtual DbSet<TbProdutoPrincipioAtivo> TbProdutoPrincipioAtivo { get; set; }
        public virtual DbSet<TbProdutoPrincipioAtivoBkp20191018> TbProdutoPrincipioAtivoBkp20191018 { get; set; }
        public virtual DbSet<TbProdutoSeo> TbProdutoSeo { get; set; }
        public virtual DbSet<ProdutoSku> TbProdutoSku { get; set; }
        public virtual DbSet<TbProdutoSkuAviseMe> TbProdutoSkuAviseMe { get; set; }
        public virtual DbSet<TbProdutoSkuEspecificacao> TbProdutoSkuEspecificacao { get; set; }
        public virtual DbSet<TbProdutoSkuFiltro> TbProdutoSkuFiltro { get; set; }
        public virtual DbSet<TbProdutoSkuGenerico> TbProdutoSkuGenerico { get; set; }
        public virtual DbSet<TbProdutoSkuImagem> TbProdutoSkuImagem { get; set; }
        public virtual DbSet<TbProdutoSkuOutrasOrigens> TbProdutoSkuOutrasOrigens { get; set; }
        public virtual DbSet<TbProdutoSkuPraca> TbProdutoSkuPraca { get; set; }
        public virtual DbSet<TbProdutoSkuRelacionado> TbProdutoSkuRelacionado { get; set; }
        public virtual DbSet<TbProdutoSkuSemImagens> TbProdutoSkuSemImagens { get; set; }
        public virtual DbSet<TbProdutoSkuVendaCasada> TbProdutoSkuVendaCasada { get; set; }
        public virtual DbSet<TbProdutoTipo> TbProdutoTipo { get; set; }
        public virtual DbSet<TbProdutoTipoStagging> TbProdutoTipoStagging { get; set; }
        public virtual DbSet<TbProdutoVideo> TbProdutoVideo { get; set; }
        public virtual DbSet<TbProdutosAtualizados> TbProdutosAtualizados { get; set; }
        public virtual DbSet<TbPrograma> TbPrograma { get; set; }
        public virtual DbSet<TbProgramaProduto> TbProgramaProduto { get; set; }
        public virtual DbSet<TbPromocao> TbPromocao { get; set; }
        public virtual DbSet<TbPromocaoAcao> TbPromocaoAcao { get; set; }
        public virtual DbSet<TbPromocaoBeneficio> TbPromocaoBeneficio { get; set; }
        public virtual DbSet<TbPromocaoCategoria> TbPromocaoCategoria { get; set; }
        public virtual DbSet<TbPromocaoCep> TbPromocaoCep { get; set; }
        public virtual DbSet<TbPromocaoCliente> TbPromocaoCliente { get; set; }
        public virtual DbSet<TbPromocaoCupom> TbPromocaoCupom { get; set; }
        public virtual DbSet<TbPromocaoCupomUtilizado> TbPromocaoCupomUtilizado { get; set; }
        public virtual DbSet<TbPromocaoMarca> TbPromocaoMarca { get; set; }
        public virtual DbSet<TbPromocaoModalidade> TbPromocaoModalidade { get; set; }
        public virtual DbSet<TbPromocaoPagamento> TbPromocaoPagamento { get; set; }
        public virtual DbSet<TbPromocaoPraca> TbPromocaoPraca { get; set; }
        public virtual DbSet<TbPromocaoProduto> TbPromocaoProduto { get; set; }
        public virtual DbSet<TbPromocaoTipo> TbPromocaoTipo { get; set; }
        public virtual DbSet<TbPromocaoTipoAcao> TbPromocaoTipoAcao { get; set; }
        public virtual DbSet<TbPromocaoTipoBeneficio> TbPromocaoTipoBeneficio { get; set; }
        public virtual DbSet<TbQuemComprouComprouTambem> TbQuemComprouComprouTambem { get; set; }
        public virtual DbSet<TbQuemViuComprou> TbQuemViuComprou { get; set; }
        public virtual DbSet<TbQuemViuViuTambem> TbQuemViuViuTambem { get; set; }
        public virtual DbSet<TbRedeSocial> TbRedeSocial { get; set; }
        public virtual DbSet<TbRodape> TbRodape { get; set; }
        public virtual DbSet<TbSecApps> TbSecApps { get; set; }
        public virtual DbSet<TbSecGroups> TbSecGroups { get; set; }
        public virtual DbSet<TbSecGroupsApps> TbSecGroupsApps { get; set; }
        public virtual DbSet<TbSecLogged> TbSecLogged { get; set; }
        public virtual DbSet<TbSecUsers> TbSecUsers { get; set; }
        public virtual DbSet<TbSecUsersGroups> TbSecUsersGroups { get; set; }
        public virtual DbSet<TbServicoCorreios> TbServicoCorreios { get; set; }
        public virtual DbSet<TbServicoTotalexpress> TbServicoTotalexpress { get; set; }
        public virtual DbSet<TbSevenpdvLogon> TbSevenpdvLogon { get; set; }
        public virtual DbSet<TbSevenpdvSessao> TbSevenpdvSessao { get; set; }
        public virtual DbSet<TbSkuPracaMovimentacao> TbSkuPracaMovimentacao { get; set; }
        public virtual DbSet<TbSli> TbSli { get; set; }
        public virtual DbSet<TbSuperDesconto> TbSuperDesconto { get; set; }
        public virtual DbSet<TbUploadImagem> TbUploadImagem { get; set; }
        public virtual DbSet<TbUsuario> TbUsuario { get; set; }
        public virtual DbSet<TbUsuarioGrupo> TbUsuarioGrupo { get; set; }
        public virtual DbSet<TbUsuarioGrupoAcesso> TbUsuarioGrupoAcesso { get; set; }
        public virtual DbSet<TbUsuarioGrupoTelevendas> TbUsuarioGrupoTelevendas { get; set; }
        public virtual DbSet<TbUsuarioIp> TbUsuarioIp { get; set; }
        public virtual DbSet<TbUsuarioPraca> TbUsuarioPraca { get; set; }
        public virtual DbSet<TbUsuarioRecuperacao> TbUsuarioRecuperacao { get; set; }
        public virtual DbSet<TbUsuarioTelevendas> TbUsuarioTelevendas { get; set; }
        public virtual DbSet<TbVitrine> TbVitrine { get; set; }
        public virtual DbSet<TbVitrineCategoria> TbVitrineCategoria { get; set; }
        public virtual DbSet<TbVitrinePraca> TbVitrinePraca { get; set; }
        public virtual DbSet<TbVitrineProdutoSku> TbVitrineProdutoSku { get; set; }
        public virtual DbSet<TbVitrineTipo> TbVitrineTipo { get; set; }
        public virtual DbSet<Vannonline> Vannonline { get; set; }
 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScLog>(entity =>
            {
                entity.ToTable("sc_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasColumnName("application")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.InsertedDate)
                    .HasColumnName("inserted_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpUser)
                    .IsRequired()
                    .HasColumnName("ip_user")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(90)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbAcesso>(entity =>
            {
                entity.HasKey(e => e.IdAcesso);

                entity.ToTable("tb_acesso");

                entity.Property(e => e.IdAcesso).HasColumnName("id_acesso");

                entity.Property(e => e.DsAcesso)
                    .IsRequired()
                    .HasColumnName("ds_acesso")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbAcessoAplicativo>(entity =>
            {
                entity.HasKey(e => e.IdAcessoAplicativo);

                entity.ToTable("tb_acesso_aplicativo");

                entity.Property(e => e.IdAcessoAplicativo).HasColumnName("id_acesso_aplicativo");

                entity.Property(e => e.IdAcesso).HasColumnName("id_acesso");

                entity.Property(e => e.IdAplicativo).HasColumnName("id_aplicativo");

                entity.HasOne(d => d.IdAplicativoNavigation)
                    .WithMany(p => p.TbAcessoAplicativo)
                    .HasForeignKey(d => d.IdAplicativo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_acesso_aplicativo_tb_aplicativo");
            });

            modelBuilder.Entity<TbAplicativo>(entity =>
            {
                entity.HasKey(e => e.IdAplicativo);

                entity.ToTable("tb_aplicativo");

                entity.Property(e => e.IdAplicativo).HasColumnName("id_aplicativo");

                entity.Property(e => e.DsAplicativo)
                    .IsRequired()
                    .HasColumnName("ds_aplicativo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlGraficoDefault)
                    .HasColumnName("fl_grafico_default")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NmAplicativo)
                    .IsRequired()
                    .HasColumnName("nm_aplicativo")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbAuditFrete>(entity =>
            {
                entity.HasKey(e => e.IdAuditFrete);

                entity.ToTable("tb_audit_frete");

                entity.Property(e => e.IdAuditFrete).HasColumnName("id_audit_frete");

                entity.Property(e => e.DsQuery)
                    .HasColumnName("ds_query")
                    .HasColumnType("text");

                entity.Property(e => e.DtOcorrencia)
                    .HasColumnName("dt_ocorrencia")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.VlFreteAnterior)
                    .HasColumnName("vl_frete_anterior")
                    .HasColumnType("money");

                entity.Property(e => e.VlFreteAtual)
                    .HasColumnName("vl_frete_atual")
                    .HasColumnType("money");

                entity.Property(e => e.VlTotalAnterior)
                    .HasColumnName("vl_total_anterior")
                    .HasColumnType("money");

                entity.Property(e => e.VlTotalAtual)
                    .HasColumnName("vl_total_atual")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TbAuditPedido>(entity =>
            {
                entity.HasKey(e => e.IdAuditPedido);

                entity.ToTable("tb_audit_pedido");

                entity.Property(e => e.IdAuditPedido).HasColumnName("id_audit_pedido");

                entity.Property(e => e.DsQuery)
                    .HasColumnName("ds_query")
                    .HasColumnType("text");

                entity.Property(e => e.DtOcorrencia)
                    .HasColumnName("dt_ocorrencia")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdModalidadeEntregaNew).HasColumnName("id_modalidade_entrega_new");

                entity.Property(e => e.IdModalidadeEntregaOld).HasColumnName("id_modalidade_entrega_old");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.IdPedidoStatusNew).HasColumnName("id_pedido_status_new");

                entity.Property(e => e.IdPedidoStatusOld).HasColumnName("id_pedido_status_old");

                entity.Property(e => e.Server)
                    .HasColumnName("server")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VlFreteAnterior)
                    .HasColumnName("vl_frete_anterior")
                    .HasColumnType("money");

                entity.Property(e => e.VlFreteAtual)
                    .HasColumnName("vl_frete_atual")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TbAutorizador>(entity =>
            {
                entity.HasKey(e => e.IdAutorizador);

                entity.ToTable("tb_autorizador");

                entity.HasIndex(e => e.CdExterno)
                    .HasName("EK_tb_autorizador")
                    .IsUnique();

                entity.Property(e => e.IdAutorizador).HasColumnName("id_autorizador");

                entity.Property(e => e.CdDescricao)
                    .HasColumnName("cd_descricao")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CdExterno).HasColumnName("cd_externo");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnName("dt_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbBackofficeSessao>(entity =>
            {
                entity.HasKey(e => e.IdSessao);

                entity.ToTable("tb_backoffice_sessao");

                entity.Property(e => e.IdSessao)
                    .HasColumnName("id_sessao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnName("dt_atualizacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TbBackofficeSessao)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_backoffice_sessao_tb_usuario");
            });

            modelBuilder.Entity<TbBanner>(entity =>
            {
                entity.HasKey(e => e.IdBanner);

                entity.ToTable("tb_banner");

                entity.Property(e => e.IdBanner).HasColumnName("id_banner");

                entity.Property(e => e.DsArquivoBanner)
                    .IsRequired()
                    .HasColumnName("ds_arquivo_banner")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsDescricao)
                    .HasColumnName("ds_descricao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsFundoHexadecimal)
                    .HasColumnName("ds_fundo_hexadecimal")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DsFundoImagem)
                    .HasColumnName("ds_fundo_imagem")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsImagemIcone)
                    .HasColumnName("ds_imagem_icone")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsLinkBanner)
                    .HasColumnName("ds_link_banner")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtFinal)
                    .HasColumnName("dt_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtInicial)
                    .HasColumnName("dt_inicial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlPadrao).HasColumnName("fl_padrao");

                entity.Property(e => e.FlStatus)
                    .HasColumnName("fl_status")
                    .HasComment("0 - Inativo / 1 - Ativo");

                entity.Property(e => e.IdBannerTarget).HasColumnName("id_banner_target");

                entity.Property(e => e.IdLayoutPosicao).HasColumnName("id_layout_posicao");

                entity.Property(e => e.NmBanner)
                    .IsRequired()
                    .HasColumnName("nm_banner")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuAlturaPopup).HasColumnName("nu_altura_popup");

                entity.Property(e => e.NuClick).HasColumnName("nu_click");

                entity.Property(e => e.NuLarguraPopup).HasColumnName("nu_largura_popup");

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdBannerTargetNavigation)
                    .WithMany(p => p.TbBanner)
                    .HasForeignKey(d => d.IdBannerTarget)
                    .HasConstraintName("FK_tb_banner_tb_banner_target");

                entity.HasOne(d => d.IdLayoutPosicaoNavigation)
                    .WithMany(p => p.TbBanner)
                    .HasForeignKey(d => d.IdLayoutPosicao)
                    .HasConstraintName("FK_tb_banner_tb_layout_posicao");
            });

            modelBuilder.Entity<TbBannerBusca>(entity =>
            {
                entity.HasKey(e => e.IdBannerBusca);

                entity.ToTable("tb_banner_busca");

                entity.Property(e => e.IdBannerBusca).HasColumnName("id_banner_busca");

                entity.Property(e => e.DsTermoBusca)
                    .IsRequired()
                    .HasColumnName("ds_termo_busca")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdBanner).HasColumnName("id_banner");

                entity.HasOne(d => d.IdBannerNavigation)
                    .WithMany(p => p.TbBannerBusca)
                    .HasForeignKey(d => d.IdBanner)
                    .HasConstraintName("FK_tb_banner_busca_tb_banner");
            });

            modelBuilder.Entity<TbBannerCategoria>(entity =>
            {
                entity.HasKey(e => e.IdBannerCategoria);

                entity.ToTable("tb_banner_categoria");

                entity.Property(e => e.IdBannerCategoria).HasColumnName("id_banner_categoria");

                entity.Property(e => e.IdBanner).HasColumnName("id_banner");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.HasOne(d => d.IdBannerNavigation)
                    .WithMany(p => p.TbBannerCategoria)
                    .HasForeignKey(d => d.IdBanner)
                    .HasConstraintName("FK_tb_banner_categoria_tb_banner");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TbBannerCategoria)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_tb_banner_categoria_tb_categoria");
            });

            modelBuilder.Entity<TbBannerPraca>(entity =>
            {
                entity.HasKey(e => e.IdBannerPraca);

                entity.ToTable("tb_banner_praca");

                entity.Property(e => e.IdBannerPraca).HasColumnName("id_banner_praca");

                entity.Property(e => e.IdBanner).HasColumnName("id_banner");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.HasOne(d => d.IdBannerNavigation)
                    .WithMany(p => p.TbBannerPraca)
                    .HasForeignKey(d => d.IdBanner)
                    .HasConstraintName("FK_tb_banner_praca_tb_banner");

                entity.HasOne(d => d.IdPracaNavigation)
                    .WithMany(p => p.TbBannerPraca)
                    .HasForeignKey(d => d.IdPraca)
                    .HasConstraintName("FK_tb_banner_praca_tb_praca");
            });

            modelBuilder.Entity<TbBannerProduto>(entity =>
            {
                entity.HasKey(e => e.IdBannerProduto);

                entity.ToTable("tb_banner_produto");

                entity.Property(e => e.IdBannerProduto).HasColumnName("id_banner_produto");

                entity.Property(e => e.IdBanner).HasColumnName("id_banner");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.HasOne(d => d.IdBannerNavigation)
                    .WithMany(p => p.TbBannerProduto)
                    .HasForeignKey(d => d.IdBanner)
                    .HasConstraintName("FK_tb_banner_produto_tb_banner");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbBannerProduto)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_banner_produto_tb_produto");
            });

            modelBuilder.Entity<TbBannerTarget>(entity =>
            {
                entity.HasKey(e => e.IdBannerTarget);

                entity.ToTable("tb_banner_target");

                entity.Property(e => e.IdBannerTarget).HasColumnName("id_banner_target");

                entity.Property(e => e.NmBannerTarget)
                    .IsRequired()
                    .HasColumnName("nm_banner_target")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBannerVitrine>(entity =>
            {
                entity.HasKey(e => e.IdBannerVitrine);

                entity.ToTable("tb_banner_vitrine");

                entity.Property(e => e.IdBannerVitrine).HasColumnName("id_banner_vitrine");

                entity.Property(e => e.IdBanner).HasColumnName("id_banner");

                entity.Property(e => e.IdVitrine).HasColumnName("id_vitrine");

                entity.HasOne(d => d.IdBannerNavigation)
                    .WithMany(p => p.TbBannerVitrine)
                    .HasForeignKey(d => d.IdBanner)
                    .HasConstraintName("FK_tb_banner_vitrine_tb_banner");

                entity.HasOne(d => d.IdVitrineNavigation)
                    .WithMany(p => p.TbBannerVitrine)
                    .HasForeignKey(d => d.IdVitrine)
                    .HasConstraintName("FK_tb_banner_vitrine_tb_vitrine");
            });

            modelBuilder.Entity<TbBusca>(entity =>
            {
                entity.HasKey(e => e.IdBusca);

                entity.ToTable("tb_busca");

                entity.Property(e => e.IdBusca).HasColumnName("id_busca");

                entity.Property(e => e.DsTermoBusca)
                    .IsRequired()
                    .HasColumnName("ds_termo_busca")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DtUltimaBusca)
                    .HasColumnName("dt_ultima_busca")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NuQtdBusca).HasColumnName("nu_qtd_busca");
            });

            modelBuilder.Entity<TbCartaoClientePbm>(entity =>
            {
                entity.HasKey(e => e.IdCartaoClientePbm);

                entity.ToTable("tb_cartao_cliente_pbm");

                entity.Property(e => e.IdCartaoClientePbm).HasColumnName("id_cartao_cliente_pbm");

                entity.Property(e => e.CpfCliente).HasColumnName("cpf_cliente");

                entity.Property(e => e.DsPrograma)
                    .HasColumnName("ds_programa")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdServico).HasColumnName("id_servico");

                entity.Property(e => e.NmCartao).HasColumnName("nm_cartao");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("tb_categoria");

                entity.HasIndex(e => new { e.CdExterno, e.IdCategoria, e.NmCategoria, e.FlStatus, e.IdCategoriaPai, e.NuOrdem })
                    .HasName("idx_categoria_filhas");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DsHexadecimal)
                    .HasColumnName("ds_hexadecimal")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DsImagemDestaque)
                    .HasColumnName("ds_imagem_destaque")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlStatus)
                    .HasColumnName("fl_status")
                    .HasComment("0 - Inativo / 1 - Ativo");

                entity.Property(e => e.IdCategoriaPai).HasColumnName("id_categoria_pai");

                entity.Property(e => e.IdCategoriaVannon).HasColumnName("id_categoria_vannon");

                entity.Property(e => e.IdProdutoSkuDestaque).HasColumnName("id_produto_sku_destaque");

                entity.Property(e => e.NmCategoria)
                    .IsRequired()
                    .HasColumnName("nm_categoria")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdProdutoSkuDestaqueNavigation)
                    .WithMany(p => p.TbCategoria)
                    .HasForeignKey(d => d.IdProdutoSkuDestaque)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_categoria_tb_produto_sku");


               entity.HasMany(d => d.SessoesNavigation)
              .WithOne(p => p.DepartamentoNavigation)
              .HasForeignKey(d => d.IdCategoriaPai)
              .OnDelete(DeleteBehavior.NoAction)
              .HasConstraintName("FK_tb_categoria_tb_categoria");
            });

            modelBuilder.Entity<TbCategoriaSeo>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaSeo);

                entity.ToTable("tb_categoria_seo");

                entity.Property(e => e.IdCategoriaSeo).HasColumnName("id_categoria_seo");

                entity.Property(e => e.DsDescription)
                    .HasColumnName("ds_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsKeywords)
                    .HasColumnName("ds_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsTitle)
                    .HasColumnName("ds_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TbCategoriaSeo)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_tb_categoria_seo_tb_categoria");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("tb_cliente");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsApelido)
                    .HasColumnName("ds_apelido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsCelular)
                    .HasColumnName("ds_celular")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DsCelularDdd)
                    .HasColumnName("ds_celular_ddd")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsCpfCnpj)
                    .IsRequired()
                    .HasColumnName("ds_cpf_cnpj")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsInscricaoEstadual)
                    .HasColumnName("ds_inscricao_estadual")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsRazaoSocial)
                    .HasColumnName("ds_razao_social")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsResponsavel)
                    .HasColumnName("ds_responsavel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsRg)
                    .HasColumnName("ds_rg")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DsSenha)
                    .HasColumnName("ds_senha")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsSobrenome)
                    .HasColumnName("ds_sobrenome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsTelefone)
                    .HasColumnName("ds_telefone")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DsTelefoneDdd)
                    .HasColumnName("ds_telefone_ddd")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtMarketingImp)
                    .HasColumnName("dt_marketing_imp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlAceitaMailing).HasColumnName("fl_aceita_mailing");

                entity.Property(e => e.FlAceitaSms).HasColumnName("fl_aceita_sms");

                entity.Property(e => e.FlIeIsento)
                    .HasColumnName("fl_ie_isento")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FlIntegracao)
                    .HasColumnName("fl_integracao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlMarketing).HasColumnName("fl_marketing");

                entity.Property(e => e.FlNovo).HasColumnName("fl_novo");

                entity.Property(e => e.FlSexo)
                    .HasColumnName("fl_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("F - Feminino / M - Masculino");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.FlTipoPessoa)
                    .IsRequired()
                    .HasColumnName("fl_tipo_pessoa")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("0 - Pessoa Física / 1 - Pessoa Juridica");

                entity.Property(e => e.NmCliente)
                    .IsRequired()
                    .HasColumnName("nm_cliente")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSocial)
                    .HasColumnName("nome_social")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Para SAP Marketing Apenas");
            });

            modelBuilder.Entity<TbClienteEndereco>(entity =>
            {
                entity.HasKey(e => e.IdClienteEndereco);

                entity.ToTable("tb_cliente_endereco");

                entity.HasIndex(e => new { e.IdCliente, e.FlEnderecoCadastro })
                    .HasName("idx_cliente_endereco");

                entity.Property(e => e.IdClienteEndereco).HasColumnName("id_cliente_endereco");

                entity.Property(e => e.DsBairro)
                    .IsRequired()
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsCep)
                    .IsRequired()
                    .HasColumnName("ds_cep")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsCidade)
                    .IsRequired()
                    .HasColumnName("ds_cidade")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DsComplemento)
                    .HasColumnName("ds_complemento")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DsDestinatario)
                    .HasColumnName("ds_destinatario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsEndereco)
                    .IsRequired()
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsEstado)
                    .IsRequired()
                    .HasColumnName("ds_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsReferencia)
                    .HasColumnName("ds_referencia")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FlEnderecoCadastro).HasColumnName("fl_endereco_cadastro");

                entity.Property(e => e.FlRemovido).HasColumnName("fl_removido");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdClienteEnderecoTipo).HasColumnName("id_cliente_endereco_tipo");

                entity.Property(e => e.NuEndereco)
                    .IsRequired()
                    .HasColumnName("nu_endereco")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbClienteEndereco)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_tb_cliente_endereco_tb_cliente");

                entity.HasOne(d => d.IdClienteEnderecoTipoNavigation)
                    .WithMany(p => p.TbClienteEndereco)
                    .HasForeignKey(d => d.IdClienteEnderecoTipo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cliente_endereco_tb_cliente_endereco_tipo");
            });

            modelBuilder.Entity<TbClienteEnderecoTipo>(entity =>
            {
                entity.HasKey(e => e.IdClienteEnderecoTipo);

                entity.ToTable("tb_cliente_endereco_tipo");

                entity.Property(e => e.IdClienteEnderecoTipo).HasColumnName("id_cliente_endereco_tipo");

                entity.Property(e => e.NmClienteEnderecoTipo)
                    .IsRequired()
                    .HasColumnName("nm_cliente_endereco_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbClienteObservacao>(entity =>
            {
                entity.HasKey(e => e.IdClienteObservacao);

                entity.ToTable("tb_cliente_observacao");

                entity.Property(e => e.IdClienteObservacao).HasColumnName("id_cliente_observacao");

                entity.Property(e => e.DsObservacao)
                    .IsRequired()
                    .HasColumnName("ds_observacao")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbClienteObservacao)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_tb_cliente_observacao_tb_cliente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TbClienteObservacao)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_tb_cliente_observacao_tb_usuario");
            });

            modelBuilder.Entity<TbClienteToken>(entity =>
            {
                entity.HasKey(e => e.IdClienteToken)
                    .HasName("PK__tb_clien__8E60392D78765AAD");

                entity.ToTable("tb_cliente_token");

                entity.Property(e => e.IdClienteToken).HasColumnName("id_cliente_token");

                entity.Property(e => e.DsToken)
                    .HasColumnName("ds_token")
                    .IsUnicode(false);

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlExpirado)
                    .HasColumnName("fl_expirado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FlSenha).HasColumnName("fl_senha");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            });

            modelBuilder.Entity<TbConexao>(entity =>
            {
                entity.HasKey(e => e.IdConexao);

                entity.ToTable("tb_conexao");

                entity.Property(e => e.IdConexao).HasColumnName("id_conexao");

                entity.Property(e => e.DsConexao)
                    .IsRequired()
                    .HasColumnName("ds_conexao")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NmConexao)
                    .IsRequired()
                    .HasColumnName("nm_conexao")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbConexaoPraca>(entity =>
            {
                entity.HasKey(e => e.IdConexaoPraca);

                entity.ToTable("tb_conexao_praca");

                entity.Property(e => e.IdConexaoPraca).HasColumnName("id_conexao_praca");

                entity.Property(e => e.IdConexao).HasColumnName("id_conexao");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");
            });

            modelBuilder.Entity<TbConteudo>(entity =>
            {
                entity.HasKey(e => e.IdConteudo);

                entity.ToTable("tb_conteudo");

                entity.Property(e => e.IdConteudo).HasColumnName("id_conteudo");

                entity.Property(e => e.DsImagem)
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUrlConteudo)
                    .IsRequired()
                    .HasColumnName("ds_url_conteudo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlExibeCentralAtendimento)
                    .IsRequired()
                    .HasColumnName("fl_exibe_central_atendimento")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdConteudoCategoria).HasColumnName("id_conteudo_categoria");

                entity.Property(e => e.IdConteudoLocal).HasColumnName("id_conteudo_local");

                entity.Property(e => e.IdConteudoTarget)
                    .HasColumnName("id_conteudo_target")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdConteudoTipo).HasColumnName("id_conteudo_tipo");

                entity.Property(e => e.NmConteudo)
                    .IsRequired()
                    .HasColumnName("nm_conteudo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuAlturaPopup).HasColumnName("nu_altura_popup");

                entity.Property(e => e.NuLarguraPopup).HasColumnName("nu_largura_popup");

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.Property(e => e.TxConteudoHtml)
                    .HasColumnName("tx_conteudo_html")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdConteudoCategoriaNavigation)
                    .WithMany(p => p.TbConteudo)
                    .HasForeignKey(d => d.IdConteudoCategoria)
                    .HasConstraintName("FK_tb_conteudo_tb_conteudo_categoria");

                entity.HasOne(d => d.IdConteudoTargetNavigation)
                    .WithMany(p => p.TbConteudo)
                    .HasForeignKey(d => d.IdConteudoTarget)
                    .HasConstraintName("FK_tb_conteudo_tb_conteudo_target");

                entity.HasOne(d => d.IdConteudoTipoNavigation)
                    .WithMany(p => p.TbConteudo)
                    .HasForeignKey(d => d.IdConteudoTipo)
                    .HasConstraintName("FK_tb_conteudo_tb_conteudo_tipo");
            });

            modelBuilder.Entity<TbConteudoCategoria>(entity =>
            {
                entity.HasKey(e => e.IdConteudoCategoria);

                entity.ToTable("tb_conteudo_categoria");

                entity.Property(e => e.IdConteudoCategoria).HasColumnName("id_conteudo_categoria");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.NmConteudoCategoria)
                    .IsRequired()
                    .HasColumnName("nm_conteudo_categoria")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");
            });

            modelBuilder.Entity<TbConteudoConteudoLocal>(entity =>
            {
                entity.HasKey(e => e.IdConteudoConteudoLocal);

                entity.ToTable("tb_conteudo_conteudo_local");

                entity.Property(e => e.IdConteudoConteudoLocal).HasColumnName("id_conteudo_conteudo_local");

                entity.Property(e => e.IdConteudo).HasColumnName("id_conteudo");

                entity.Property(e => e.IdConteudoLocal).HasColumnName("id_conteudo_local");

                entity.HasOne(d => d.IdConteudoNavigation)
                    .WithMany(p => p.TbConteudoConteudoLocal)
                    .HasForeignKey(d => d.IdConteudo)
                    .HasConstraintName("FK_tb_conteudo_conteudo_local_tb_conteudo");

                entity.HasOne(d => d.IdConteudoLocalNavigation)
                    .WithMany(p => p.TbConteudoConteudoLocal)
                    .HasForeignKey(d => d.IdConteudoLocal)
                    .HasConstraintName("FK_tb_conteudo_conteudo_local_tb_conteudo_local");
            });

            modelBuilder.Entity<TbConteudoLocal>(entity =>
            {
                entity.HasKey(e => e.IdConteudoLocal);

                entity.ToTable("tb_conteudo_local");

                entity.Property(e => e.IdConteudoLocal).HasColumnName("id_conteudo_local");

                entity.Property(e => e.NmConteudoLocal)
                    .IsRequired()
                    .HasColumnName("nm_conteudo_local")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbConteudoSeo>(entity =>
            {
                entity.HasKey(e => e.IdConteudoSeo);

                entity.ToTable("tb_conteudo_seo");

                entity.Property(e => e.IdConteudoSeo).HasColumnName("id_conteudo_seo");

                entity.Property(e => e.DsDescription)
                    .HasColumnName("ds_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsKeywords)
                    .HasColumnName("ds_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsTitle)
                    .HasColumnName("ds_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdConteudo).HasColumnName("id_conteudo");

                entity.HasOne(d => d.IdConteudoNavigation)
                    .WithMany(p => p.TbConteudoSeo)
                    .HasForeignKey(d => d.IdConteudo)
                    .HasConstraintName("FK_tb_conteudo_seo_tb_conteudo");
            });

            modelBuilder.Entity<TbConteudoTarget>(entity =>
            {
                entity.HasKey(e => e.IdConteudoTarget);

                entity.ToTable("tb_conteudo_target");

                entity.Property(e => e.IdConteudoTarget).HasColumnName("id_conteudo_target");

                entity.Property(e => e.NmConteudoTarget)
                    .IsRequired()
                    .HasColumnName("nm_conteudo_target")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbConteudoTipo>(entity =>
            {
                entity.HasKey(e => e.IdConteudoTipo);

                entity.ToTable("tb_conteudo_tipo");

                entity.Property(e => e.IdConteudoTipo).HasColumnName("id_conteudo_tipo");

                entity.Property(e => e.NmConteudoTipo)
                    .IsRequired()
                    .HasColumnName("nm_conteudo_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbDadosLoja>(entity =>
            {
                entity.HasKey(e => e.IdDadosLoja);

                entity.ToTable("tb_dados_loja");

                entity.Property(e => e.IdDadosLoja).HasColumnName("id_dados_loja");

                entity.Property(e => e.CdGoogleAnalytics)
                    .HasColumnName("cd_google_analytics")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DsArquivoLogo)
                    .HasColumnName("ds_arquivo_logo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsBairro)
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsCelular)
                    .HasColumnName("ds_celular")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DsCep)
                    .HasColumnName("ds_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DsCidade)
                    .HasColumnName("ds_cidade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsClearSaleEntityCode)
                    .HasColumnName("ds_clear_sale_entity_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsCnpjCpf)
                    .HasColumnName("ds_cnpj_cpf")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsComplemento)
                    .HasColumnName("ds_complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsCopyright)
                    .HasColumnName("ds_copyright")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsCriptografiaSmtp)
                    .HasColumnName("ds_criptografia_smtp")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DsDominio)
                    .HasColumnName("ds_dominio")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmailContato)
                    .HasColumnName("ds_email_contato")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsEndereco)
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsEstado)
                    .HasColumnName("ds_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsHorarioAtendimento)
                    .HasColumnName("ds_horario_atendimento")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsLoginSmtp)
                    .HasColumnName("ds_login_smtp")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsNumero)
                    .HasColumnName("ds_numero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsRoiHero)
                    .HasColumnName("ds_roi_hero")
                    .IsUnicode(false);

                entity.Property(e => e.DsSenhaSmtp)
                    .HasColumnName("ds_senha_smtp")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsSeoDescription)
                    .HasColumnName("ds_seo_description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DsSeoKeywords)
                    .HasColumnName("ds_seo_keywords")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DsSmtp)
                    .HasColumnName("ds_smtp")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DsTelefone)
                    .HasColumnName("ds_telefone")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DsTelefoneAtendimento)
                    .HasColumnName("ds_telefone_atendimento")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.DsTitulo)
                    .HasColumnName("ds_titulo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsToken)
                    .HasColumnName("ds_token")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DsUrlLoja)
                    .HasColumnName("ds_url_loja")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlAutocomplete).HasColumnName("fl_autocomplete");

                entity.Property(e => e.FlFarmacia).HasColumnName("fl_farmacia");

                entity.Property(e => e.FlTipoPessoa)
                    .HasColumnName("fl_tipo_pessoa")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NmCliente)
                    .HasColumnName("nm_cliente")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmContato)
                    .HasColumnName("nm_contato")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NuAlturaAmpliada).HasColumnName("nu_altura_ampliada");

                entity.Property(e => e.NuAlturaCarrossel).HasColumnName("nu_altura_carrossel");

                entity.Property(e => e.NuAlturaMini).HasColumnName("nu_altura_mini");

                entity.Property(e => e.NuAlturaNormal).HasColumnName("nu_altura_normal");

                entity.Property(e => e.NuAlturaSuper).HasColumnName("nu_altura_super");

                entity.Property(e => e.NuAlturaVariacao).HasColumnName("nu_altura_variacao");

                entity.Property(e => e.NuLarguraAmpliada).HasColumnName("nu_largura_ampliada");

                entity.Property(e => e.NuLarguraCarrossel).HasColumnName("nu_largura_carrossel");

                entity.Property(e => e.NuLarguraMini).HasColumnName("nu_largura_mini");

                entity.Property(e => e.NuLarguraNormal).HasColumnName("nu_largura_normal");

                entity.Property(e => e.NuLarguraSuper).HasColumnName("nu_largura_super");

                entity.Property(e => e.NuLarguraVariacao).HasColumnName("nu_largura_variacao");

                entity.Property(e => e.NuPorta).HasColumnName("nu_porta");

                entity.Property(e => e.VlMaximo)
                    .HasColumnName("vl_maximo")
                    .HasColumnType("money");

                entity.Property(e => e.VlMinimo)
                    .HasColumnName("vl_minimo")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TbDeparaClientesVfarma>(entity =>
            {
                entity.HasKey(e => e.IdDeparaClientesVfarma);

                entity.ToTable("tb_depara_clientes_vfarma");

                entity.Property(e => e.IdDeparaClientesVfarma).HasColumnName("id_depara_clientes_vfarma");

                entity.Property(e => e.DsDe)
                    .HasColumnName("ds_de")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdConexao).HasColumnName("id_conexao");

                entity.Property(e => e.IdDe).HasColumnName("id_de");

                entity.Property(e => e.IdPara).HasColumnName("id_para");

                entity.Property(e => e.NmTabela)
                    .IsRequired()
                    .HasColumnName("nm_tabela")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbDeparaFmp>(entity =>
            {
                entity.HasKey(e => e.IdDepara);

                entity.ToTable("tb_depara_fmp");

                entity.Property(e => e.IdDepara).HasColumnName("id_depara");

                entity.Property(e => e.IdConexao).HasColumnName("id_conexao");

                entity.Property(e => e.IdDe).HasColumnName("id_de");

                entity.Property(e => e.IdPara).HasColumnName("id_para");

                entity.Property(e => e.NmTabela)
                    .IsRequired()
                    .HasColumnName("nm_tabela")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbDiaSemana>(entity =>
            {
                entity.HasKey(e => e.IdDiaSemana);

                entity.ToTable("tb_dia_semana");

                entity.Property(e => e.IdDiaSemana).HasColumnName("id_dia_semana");

                entity.Property(e => e.DsDiaSemana)
                    .IsRequired()
                    .HasColumnName("ds_dia_semana")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbEanListaTmp>(entity =>
            {
                entity.ToTable("tb_ean_lista_tmp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ean)
                    .HasColumnName("EAN")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbEbit>(entity =>
            {
                entity.HasKey(e => e.IdEbit);

                entity.ToTable("tb_ebit");

                entity.Property(e => e.IdEbit).HasColumnName("id_ebit");

                entity.Property(e => e.CdBuscape)
                    .HasColumnName("cd_buscape")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdEbit)
                    .HasColumnName("cd_ebit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlAtivo).HasColumnName("fl_ativo");
            });

            modelBuilder.Entity<TbEmail>(entity =>
            {
                entity.HasKey(e => e.IdEmail);

                entity.ToTable("tb_email");

                entity.Property(e => e.IdEmail).HasColumnName("id_email");

                entity.Property(e => e.DsAssunto)
                    .IsRequired()
                    .HasColumnName("ds_assunto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmailRemetente)
                    .IsRequired()
                    .HasColumnName("ds_email_remetente")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdEmailTipo).HasColumnName("id_email_tipo");

                entity.Property(e => e.IdPedidoStatus).HasColumnName("id_pedido_status");

                entity.Property(e => e.NmRemetente)
                    .IsRequired()
                    .HasColumnName("nm_remetente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxConteudo)
                    .IsRequired()
                    .HasColumnName("tx_conteudo")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdEmailTipoNavigation)
                    .WithMany(p => p.TbEmail)
                    .HasForeignKey(d => d.IdEmailTipo)
                    .HasConstraintName("FK_tb_email_tb_email_tipo");

                entity.HasOne(d => d.IdPedidoStatusNavigation)
                    .WithMany(p => p.TbEmail)
                    .HasForeignKey(d => d.IdPedidoStatus)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_email_tb_pedido_status");
            });

            modelBuilder.Entity<TbEmailTag>(entity =>
            {
                entity.HasKey(e => e.IdTag)
                    .HasName("PK_tb_tag");

                entity.ToTable("tb_email_tag");

                entity.Property(e => e.IdTag).HasColumnName("id_tag");

                entity.Property(e => e.DsTag)
                    .IsRequired()
                    .HasColumnName("ds_tag")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NmTag)
                    .IsRequired()
                    .HasColumnName("nm_tag")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbEmailTipo>(entity =>
            {
                entity.HasKey(e => e.IdEmailTipo);

                entity.ToTable("tb_email_tipo");

                entity.Property(e => e.IdEmailTipo).HasColumnName("id_email_tipo");

                entity.Property(e => e.DsEmailTipo)
                    .IsRequired()
                    .HasColumnName("ds_email_tipo")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbEspecificacao>(entity =>
            {
                entity.HasKey(e => e.IdEspecificacao);

                entity.ToTable("tb_especificacao");

                entity.Property(e => e.IdEspecificacao).HasColumnName("id_especificacao");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DsHexadecimal)
                    .HasColumnName("ds_hexadecimal")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsImagem)
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdEspecificacaoTipo).HasColumnName("id_especificacao_tipo");

                entity.Property(e => e.NmEspecificacao)
                    .IsRequired()
                    .HasColumnName("nm_especificacao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdEspecificacaoTipoNavigation)
                    .WithMany(p => p.TbEspecificacao)
                    .HasForeignKey(d => d.IdEspecificacaoTipo)
                    .HasConstraintName("FK_tb_especificacao_tb_especificacao_tipo");
            });

            modelBuilder.Entity<TbEspecificacaoTipo>(entity =>
            {
                entity.HasKey(e => e.IdEspecificacaoTipo);

                entity.ToTable("tb_especificacao_tipo");

                entity.Property(e => e.IdEspecificacaoTipo).HasColumnName("id_especificacao_tipo");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NmEspecificacaoTipo)
                    .IsRequired()
                    .HasColumnName("nm_especificacao_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbEtiqueta>(entity =>
            {
                entity.HasKey(e => e.IdEtiqueta);

                entity.ToTable("tb_etiqueta");

                entity.Property(e => e.IdEtiqueta).HasColumnName("id_etiqueta");

                entity.Property(e => e.DsImagem)
                    .IsRequired()
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlStatus)
                    .HasColumnName("fl_status")
                    .HasComment("0 - Inativo / 1 - Ativo");

                entity.Property(e => e.IdEtiquetaTipo).HasColumnName("id_etiqueta_tipo");

                entity.Property(e => e.NmEtiqueta)
                    .IsRequired()
                    .HasColumnName("nm_etiqueta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEtiquetaTipoNavigation)
                    .WithMany(p => p.TbEtiqueta)
                    .HasForeignKey(d => d.IdEtiquetaTipo)
                    .HasConstraintName("FK_tb_etiqueta_tb_etiqueta_tipo");
            });

            modelBuilder.Entity<TbEtiquetaTipo>(entity =>
            {
                entity.HasKey(e => e.IdEtiquetaTipo);

                entity.ToTable("tb_etiqueta_tipo");

                entity.Property(e => e.IdEtiquetaTipo).HasColumnName("id_etiqueta_tipo");

                entity.Property(e => e.NmEtiquetaTipo)
                    .IsRequired()
                    .HasColumnName("nm_etiqueta_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbFaq>(entity =>
            {
                entity.HasKey(e => e.IdFaq);

                entity.ToTable("tb_faq");

                entity.Property(e => e.IdFaq).HasColumnName("id_faq");

                entity.Property(e => e.DsPergunta)
                    .IsRequired()
                    .HasColumnName("ds_pergunta")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdFaqCategoria).HasColumnName("id_faq_categoria");

                entity.Property(e => e.TxResposta)
                    .IsRequired()
                    .HasColumnName("tx_resposta")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdFaqCategoriaNavigation)
                    .WithMany(p => p.TbFaq)
                    .HasForeignKey(d => d.IdFaqCategoria)
                    .HasConstraintName("FK_tb_faq_tb_faq_categoria");
            });

            modelBuilder.Entity<TbFaqCategoria>(entity =>
            {
                entity.HasKey(e => e.IdFaqCategoria);

                entity.ToTable("tb_faq_categoria");

                entity.Property(e => e.IdFaqCategoria).HasColumnName("id_faq_categoria");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.NmFaqCategoria)
                    .IsRequired()
                    .HasColumnName("nm_faq_categoria")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbFiltro>(entity =>
            {
                entity.HasKey(e => e.IdFiltro);

                entity.ToTable("tb_filtro");

                entity.Property(e => e.IdFiltro).HasColumnName("id_filtro");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlExibeCategoria).HasColumnName("fl_exibe_categoria");

                entity.Property(e => e.FlExibeProduto).HasColumnName("fl_exibe_produto");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdFiltroTipo).HasColumnName("id_filtro_tipo");

                entity.Property(e => e.NmFiltro)
                    .IsRequired()
                    .HasColumnName("nm_filtro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdFiltroTipoNavigation)
                    .WithMany(p => p.TbFiltro)
                    .HasForeignKey(d => d.IdFiltroTipo)
                    .HasConstraintName("FK_tb_filtro_tb_filtro_tipo");
            });

            modelBuilder.Entity<TbFiltroTipo>(entity =>
            {
                entity.HasKey(e => e.IdFiltroTipo);

                entity.ToTable("tb_filtro_tipo");

                entity.Property(e => e.IdFiltroTipo).HasColumnName("id_filtro_tipo");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.NmFiltroTipo)
                    .IsRequired()
                    .HasColumnName("nm_filtro_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbFiltroTipoCategoria>(entity =>
            {
                entity.HasKey(e => e.IdFiltroTipoCategoria);

                entity.ToTable("tb_filtro_tipo_categoria");

                entity.Property(e => e.IdFiltroTipoCategoria).HasColumnName("id_filtro_tipo_categoria");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");

                entity.Property(e => e.IdFiltroTipo).HasColumnName("id_filtro_tipo");

                entity.Property(e => e.IdSecao).HasColumnName("id_secao");

                entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");

                entity.HasOne(d => d.IdFiltroTipoNavigation)
                    .WithMany(p => p.TbFiltroTipoCategoria)
                    .HasForeignKey(d => d.IdFiltroTipo)
                    .HasConstraintName("FK_tb_filtro_tipo_categoria_tb_filtro_tipo");
            });

            modelBuilder.Entity<TbFormaPagamento>(entity =>
            {
                entity.HasKey(e => e.IdFormaPagamento);

                entity.ToTable("tb_forma_pagamento");

                entity.Property(e => e.IdFormaPagamento)
                    .HasColumnName("id_forma_pagamento")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsLogo)
                    .HasColumnName("ds_logo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdFormaPagamentoTipo).HasColumnName("id_forma_pagamento_tipo");

                entity.Property(e => e.NmFormaPagamento)
                    .IsRequired()
                    .HasColumnName("nm_forma_pagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFormaPagamentoTipoNavigation)
                    .WithMany(p => p.TbFormaPagamento)
                    .HasForeignKey(d => d.IdFormaPagamentoTipo)
                    .HasConstraintName("FK_tb_forma_pagamento_tb_forma_pagamento_tipo");
            });

            modelBuilder.Entity<TbFormaPagamentoTipo>(entity =>
            {
                entity.HasKey(e => e.IdFormaPagamentoTipo);

                entity.ToTable("tb_forma_pagamento_tipo");

                entity.Property(e => e.IdFormaPagamentoTipo).HasColumnName("id_forma_pagamento_tipo");

                entity.Property(e => e.NmFormaPagamentoTipo)
                    .IsRequired()
                    .HasColumnName("nm_forma_pagamento_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbGateway>(entity =>
            {
                entity.HasKey(e => e.IdGateway);

                entity.ToTable("tb_gateway");

                entity.Property(e => e.IdGateway).HasColumnName("id_gateway");

                entity.Property(e => e.DsMerchantId)
                    .HasColumnName("ds_merchant_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsMerchantKey)
                    .HasColumnName("ds_merchant_key")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsNome)
                    .IsRequired()
                    .HasColumnName("ds_nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlClearsale).HasColumnName("fl_clearsale");

                entity.Property(e => e.FlProducao).HasColumnName("fl_producao");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdGatewayTipo).HasColumnName("id_gateway_tipo");

                entity.HasOne(d => d.IdGatewayTipoNavigation)
                    .WithMany(p => p.TbGateway)
                    .HasForeignKey(d => d.IdGatewayTipo)
                    .HasConstraintName("FK_tb_gateway_tb_gateway_tipo");
            });

            modelBuilder.Entity<TbGatewayPraca>(entity =>
            {
                entity.HasKey(e => e.IdGatewayPraca);

                entity.ToTable("tb_gateway_praca");

                entity.Property(e => e.IdGatewayPraca).HasColumnName("id_gateway_praca");

                entity.Property(e => e.IdGateway).HasColumnName("id_gateway");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.HasOne(d => d.IdGatewayNavigation)
                    .WithMany(p => p.TbGatewayPraca)
                    .HasForeignKey(d => d.IdGateway)
                    .HasConstraintName("FK_tb_gateway_praca_tb_gateway");

                entity.HasOne(d => d.IdPracaNavigation)
                    .WithMany(p => p.TbGatewayPraca)
                    .HasForeignKey(d => d.IdPraca)
                    .HasConstraintName("FK_tb_gateway_praca_tb_praca");
            });

            modelBuilder.Entity<TbGatewayTipo>(entity =>
            {
                entity.HasKey(e => e.IdGatewayTipo);

                entity.ToTable("tb_gateway_tipo");

                entity.Property(e => e.IdGatewayTipo)
                    .HasColumnName("id_gateway_tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsGatewayTipo)
                    .HasColumnName("ds_gateway_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbGatewayTipoFormaPagamento>(entity =>
            {
                entity.HasKey(e => e.IdGatewayTipoFormaPagamento);

                entity.ToTable("tb_gateway_tipo_forma_pagamento");

                entity.HasIndex(e => e.IdGatewayTipoFormaPagamento)
                    .HasName("IX_tb_gateway_tipo_forma_pagamento");

                entity.Property(e => e.IdGatewayTipoFormaPagamento).HasColumnName("id_gateway_tipo_forma_pagamento");

                entity.Property(e => e.IdFormaPagamento).HasColumnName("id_forma_pagamento");

                entity.Property(e => e.IdGatewayTipo).HasColumnName("id_gateway_tipo");

                entity.HasOne(d => d.IdFormaPagamentoNavigation)
                    .WithMany(p => p.TbGatewayTipoFormaPagamento)
                    .HasForeignKey(d => d.IdFormaPagamento)
                    .HasConstraintName("FK_tb_gateway_tipo_forma_pagamento_tb_forma_pagamento");

                entity.HasOne(d => d.IdGatewayTipoNavigation)
                    .WithMany(p => p.TbGatewayTipoFormaPagamento)
                    .HasForeignKey(d => d.IdGatewayTipo)
                    .HasConstraintName("FK_tb_gateway_tipo_forma_pagamento_tb_gateway_tipo");
            });

            modelBuilder.Entity<TbGondola>(entity =>
            {
                entity.HasKey(e => e.IdGondola);

                entity.ToTable("tb_gondola");

                entity.Property(e => e.IdGondola).HasColumnName("id_gondola");

                entity.Property(e => e.DsExibicao)
                    .HasColumnName("ds_exibicao")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DtFinal)
                    .HasColumnName("dt_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtInicial)
                    .HasColumnName("dt_inicial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.NmGondola)
                    .IsRequired()
                    .HasColumnName("nm_gondola")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbGondolaProdutoSku>(entity =>
            {
                entity.HasKey(e => e.IdGondolaProdutoSku);

                entity.ToTable("tb_gondola_produto_sku");

                entity.Property(e => e.IdGondolaProdutoSku).HasColumnName("id_gondola_produto_sku");

                entity.Property(e => e.IdGondola).HasColumnName("id_gondola");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbGondolaProdutoSku)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_gondola_produto_sku_tb_produto_sku");
            });

            modelBuilder.Entity<TbGraficoCockpit>(entity =>
            {
                entity.HasKey(e => e.IdGraficoCockpit);

                entity.ToTable("tb_grafico_cockpit");

                entity.Property(e => e.IdGraficoCockpit).HasColumnName("id_grafico_cockpit");

                entity.Property(e => e.IdAplicativo).HasColumnName("id_aplicativo");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdAplicativoNavigation)
                    .WithMany(p => p.TbGraficoCockpit)
                    .HasForeignKey(d => d.IdAplicativo)
                    .HasConstraintName("FK_tb_grafico_cockpit_tb_aplicativo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TbGraficoCockpit)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_tb_grafico_cockpit_tb_usuario");
            });

            modelBuilder.Entity<TbImpAtualizaEstoquePreco>(entity =>
            {
                entity.HasKey(e => e.IdImportacao);

                entity.ToTable("tb_imp_atualiza_estoque_preco");

                entity.Property(e => e.IdImportacao).HasColumnName("id_importacao");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsMensagem)
                    .IsRequired()
                    .HasColumnName("ds_mensagem")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtImportacao)
                    .HasColumnName("dt_importacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.NuEstoque).HasColumnName("nu_estoque");

                entity.Property(e => e.VlProdutoDe)
                    .HasColumnName("vl_produto_de")
                    .HasColumnType("money");

                entity.Property(e => e.VlProdutoPor)
                    .HasColumnName("vl_produto_por")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TbImpAtualizaTitleMeta>(entity =>
            {
                entity.ToTable("tb_imp_atualiza_title_meta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnName("data_atualizacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsDescription)
                    .HasColumnName("ds_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsKeywords)
                    .HasColumnName("ds_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsMensagem)
                    .HasColumnName("ds_mensagem")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsTitle)
                    .HasColumnName("ds_title")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbLayout>(entity =>
            {
                entity.HasKey(e => e.IdLayout);

                entity.ToTable("tb_layout");

                entity.Property(e => e.IdLayout).HasColumnName("id_layout");

                entity.Property(e => e.DsImagem)
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NmLayout)
                    .IsRequired()
                    .HasColumnName("nm_layout")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbLayoutPosicao>(entity =>
            {
                entity.HasKey(e => e.IdLayoutPosicao);

                entity.ToTable("tb_layout_posicao");

                entity.Property(e => e.IdLayoutPosicao).HasColumnName("id_layout_posicao");

                entity.Property(e => e.IdLayout).HasColumnName("id_layout");

                entity.Property(e => e.IdPosicao).HasColumnName("id_posicao");

                entity.Property(e => e.NuAltura).HasColumnName("nu_altura");

                entity.Property(e => e.NuLargura).HasColumnName("nu_largura");

                entity.HasOne(d => d.IdLayoutNavigation)
                    .WithMany(p => p.TbLayoutPosicao)
                    .HasForeignKey(d => d.IdLayout)
                    .HasConstraintName("FK_tb_layout_posicao_tb_layout");

                entity.HasOne(d => d.IdPosicaoNavigation)
                    .WithMany(p => p.TbLayoutPosicao)
                    .HasForeignKey(d => d.IdPosicao)
                    .HasConstraintName("FK_tb_layout_posicao_tb_posicao");
            });

            modelBuilder.Entity<TbListaDesejo>(entity =>
            {
                entity.HasKey(e => e.IdListaDesejo);

                entity.ToTable("tb_lista_desejo");

                entity.Property(e => e.IdListaDesejo).HasColumnName("id_lista_desejo");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdListaDesejoPeriodo).HasColumnName("id_lista_desejo_periodo");

                entity.Property(e => e.NmListaDesejo)
                    .IsRequired()
                    .HasColumnName("nm_lista_desejo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbListaDesejo)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_tb_lista_desejo_tb_cliente");

                entity.HasOne(d => d.IdListaDesejoPeriodoNavigation)
                    .WithMany(p => p.TbListaDesejo)
                    .HasForeignKey(d => d.IdListaDesejoPeriodo)
                    .HasConstraintName("FK_tb_lista_desejo_tb_lista_desejo_periodo");
            });

            modelBuilder.Entity<TbListaDesejoPeriodo>(entity =>
            {
                entity.HasKey(e => e.IdListaDesejoPeriodo);

                entity.ToTable("tb_lista_desejo_periodo");

                entity.Property(e => e.IdListaDesejoPeriodo).HasColumnName("id_lista_desejo_periodo");

                entity.Property(e => e.DsListaDesejoPeriodo)
                    .IsRequired()
                    .HasColumnName("ds_lista_desejo_periodo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.NuPeriodo).HasColumnName("nu_periodo");
            });

            modelBuilder.Entity<TbListaDesejoProdutoSku>(entity =>
            {
                entity.HasKey(e => e.IdListaDesejoProdutoSku);

                entity.ToTable("tb_lista_desejo_produto_sku");

                entity.Property(e => e.IdListaDesejoProdutoSku).HasColumnName("id_lista_desejo_produto_sku");

                entity.Property(e => e.IdListaDesejo).HasColumnName("id_lista_desejo");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.HasOne(d => d.IdListaDesejoNavigation)
                    .WithMany(p => p.TbListaDesejoProdutoSku)
                    .HasForeignKey(d => d.IdListaDesejo)
                    .HasConstraintName("FK_tb_lista_desejo_produto_sku_tb_lista_desejo");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbListaDesejoProdutoSku)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_lista_desejo_produto_sku_tb_produto_sku");
            });

            modelBuilder.Entity<TbLog>(entity =>
            {
                entity.ToTable("tb_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasColumnName("application")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.InsertedDate)
                    .HasColumnName("inserted_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpUser)
                    .IsRequired()
                    .HasColumnName("ip_user")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(90)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbLogProcedure>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("tb_log_procedure");

                entity.Property(e => e.IdLog).HasColumnName("id_log");

                entity.Property(e => e.DsLog)
                    .HasColumnName("ds_log")
                    .IsUnicode(false);

                entity.Property(e => e.DtLog)
                    .HasColumnName("dt_log")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbLogTelevendas>(entity =>
            {
                entity.HasKey(e => e.IdLogTelevendas);

                entity.ToTable("tb_log_televendas");

                entity.Property(e => e.IdLogTelevendas).HasColumnName("id_log_televendas");

                entity.Property(e => e.DsAcao)
                    .IsRequired()
                    .HasColumnName("ds_acao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdUsuarioTelevendas).HasColumnName("id_usuario_televendas");

                entity.HasOne(d => d.IdUsuarioTelevendasNavigation)
                    .WithMany(p => p.TbLogTelevendas)
                    .HasForeignKey(d => d.IdUsuarioTelevendas)
                    .HasConstraintName("FK_tb_log_televendas_tb_usuario_televedas");
            });

            modelBuilder.Entity<TbLojaEspecial>(entity =>
            {
                entity.HasKey(e => e.IdLojaEspecial);

                entity.ToTable("tb_loja_especial");

                entity.Property(e => e.IdLojaEspecial).HasColumnName("id_loja_especial");

                entity.Property(e => e.DsArquivoLogo)
                    .HasColumnName("ds_arquivo_logo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsCor1)
                    .HasColumnName("ds_cor_1")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsCor2)
                    .HasColumnName("ds_cor_2")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsCorFundo)
                    .HasColumnName("ds_cor_fundo")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsSkinFundo)
                    .HasColumnName("ds_skin_fundo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsSkinRepeat)
                    .HasColumnName("ds_skin_repeat")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FlExibeCategorizacaoAuto).HasColumnName("fl_exibe_categorizacao_auto");

                entity.Property(e => e.FlExibeHtml).HasColumnName("fl_exibe_html");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.NmLojaEspecial)
                    .IsRequired()
                    .HasColumnName("nm_loja_especial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.Property(e => e.TxHtml)
                    .HasColumnName("tx_html")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TbLojaEspecialBanner>(entity =>
            {
                entity.HasKey(e => e.IdLojaEspecialBanner);

                entity.ToTable("tb_loja_especial_banner");

                entity.Property(e => e.IdLojaEspecialBanner).HasColumnName("id_loja_especial_banner");

                entity.Property(e => e.DsArquivo)
                    .IsRequired()
                    .HasColumnName("ds_arquivo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsArquivoFundo)
                    .HasColumnName("ds_arquivo_fundo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsCorFundo)
                    .HasColumnName("ds_cor_fundo")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DsLink)
                    .IsRequired()
                    .HasColumnName("ds_link")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdLojaEspecial).HasColumnName("id_loja_especial");

                entity.Property(e => e.IdLojaEspecialPosicao).HasColumnName("id_loja_especial_posicao");

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdLojaEspecialNavigation)
                    .WithMany(p => p.TbLojaEspecialBanner)
                    .HasForeignKey(d => d.IdLojaEspecial)
                    .HasConstraintName("FK_tb_loja_especial_banner_tb_loja_especial");

                entity.HasOne(d => d.IdLojaEspecialPosicaoNavigation)
                    .WithMany(p => p.TbLojaEspecialBanner)
                    .HasForeignKey(d => d.IdLojaEspecialPosicao)
                    .HasConstraintName("FK_tb_loja_especial_banner_tb_loja_especial_posicao");
            });

            modelBuilder.Entity<TbLojaEspecialCategoria>(entity =>
            {
                entity.HasKey(e => e.IdLojaEspecialCategoria);

                entity.ToTable("tb_loja_especial_categoria");

                entity.Property(e => e.IdLojaEspecialCategoria).HasColumnName("id_loja_especial_categoria");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdLojaEspecialSecao).HasColumnName("id_loja_especial_secao");

                entity.Property(e => e.NmCategoria)
                    .IsRequired()
                    .HasColumnName("nm_categoria")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdLojaEspecialSecaoNavigation)
                    .WithMany(p => p.TbLojaEspecialCategoria)
                    .HasForeignKey(d => d.IdLojaEspecialSecao)
                    .HasConstraintName("FK_tb_loja_especial_categoria_tb_loja_especial_secao");
            });

            modelBuilder.Entity<TbLojaEspecialDepartamento>(entity =>
            {
                entity.HasKey(e => e.IdLojaEspecialDepartamento);

                entity.ToTable("tb_loja_especial_departamento");

                entity.Property(e => e.IdLojaEspecialDepartamento).HasColumnName("id_loja_especial_departamento");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdLojaEspecial).HasColumnName("id_loja_especial");

                entity.Property(e => e.NmDepartamento)
                    .IsRequired()
                    .HasColumnName("nm_departamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdLojaEspecialNavigation)
                    .WithMany(p => p.TbLojaEspecialDepartamento)
                    .HasForeignKey(d => d.IdLojaEspecial)
                    .HasConstraintName("FK_tb_loja_especial_departamento_tb_loja_especial");
            });

            modelBuilder.Entity<TbLojaEspecialMarca>(entity =>
            {
                entity.HasKey(e => e.IdLojaEspecialMarca);

                entity.ToTable("tb_loja_especial_marca");

                entity.Property(e => e.IdLojaEspecialMarca).HasColumnName("id_loja_especial_marca");

                entity.Property(e => e.IdLojaEspecial).HasColumnName("id_loja_especial");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.HasOne(d => d.IdLojaEspecialNavigation)
                    .WithMany(p => p.TbLojaEspecialMarca)
                    .HasForeignKey(d => d.IdLojaEspecial)
                    .HasConstraintName("FK_tb_loja_especial_marca_tb_loja_especial");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.TbLojaEspecialMarca)
                    .HasForeignKey(d => d.IdMarca)
                    .HasConstraintName("FK_tb_loja_especial_marca_tb_marca");
            });

            modelBuilder.Entity<TbLojaEspecialPosicao>(entity =>
            {
                entity.HasKey(e => e.IdLojaEspecialPosicao);

                entity.ToTable("tb_loja_especial_posicao");

                entity.Property(e => e.IdLojaEspecialPosicao).HasColumnName("id_loja_especial_posicao");

                entity.Property(e => e.NmLojaEspecialPosicao)
                    .IsRequired()
                    .HasColumnName("nm_loja_especial_posicao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuAltura).HasColumnName("nu_altura");

                entity.Property(e => e.NuLargura).HasColumnName("nu_largura");
            });

            modelBuilder.Entity<TbLojaEspecialProduto>(entity =>
            {
                entity.HasKey(e => e.IdLojaEspecialProduto);

                entity.ToTable("tb_loja_especial_produto");

                entity.Property(e => e.IdLojaEspecialProduto).HasColumnName("id_loja_especial_produto");

                entity.Property(e => e.IdLojaEspecial).HasColumnName("id_loja_especial");

                entity.Property(e => e.IdLojaEspecialCategoria).HasColumnName("id_loja_especial_categoria");

                entity.Property(e => e.IdLojaEspecialDepartamento).HasColumnName("id_loja_especial_departamento");

                entity.Property(e => e.IdLojaEspecialSecao).HasColumnName("id_loja_especial_secao");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.HasOne(d => d.IdLojaEspecialNavigation)
                    .WithMany(p => p.TbLojaEspecialProduto)
                    .HasForeignKey(d => d.IdLojaEspecial)
                    .HasConstraintName("FK_tb_loja_especial_produto_tb_loja_especial");

                entity.HasOne(d => d.IdLojaEspecialCategoriaNavigation)
                    .WithMany(p => p.TbLojaEspecialProduto)
                    .HasForeignKey(d => d.IdLojaEspecialCategoria)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_loja_especial_produto_tb_loja_especial_categoria");

                entity.HasOne(d => d.IdLojaEspecialDepartamentoNavigation)
                    .WithMany(p => p.TbLojaEspecialProduto)
                    .HasForeignKey(d => d.IdLojaEspecialDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_loja_especial_produto_tb_loja_especial_departamento");

                entity.HasOne(d => d.IdLojaEspecialSecaoNavigation)
                    .WithMany(p => p.TbLojaEspecialProduto)
                    .HasForeignKey(d => d.IdLojaEspecialSecao)
                    .HasConstraintName("FK_tb_loja_especial_produto_tb_loja_especial_secao");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbLojaEspecialProduto)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_loja_especial_produto_tb_produto");
            });

            modelBuilder.Entity<TbLojaEspecialSecao>(entity =>
            {
                entity.HasKey(e => e.IdLojaEspecialSecao);

                entity.ToTable("tb_loja_especial_secao");

                entity.Property(e => e.IdLojaEspecialSecao).HasColumnName("id_loja_especial_secao");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdLojaEspecialDepartamento).HasColumnName("id_loja_especial_departamento");

                entity.Property(e => e.NmSecao)
                    .IsRequired()
                    .HasColumnName("nm_secao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdLojaEspecialDepartamentoNavigation)
                    .WithMany(p => p.TbLojaEspecialSecao)
                    .HasForeignKey(d => d.IdLojaEspecialDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_loja_especial_secao_tb_loja_especial_departamento");
            });

            modelBuilder.Entity<TbLojaEspecialVitrine>(entity =>
            {
                entity.HasKey(e => e.IdLojaEspecialVitrine);

                entity.ToTable("tb_loja_especial_vitrine");

                entity.Property(e => e.IdLojaEspecialVitrine).HasColumnName("id_loja_especial_vitrine");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdLojaEspecial).HasColumnName("id_loja_especial");

                entity.Property(e => e.NmVitrine)
                    .IsRequired()
                    .HasColumnName("nm_vitrine")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdLojaEspecialNavigation)
                    .WithMany(p => p.TbLojaEspecialVitrine)
                    .HasForeignKey(d => d.IdLojaEspecial)
                    .HasConstraintName("FK_tb_loja_especial_vitrine_tb_loja_especial");
            });

            modelBuilder.Entity<TbLojaEspecialVitrineProduto>(entity =>
            {
                entity.HasKey(e => e.IdLojaEspecialVitrineProduto);

                entity.ToTable("tb_loja_especial_vitrine_produto");

                entity.Property(e => e.IdLojaEspecialVitrineProduto).HasColumnName("id_loja_especial_vitrine_produto");

                entity.Property(e => e.IdLojaEspecialVitrine).HasColumnName("id_loja_especial_vitrine");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdLojaEspecialVitrineNavigation)
                    .WithMany(p => p.TbLojaEspecialVitrineProduto)
                    .HasForeignKey(d => d.IdLojaEspecialVitrine)
                    .HasConstraintName("FK_tb_loja_especial_vitrine_produto_tb_loja_especial_vitrine");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbLojaEspecialVitrineProduto)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_loja_especial_vitrine_produto_tb_produto");
            });

            modelBuilder.Entity<TbLojaFisica>(entity =>
            {
                entity.HasKey(e => e.IdLojaFisica);

                entity.ToTable("tb_loja_fisica");

                entity.Property(e => e.IdLojaFisica).HasColumnName("id_loja_fisica");

                entity.Property(e => e.DsBairro)
                    .IsRequired()
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsCep)
                    .IsRequired()
                    .HasColumnName("ds_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DsCidade)
                    .IsRequired()
                    .HasColumnName("ds_cidade")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsEndereco)
                    .IsRequired()
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsEstado)
                    .IsRequired()
                    .HasColumnName("ds_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsGoogleMaps)
                    .HasColumnName("ds_google_maps")
                    .IsUnicode(false);

                entity.Property(e => e.DsImagemDestaque)
                    .IsRequired()
                    .HasColumnName("ds_imagem_destaque")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsNumero)
                    .HasColumnName("ds_numero")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsSinopse)
                    .HasColumnName("ds_sinopse")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.NmLojaFisica)
                    .IsRequired()
                    .HasColumnName("nm_loja_fisica")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TxConteudo)
                    .IsRequired()
                    .HasColumnName("tx_conteudo")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TbMapeamentoUrl>(entity =>
            {
                entity.HasKey(e => e.IdMapeamento);

                entity.ToTable("tb_mapeamento_url");

                entity.Property(e => e.IdMapeamento).HasColumnName("id_mapeamento");

                entity.Property(e => e.DsResposta).HasColumnName("ds_resposta");

                entity.Property(e => e.DsUrlDe)
                    .IsRequired()
                    .HasColumnName("ds_url_de")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsUrlPara)
                    .IsRequired()
                    .HasColumnName("ds_url_para")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DtFinal)
                    .HasColumnName("dt_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtInicial)
                    .HasColumnName("dt_inicial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");
            });

            modelBuilder.Entity<TbMarca>(entity =>
            {
                entity.HasKey(e => e.IdMarca);

                entity.ToTable("tb_marca");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DsImagem)
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlExibeImagem).HasColumnName("fl_exibe_imagem");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdMarcaVannon).HasColumnName("id_marca_vannon");

                entity.Property(e => e.NmMarca)
                    .IsRequired()
                    .HasColumnName("nm_marca")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbMensagem>(entity =>
            {
                entity.HasKey(e => e.IdMensagem);

                entity.ToTable("tb_mensagem");

                entity.Property(e => e.IdMensagem).HasColumnName("id_mensagem");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DsMensagem)
                    .IsRequired()
                    .HasColumnName("ds_mensagem")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.DsTitulo)
                    .HasColumnName("ds_titulo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtFim)
                    .HasColumnName("dt_fim")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtInicio)
                    .HasColumnName("dt_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");
            });

            modelBuilder.Entity<TbMensagemCategoria>(entity =>
            {
                entity.HasKey(e => e.IdMensagemCategoria);

                entity.ToTable("tb_mensagem_categoria");

                entity.Property(e => e.IdMensagemCategoria).HasColumnName("id_mensagem_categoria");

                entity.Property(e => e.BackofficeCategoria).HasColumnName("backoffice_categoria");

                entity.Property(e => e.BackofficeDepartamento).HasColumnName("backoffice_departamento");

                entity.Property(e => e.BackofficeSecao).HasColumnName("backoffice_secao");

                entity.Property(e => e.BackofficeSubcategoria).HasColumnName("backoffice_subcategoria");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdMensagem).HasColumnName("id_mensagem");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TbMensagemCategoria)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_mensagem_categoria_tb_categoria2");

                entity.HasOne(d => d.IdMensagemNavigation)
                    .WithMany(p => p.TbMensagemCategoria)
                    .HasForeignKey(d => d.IdMensagem)
                    .HasConstraintName("FK_tb_mensagem_categoria_tb_mensagem");
            });

            modelBuilder.Entity<TbMensagemMarca>(entity =>
            {
                entity.HasKey(e => e.IdMensagemMarca);

                entity.ToTable("tb_mensagem_marca");

                entity.Property(e => e.IdMensagemMarca).HasColumnName("id_mensagem_marca");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.Property(e => e.IdMensagem).HasColumnName("id_mensagem");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.TbMensagemMarca)
                    .HasForeignKey(d => d.IdMarca)
                    .HasConstraintName("FK_tb_mensagem_marca_tb_marca");

                entity.HasOne(d => d.IdMensagemNavigation)
                    .WithMany(p => p.TbMensagemMarca)
                    .HasForeignKey(d => d.IdMensagem)
                    .HasConstraintName("FK_tb_mensagem_marca_tb_mensagem");
            });

            modelBuilder.Entity<TbMensagemPrincipioAtivo>(entity =>
            {
                entity.HasKey(e => e.IdMensagemPrincipioAtivo);

                entity.ToTable("tb_mensagem_principio_ativo");

                entity.Property(e => e.IdMensagemPrincipioAtivo).HasColumnName("id_mensagem_principio_ativo");

                entity.Property(e => e.IdMensagem).HasColumnName("id_mensagem");

                entity.Property(e => e.IdPrincipioAtivo).HasColumnName("id_principio_ativo");

                entity.HasOne(d => d.IdMensagemNavigation)
                    .WithMany(p => p.TbMensagemPrincipioAtivo)
                    .HasForeignKey(d => d.IdMensagem)
                    .HasConstraintName("FK_tb_mensagem_principio_ativo_tb_mensagem");

                entity.HasOne(d => d.IdPrincipioAtivoNavigation)
                    .WithMany(p => p.TbMensagemPrincipioAtivo)
                    .HasForeignKey(d => d.IdPrincipioAtivo)
                    .HasConstraintName("FK_tb_mensagem_principio_ativo_tb_principio_ativo");
            });

            modelBuilder.Entity<TbMensagemProdutoControle>(entity =>
            {
                entity.HasKey(e => e.IdMensagemProdutoControle);

                entity.ToTable("tb_mensagem_produto_controle");

                entity.Property(e => e.IdMensagemProdutoControle).HasColumnName("id_mensagem_produto_controle");

                entity.Property(e => e.IdMensagem).HasColumnName("id_mensagem");

                entity.Property(e => e.IdProdutoControle).HasColumnName("id_produto_controle");

                entity.HasOne(d => d.IdMensagemNavigation)
                    .WithMany(p => p.TbMensagemProdutoControle)
                    .HasForeignKey(d => d.IdMensagem)
                    .HasConstraintName("FK_tb_mensagem_produto_controle_tb_mensagem");

                entity.HasOne(d => d.IdProdutoControleNavigation)
                    .WithMany(p => p.TbMensagemProdutoControle)
                    .HasForeignKey(d => d.IdProdutoControle)
                    .HasConstraintName("FK_tb_mensagem_produto_controle_tb_produto_controle");
            });

            modelBuilder.Entity<TbMensagemProdutoFamilia>(entity =>
            {
                entity.HasKey(e => e.IdMensagemProdutoFamilia);

                entity.ToTable("tb_mensagem_produto_familia");

                entity.Property(e => e.IdMensagemProdutoFamilia).HasColumnName("id_mensagem_produto_familia");

                entity.Property(e => e.IdMensagem).HasColumnName("id_mensagem");

                entity.Property(e => e.IdProdutoFamilia).HasColumnName("id_produto_familia");

                entity.HasOne(d => d.IdMensagemNavigation)
                    .WithMany(p => p.TbMensagemProdutoFamilia)
                    .HasForeignKey(d => d.IdMensagem)
                    .HasConstraintName("FK_tb_mensagem_produto_familia_tb_mensagem");

                entity.HasOne(d => d.IdProdutoFamiliaNavigation)
                    .WithMany(p => p.TbMensagemProdutoFamilia)
                    .HasForeignKey(d => d.IdProdutoFamilia)
                    .HasConstraintName("FK_tb_mensagem_produto_familia_tb_produto_familia");
            });

            modelBuilder.Entity<TbMensagemProdutoTipo>(entity =>
            {
                entity.HasKey(e => e.IdMensagemProdutoTipo);

                entity.ToTable("tb_mensagem_produto_tipo");

                entity.Property(e => e.IdMensagemProdutoTipo).HasColumnName("id_mensagem_produto_tipo");

                entity.Property(e => e.IdMensagem).HasColumnName("id_mensagem");

                entity.Property(e => e.IdProdutoTipo).HasColumnName("id_produto_tipo");

                entity.HasOne(d => d.IdMensagemNavigation)
                    .WithMany(p => p.TbMensagemProdutoTipo)
                    .HasForeignKey(d => d.IdMensagem)
                    .HasConstraintName("FK_tb_mensagem_produto_tipo_tb_mensagem");

                entity.HasOne(d => d.IdProdutoTipoNavigation)
                    .WithMany(p => p.TbMensagemProdutoTipo)
                    .HasForeignKey(d => d.IdProdutoTipo)
                    .HasConstraintName("FK_tb_mensagem_produto_tipo_tb_produto_tipo");
            });

            modelBuilder.Entity<TbModalidadeEntrega>(entity =>
            {
                entity.HasKey(e => e.IdModalidadeEntrega);

                entity.ToTable("tb_modalidade_entrega");

                entity.Property(e => e.IdModalidadeEntrega).HasColumnName("id_modalidade_entrega");

                entity.Property(e => e.CdEmpresaCorreios)
                    .HasColumnName("cd_empresa_correios")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdEmpresaTotalexpress)
                    .HasColumnName("cd_empresa_totalexpress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DsMensagem)
                    .HasColumnName("ds_mensagem")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DsSenhaCorreios)
                    .HasColumnName("ds_senha_correios")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsSenhaTotalexpress)
                    .HasColumnName("ds_senha_totalexpress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUrlRastreamento)
                    .HasColumnName("ds_url_rastreamento")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FlAvisoRecebimento)
                    .HasColumnName("fl_aviso_recebimento")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FlCashondeliveryTotalexpress).HasColumnName("fl_cashondelivery_totalexpress");

                entity.Property(e => e.FlCorreiosAutomatico).HasColumnName("fl_correios_automatico");

                entity.Property(e => e.FlEntregaAgendada).HasColumnName("fl_entrega_agendada");

                entity.Property(e => e.FlMaoPropria)
                    .HasColumnName("fl_mao_propria")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.FlTotalexpressAutomatico).HasColumnName("fl_totalexpress_automatico");

                entity.Property(e => e.FlUtilizarFaixaCep).HasColumnName("fl_utilizar_faixa_cep");

                entity.Property(e => e.FlValorDeclarado)
                    .HasColumnName("fl_valor_declarado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdModalidadeEntregaTipo).HasColumnName("id_modalidade_entrega_tipo");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.IdServicoCorreios).HasColumnName("id_servico_correios");

                entity.Property(e => e.IdServicoTotalexpress).HasColumnName("id_servico_totalexpress");

                entity.Property(e => e.NmModalidadeEntrega)
                    .IsRequired()
                    .HasColumnName("nm_modalidade_entrega")
                    .HasMaxLength(82)
                    .IsUnicode(false);

                entity.Property(e => e.NuIcms)
                    .HasColumnName("nu_icms")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PcSeguro)
                    .HasColumnName("pc_seguro")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlCubagem)
                    .HasColumnName("vl_cubagem")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdPracaNavigation)
                    .WithMany(p => p.TbModalidadeEntrega)
                    .HasForeignKey(d => d.IdPraca)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_modalidade_praca");

                entity.HasOne(d => d.IdServicoCorreiosNavigation)
                    .WithMany(p => p.TbModalidadeEntrega)
                    .HasForeignKey(d => d.IdServicoCorreios)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tb_modali__id_se__15C52FC4");
            });

            modelBuilder.Entity<TbModalidadeEntregaAgenda>(entity =>
            {
                entity.HasKey(e => e.IdModalidadeEntregaAgenda);

                entity.ToTable("tb_modalidade_entrega_agenda");

                entity.Property(e => e.IdModalidadeEntregaAgenda).HasColumnName("id_modalidade_entrega_agenda");

                entity.Property(e => e.DtHorarioFinal)
                    .HasColumnName("dt_horario_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtHorarioInicio)
                    .HasColumnName("dt_horario_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdDiaSemana).HasColumnName("id_dia_semana");

                entity.Property(e => e.IdModalidadeEntrega).HasColumnName("id_modalidade_entrega");

                entity.Property(e => e.VlAdicional)
                    .HasColumnName("vl_adicional")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdDiaSemanaNavigation)
                    .WithMany(p => p.TbModalidadeEntregaAgenda)
                    .HasForeignKey(d => d.IdDiaSemana)
                    .HasConstraintName("FK_tb_modalidade_entrega_agenda_tb_dia_semana");

                entity.HasOne(d => d.IdModalidadeEntregaNavigation)
                    .WithMany(p => p.TbModalidadeEntregaAgenda)
                    .HasForeignKey(d => d.IdModalidadeEntrega)
                    .HasConstraintName("FK_tb_modalidade_entrega_agenda_tb_modalidade_entrega");
            });

            modelBuilder.Entity<TbModalidadeEntregaCep>(entity =>
            {
                entity.HasKey(e => e.IdModalidadeEntregaCep);

                entity.ToTable("tb_modalidade_entrega_cep");

                entity.HasIndex(e => new { e.DsCepFinal, e.DsCepInicial, e.NuPesoFinal, e.NuPesoInicial, e.VlAdicionalGrama, e.IdModalidadeEntrega })
                    .HasName("IX_modalidade_cep_inicial");

                entity.Property(e => e.IdModalidadeEntregaCep).HasColumnName("id_modalidade_entrega_cep");

                entity.Property(e => e.DsBairro)
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsCepFinal)
                    .IsRequired()
                    .HasColumnName("ds_cep_final")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DsCepInicial)
                    .IsRequired()
                    .HasColumnName("ds_cep_inicial")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DsCidade)
                    .HasColumnName("ds_cidade")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsEstado)
                    .HasColumnName("ds_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DsMensagem)
                    .HasColumnName("ds_mensagem")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdModalidadeEntrega).HasColumnName("id_modalidade_entrega");

                entity.Property(e => e.NuPesoFinal)
                    .HasColumnName("nu_peso_final")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NuPesoInicial)
                    .HasColumnName("nu_peso_inicial")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NuPrazoEntrega).HasColumnName("nu_prazo_entrega");

                entity.Property(e => e.VlAdicionalGrama)
                    .HasColumnName("vl_adicional_grama")
                    .HasColumnType("money");

                entity.Property(e => e.VlFrete)
                    .HasColumnName("vl_frete")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdModalidadeEntregaNavigation)
                    .WithMany(p => p.TbModalidadeEntregaCep)
                    .HasForeignKey(d => d.IdModalidadeEntrega)
                    .HasConstraintName("FK_tb_modalidade_entrega_cep_tb_modalidade_entrega");
            });

            modelBuilder.Entity<TbModalidadeEntregaLoja>(entity =>
            {
                entity.HasKey(e => e.IdModalidadeEntregaLoja);

                entity.ToTable("tb_modalidade_entrega_loja");

                entity.Property(e => e.IdModalidadeEntregaLoja).HasColumnName("id_modalidade_entrega_loja");

                entity.Property(e => e.DsBairro)
                    .IsRequired()
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsCep)
                    .IsRequired()
                    .HasColumnName("ds_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DsCidade)
                    .IsRequired()
                    .HasColumnName("ds_cidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsComplemento)
                    .IsRequired()
                    .HasColumnName("ds_complemento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsEndereco)
                    .IsRequired()
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsEstado)
                    .IsRequired()
                    .HasColumnName("ds_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsNumero)
                    .IsRequired()
                    .HasColumnName("ds_numero")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DsTelefone)
                    .HasColumnName("ds_telefone")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.IdModalidadeEntrega).HasColumnName("id_modalidade_entrega");

                entity.HasOne(d => d.IdModalidadeEntregaNavigation)
                    .WithMany(p => p.TbModalidadeEntregaLoja)
                    .HasForeignKey(d => d.IdModalidadeEntrega)
                    .HasConstraintName("FK_tb_modalidade_entrega_loja_tb_modalidade_entrega");
            });

            modelBuilder.Entity<TbModalidadeEntregaRestricao>(entity =>
            {
                entity.HasKey(e => e.IdModalidadeEntregaRestricao);

                entity.ToTable("tb_modalidade_entrega_restricao");

                entity.Property(e => e.IdModalidadeEntregaRestricao).HasColumnName("id_modalidade_entrega_restricao");

                entity.Property(e => e.DsCepFinal)
                    .IsRequired()
                    .HasColumnName("ds_cep_final")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsCepInicial)
                    .IsRequired()
                    .HasColumnName("ds_cep_inicial")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsMensagem)
                    .IsRequired()
                    .HasColumnName("ds_mensagem")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FlAtende).HasColumnName("fl_atende");

                entity.Property(e => e.FlConsideraHorario).HasColumnName("fl_considera_horario");

                entity.Property(e => e.IdModalidadeEntrega).HasColumnName("id_modalidade_entrega");

                entity.Property(e => e.NuHorarioFinal)
                    .HasColumnName("nu_horario_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NuHorarioInicial)
                    .HasColumnName("nu_horario_inicial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NuHorasAcrescimo).HasColumnName("nu_horas_acrescimo");

                entity.Property(e => e.PcAcrescimoTarifa)
                    .HasColumnName("pc_acrescimo_tarifa")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdModalidadeEntregaNavigation)
                    .WithMany(p => p.TbModalidadeEntregaRestricao)
                    .HasForeignKey(d => d.IdModalidadeEntrega)
                    .HasConstraintName("FK_tb_modalidade_entrega_restricao_tb_modalidade_entrega");
            });

            modelBuilder.Entity<TbModalidadeEntregaTipo>(entity =>
            {
                entity.HasKey(e => e.IdModalidadeEntregaTipo);

                entity.ToTable("tb_modalidade_entrega_tipo");

                entity.Property(e => e.IdModalidadeEntregaTipo).HasColumnName("id_modalidade_entrega_tipo");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsModalidadeEntregaTipo)
                    .IsRequired()
                    .HasColumnName("ds_modalidade_entrega_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbNewsletter>(entity =>
            {
                entity.HasKey(e => e.IdNewsletter);

                entity.ToTable("tb_newsletter");

                entity.Property(e => e.IdNewsletter).HasColumnName("id_newsletter");

                entity.Property(e => e.DsEmail)
                    .IsRequired()
                    .HasColumnName("ds_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlStatus)
                    .HasColumnName("fl_status")
                    .HasComment("0 - Inativo / 1- Ativo");

                entity.Property(e => e.NmContato)
                    .IsRequired()
                    .HasColumnName("nm_contato")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbOfertaEspecial>(entity =>
            {
                entity.HasKey(e => e.IdOfertaEspecial);

                entity.ToTable("tb_oferta_especial");

                entity.Property(e => e.IdOfertaEspecial).HasColumnName("id_oferta_especial");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbOfertaEspecial)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_oferta_especial_tb_produto");
            });

            modelBuilder.Entity<TbPagamento>(entity =>
            {
                entity.HasKey(e => e.IdPagamento);

                entity.ToTable("tb_pagamento");

                entity.Property(e => e.IdPagamento).HasColumnName("id_pagamento");

                entity.Property(e => e.DsInstrucaoPagamento)
                    .HasColumnName("ds_instrucao_pagamento")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdFormaPagamento).HasColumnName("id_forma_pagamento");

                entity.Property(e => e.NmPagamento)
                    .IsRequired()
                    .HasColumnName("nm_pagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuVencimentoPagamento).HasColumnName("nu_vencimento_pagamento");

                entity.Property(e => e.VlTrocoMaximo)
                    .HasColumnName("vl_troco_maximo")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdFormaPagamentoNavigation)
                    .WithMany(p => p.TbPagamento)
                    .HasForeignKey(d => d.IdFormaPagamento)
                    .HasConstraintName("FK_tb_pagamento_tb_forma_pagamento");
            });

            modelBuilder.Entity<TbPagamentoGateway>(entity =>
            {
                entity.HasKey(e => e.IdPagamentoGateway);

                entity.ToTable("tb_pagamento_gateway");

                entity.Property(e => e.IdPagamentoGateway).HasColumnName("id_pagamento_gateway");

                entity.Property(e => e.IdGateway).HasColumnName("id_gateway");

                entity.Property(e => e.IdPagamento).HasColumnName("id_pagamento");

                entity.HasOne(d => d.IdGatewayNavigation)
                    .WithMany(p => p.TbPagamentoGateway)
                    .HasForeignKey(d => d.IdGateway)
                    .HasConstraintName("FK_tb_pagamento_gateway_tb_gateway");

                entity.HasOne(d => d.IdPagamentoNavigation)
                    .WithMany(p => p.TbPagamentoGateway)
                    .HasForeignKey(d => d.IdPagamento)
                    .HasConstraintName("FK_tb_pagamento_gateway_tb_pagamento");
            });

            modelBuilder.Entity<TbPagamentoParcela>(entity =>
            {
                entity.HasKey(e => e.IdPagamentoParcela);

                entity.ToTable("tb_pagamento_parcela");

                entity.Property(e => e.IdPagamentoParcela).HasColumnName("id_pagamento_parcela");

                entity.Property(e => e.IdPagamento).HasColumnName("id_pagamento");

                entity.Property(e => e.NmPagamentoParcela)
                    .IsRequired()
                    .HasColumnName("nm_pagamento_parcela")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuParcela).HasColumnName("nu_parcela");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("VL_DESCONTO")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlJurosMes)
                    .HasColumnName("vl_juros_mes")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlParcelaMinima)
                    .HasColumnName("vl_parcela_minima")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdPagamentoNavigation)
                    .WithMany(p => p.TbPagamentoParcela)
                    .HasForeignKey(d => d.IdPagamento)
                    .HasConstraintName("FK_tb_pagamento_parcela_tb_pagamento");
            });

            modelBuilder.Entity<TbParceiro>(entity =>
            {
                entity.HasKey(e => e.IdParceiro);

                entity.ToTable("tb_parceiro");

                entity.Property(e => e.IdParceiro).HasColumnName("id_parceiro");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsLink)
                    .HasColumnName("ds_link")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsLogo)
                    .HasColumnName("ds_logo")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DsParceiro)
                    .HasColumnName("ds_parceiro")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtGeracaoArquivo)
                    .HasColumnName("dt_geracao_arquivo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlComparador).HasColumnName("fl_comparador");

                entity.Property(e => e.NmParceiro)
                    .IsRequired()
                    .HasColumnName("nm_parceiro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuQtdeProdutoSku).HasColumnName("nu_qtde_produto_sku");
            });

            modelBuilder.Entity<TbParceiroXmlProduto>(entity =>
            {
                entity.HasKey(e => e.IdParceiroXmlProduto);

                entity.ToTable("tb_parceiro_xml_produto");

                entity.Property(e => e.IdParceiroXmlProduto).HasColumnName("id_parceiro_xml_produto");

                entity.Property(e => e.IdParceiro).HasColumnName("id_parceiro");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.HasOne(d => d.IdParceiroNavigation)
                    .WithMany(p => p.TbParceiroXmlProduto)
                    .HasForeignKey(d => d.IdParceiro)
                    .HasConstraintName("FK_tb_parceiro_xml_produto_tb_parceiro");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbParceiroXmlProduto)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_parceiro_xml_produto_tb_produto_sku");
            });

            modelBuilder.Entity<TbPedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.ToTable("tb_pedido");

                entity.HasIndex(e => new { e.VlTotal, e.IdPraca, e.NmModalidadeEntrega, e.NuPedido, e.FlIntegracao, e.IdCliente, e.IdPedido, e.DsStatusAntifraude, e.DtPedido, e.IdPedidoStatus })
                    .HasName("idx_pedido_id_pedido_status");

                entity.HasIndex(e => new { e.DtPedido, e.DtExpiracao, e.IdCliente, e.IdPedido, e.DsIp, e.DsNavegador, e.VlDesconto, e.VlTotal, e.VlDescontoFrete, e.VlFrete, e.IdPedidoStatus })
                    .HasName("rel_carrinho_cliente");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.CdAdministradoraPbm)
                    .HasColumnName("cd_administradora_pbm")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CdRastreamento)
                    .HasColumnName("cd_rastreamento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CdVendedor)
                    .HasColumnName("CD_VENDEDOR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsCep)
                    .HasColumnName("ds_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsComprovantePbm)
                    .HasColumnName("ds_comprovante_pbm")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DsDescricao)
                    .HasColumnName("ds_descricao")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DsFingerPrintSessionId)
                    .HasColumnName("ds_finger_print_session_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsIp)
                    .IsRequired()
                    .HasColumnName("ds_ip")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsMensagemEntrega)
                    .HasColumnName("ds_mensagem_entrega")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DsNavegador)
                    .IsRequired()
                    .HasColumnName("ds_navegador")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsStatusAntifraude)
                    .HasColumnName("ds_status_antifraude")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DtExpiracao)
                    .HasColumnName("dt_expiracao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtPedido)
                    .HasColumnName("dt_pedido")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlImpresso)
                    .HasColumnName("fl_impresso")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FlIntegracao)
                    .HasColumnName("fl_integracao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlMarketingCarrinhoVerificado)
                    .HasColumnName("fl_marketing_carrinho_verificado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FlNfPaulista).HasColumnName("fl_nf_paulista");

                entity.Property(e => e.FlRetornoEstoque).HasColumnName("fl_retorno_estoque");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdModalidadeEntrega).HasColumnName("id_modalidade_entrega");

                entity.Property(e => e.IdParceiro).HasColumnName("id_parceiro");

                entity.Property(e => e.IdPedidoOrigem).HasColumnName("id_pedido_origem");

                entity.Property(e => e.IdPedidoStatus).HasColumnName("id_pedido_status");

                entity.Property(e => e.IdPedidoStatusPbm).HasColumnName("id_pedido_status_pbm");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.IdUsuarioTelevendas).HasColumnName("id_usuario_televendas");

                entity.Property(e => e.NmModalidadeEntrega)
                    .HasColumnName("nm_modalidade_entrega")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrCartaoclientePbm).HasColumnName("nr_cartaocliente_pbm");

                entity.Property(e => e.NrCentralPbm).HasColumnName("nr_central_pbm");

                entity.Property(e => e.NrCpfclientePbm).HasColumnName("nr_cpfcliente_pbm");

                entity.Property(e => e.NrCupomFiscal).HasColumnName("nr_cupom_fiscal");

                entity.Property(e => e.NuPedido)
                    .HasColumnName("nu_pedido")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NuPrazoEntrega).HasColumnName("nu_prazo_entrega");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("money");

                entity.Property(e => e.VlDescontoCarrinho)
                    .HasColumnName("vl_desconto_carrinho")
                    .HasColumnType("money");

                entity.Property(e => e.VlDescontoCliente)
                    .HasColumnName("vl_desconto_cliente")
                    .HasColumnType("money");

                entity.Property(e => e.VlDescontoCupom)
                    .HasColumnName("vl_desconto_cupom")
                    .HasColumnType("money");

                entity.Property(e => e.VlDescontoFrete)
                    .HasColumnName("vl_desconto_frete")
                    .HasColumnType("money");

                entity.Property(e => e.VlDescontoPagamento)
                    .HasColumnName("vl_desconto_pagamento")
                    .HasColumnType("money");

                entity.Property(e => e.VlDescontoPrimeiraCompra)
                    .HasColumnName("vl_desconto_primeira_compra")
                    .HasColumnType("money");

                entity.Property(e => e.VlDescontoProduto)
                    .HasColumnName("vl_desconto_produto")
                    .HasColumnType("money");

                entity.Property(e => e.VlFrete)
                    .HasColumnName("vl_frete")
                    .HasColumnType("money");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TbPedidoEntrega>(entity =>
            {
                entity.HasKey(e => e.IdPedidoEntrega);

                entity.ToTable("tb_pedido_entrega");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("idx_pedido_entrega");

                entity.HasIndex(e => new { e.DsCep, e.IdClienteEndereco, e.NmTipoEndereco })
                    .HasName("NonClusteredIndex-20181010-162155");

                entity.Property(e => e.IdPedidoEntrega).HasColumnName("id_pedido_entrega");

                entity.Property(e => e.DsBairro)
                    .IsRequired()
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsCep)
                    .IsRequired()
                    .HasColumnName("ds_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsCidade)
                    .IsRequired()
                    .HasColumnName("ds_cidade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsComplemento)
                    .HasColumnName("ds_complemento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsDestinatario)
                    .HasColumnName("ds_destinatario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsEndereco)
                    .IsRequired()
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsEstado)
                    .IsRequired()
                    .HasColumnName("ds_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsReferencia)
                    .HasColumnName("ds_referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdClienteEndereco).HasColumnName("id_cliente_endereco");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.NmTipoEndereco)
                    .HasColumnName("nm_tipo_endereco")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuEndereco)
                    .IsRequired()
                    .HasColumnName("nu_endereco")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TbPedidoEntrega)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_entrega_tb_pedido");
            });

            modelBuilder.Entity<TbPedidoGestaoRisco>(entity =>
            {
                entity.HasKey(e => e.IdGestaoRisco);

                entity.ToTable("tb_pedido_gestao_risco");

                entity.Property(e => e.IdGestaoRisco).HasColumnName("id_gestao_risco");

                entity.Property(e => e.DsMensagem)
                    .HasColumnName("ds_mensagem")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DsMetodoComunicacao)
                    .HasColumnName("ds_metodo_comunicacao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsScore)
                    .HasColumnName("ds_score")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DsSessionId)
                    .HasColumnName("ds_session_id")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DsStatus)
                    .HasColumnName("ds_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DsStatusCode)
                    .HasColumnName("ds_status_code")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.DsTransacao)
                    .HasColumnName("ds_transacao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsXmlRetorno)
                    .HasColumnName("ds_xml_retorno")
                    .IsUnicode(false);

                entity.Property(e => e.DtOcorrencia)
                    .HasColumnName("dt_ocorrencia")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlEnviado).HasColumnName("fl_enviado");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");
            });

            modelBuilder.Entity<TbPedidoHistorico>(entity =>
            {
                entity.HasKey(e => e.IdPedidoHistorico);

                entity.ToTable("tb_pedido_historico");

                entity.Property(e => e.IdPedidoHistorico).HasColumnName("id_pedido_historico");

                entity.Property(e => e.DsHistorico)
                    .IsRequired()
                    .HasColumnName("ds_historico")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TbPedidoHistorico)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_historico_tb_pedido");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TbPedidoHistorico)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_historico_tb_usuario");
            });

            modelBuilder.Entity<TbPedidoLog>(entity =>
            {
                entity.HasKey(e => e.IdPedidoLog);

                entity.ToTable("tb_pedido_log");

                entity.Property(e => e.IdPedidoLog).HasColumnName("id_pedido_log");

                entity.Property(e => e.DsOrigem)
                    .HasColumnName("ds_origem")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.IdPedidoStatusAnterior).HasColumnName("id_pedido_status_anterior");

                entity.Property(e => e.IdPedidoStatusAtual).HasColumnName("id_pedido_status_atual");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TbPedidoLog)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_log_tb_pedido");

                entity.HasOne(d => d.IdPedidoStatusAnteriorNavigation)
                    .WithMany(p => p.TbPedidoLogIdPedidoStatusAnteriorNavigation)
                    .HasForeignKey(d => d.IdPedidoStatusAnterior)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_log_tb_pedido_status");

                entity.HasOne(d => d.IdPedidoStatusAtualNavigation)
                    .WithMany(p => p.TbPedidoLogIdPedidoStatusAtualNavigation)
                    .HasForeignKey(d => d.IdPedidoStatusAtual)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_log_tb_pedido_status1");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TbPedidoLog)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_tb_pedido_log_tb_usuario1");
            });

            modelBuilder.Entity<TbPedidoOrigem>(entity =>
            {
                entity.HasKey(e => e.IdPedidoOrigem);

                entity.ToTable("tb_pedido_origem");

                entity.Property(e => e.IdPedidoOrigem).HasColumnName("id_pedido_origem");

                entity.Property(e => e.NmPedidoOrigem)
                    .IsRequired()
                    .HasColumnName("nm_pedido_origem")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPedidoPagamento>(entity =>
            {
                entity.HasKey(e => e.IdPedidoPagamento);

                entity.ToTable("tb_pedido_pagamento");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("IndiceIDPedido");

                entity.HasIndex(e => e.IdPedidoPagamento)
                    .HasName("IndiceIDPagamento");

                entity.HasIndex(e => new { e.IdPedido, e.IdPagamento, e.NuParcela })
                    .HasName("index_tb_pedido_pagamento_pedidosql");

                entity.Property(e => e.IdPedidoPagamento).HasColumnName("id_pedido_pagamento");

                entity.Property(e => e.CdBarra)
                    .HasColumnName("cd_barra")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CdSeguranca)
                    .HasColumnName("cd_seguranca")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsBandeiraMaquineta)
                    .HasColumnName("ds_bandeira_maquineta")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsChaveCobranca)
                    .HasColumnName("ds_chave_cobranca")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DsChavePedido)
                    .HasColumnName("ds_chave_pedido")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsChaveTransacao)
                    .HasColumnName("ds_chave_transacao")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsReciboCliente)
                    .HasColumnName("ds_recibo_cliente")
                    .IsUnicode(false);

                entity.Property(e => e.DsReciboEmpresa)
                    .HasColumnName("ds_recibo_empresa")
                    .IsUnicode(false);

                entity.Property(e => e.DsUrlBoleto)
                    .HasColumnName("ds_url_boleto")
                    .IsUnicode(false);

                entity.Property(e => e.DsUrlTransferencia)
                    .HasColumnName("ds_url_transferencia")
                    .IsUnicode(false);

                entity.Property(e => e.DtValidadeCartao)
                    .HasColumnName("dt_validade_cartao")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DtVencimento)
                    .HasColumnName("dt_vencimento")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdPagamento).HasColumnName("id_pagamento");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.NmCartao)
                    .HasColumnName("nm_cartao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NossoNumero)
                    .HasColumnName("nosso_numero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nsu)
                    .HasColumnName("nsu")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NuBinCartao)
                    .HasColumnName("nu_bin_cartao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NuCartao)
                    .HasColumnName("nu_cartao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NuComprovante)
                    .HasColumnName("nu_comprovante")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuNit)
                    .HasColumnName("nu_nit")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NuParcela).HasColumnName("nu_parcela");

                entity.Property(e => e.NuTransacao)
                    .HasColumnName("nu_transacao")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VlDinheiro)
                    .HasColumnName("vl_dinheiro")
                    .HasColumnType("money");

                entity.Property(e => e.VlParcela)
                    .HasColumnName("vl_parcela")
                    .HasColumnType("money");

                entity.Property(e => e.VlTroco)
                    .HasColumnName("vl_troco")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdPagamentoNavigation)
                    .WithMany(p => p.TbPedidoPagamento)
                    .HasForeignKey(d => d.IdPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_pagamento_tb_pagamento");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TbPedidoPagamento)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_pagamento_tb_pedido");
            });

            modelBuilder.Entity<TbPedidoPagamentoLog>(entity =>
            {
                entity.HasKey(e => e.IdPedidoPagamentoLog);

                entity.ToTable("tb_pedido_pagamento_log");

                entity.Property(e => e.IdPedidoPagamentoLog).HasColumnName("id_pedido_pagamento_log");

                entity.Property(e => e.DsMensagem)
                    .HasColumnName("ds_mensagem")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DtLog)
                    .HasColumnName("dt_log")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.XmlEnvio)
                    .HasColumnName("xml_envio")
                    .IsUnicode(false);

                entity.Property(e => e.XmlRetorno)
                    .HasColumnName("xml_retorno")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TbPedidoPagamentoLog)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_pagamento_log_tb_pedido");
            });

            modelBuilder.Entity<TbPedidoProdutoKit>(entity =>
            {
                entity.HasKey(e => e.IdPedidoProdutoKit);

                entity.ToTable("tb_pedido_produto_kit");

                entity.Property(e => e.IdPedidoProdutoKit).HasColumnName("id_pedido_produto_kit");

                entity.Property(e => e.IdPedidoProdutoSku).HasColumnName("id_pedido_produto_sku");

                entity.Property(e => e.IdProdutoItem).HasColumnName("id_produto_item");

                entity.Property(e => e.NuQuantidade).HasColumnName("nu_quantidade");

                entity.HasOne(d => d.IdPedidoProdutoSkuNavigation)
                    .WithMany(p => p.TbPedidoProdutoKit)
                    .HasForeignKey(d => d.IdPedidoProdutoSku)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_produto_kit_tb_pedido_produto_sku");

                entity.HasOne(d => d.IdProdutoItemNavigation)
                    .WithMany(p => p.TbPedidoProdutoKit)
                    .HasForeignKey(d => d.IdProdutoItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_produto_kit_tb_produto_sku");
            });

            modelBuilder.Entity<TbPedidoProdutoSku>(entity =>
            {
                entity.HasKey(e => e.IdPedidoProdutoSku);

                entity.ToTable("tb_pedido_produto_sku");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("idx_pedido_produto_sku");

                entity.HasIndex(e => e.IdProdutoSku)
                    .HasName("idx_produto_sku");

                entity.HasIndex(e => new { e.VlEmbalagem, e.IdPedido })
                    .HasName("index_tb_pedido_produto_sku_pedidosql");

                entity.Property(e => e.IdPedidoProdutoSku).HasColumnName("id_pedido_produto_sku");

                entity.Property(e => e.CdProgramaPbm)
                    .HasColumnName("cd_programa_pbm")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlBrinde).HasColumnName("fl_brinde");

                entity.Property(e => e.FlEncomenda).HasColumnName("fl_encomenda");

                entity.Property(e => e.FlEstoqueDisponivel)
                    .IsRequired()
                    .HasColumnName("fl_estoque_disponivel")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FlPbm).HasColumnName("fl_pbm");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.IdProdutoCasado).HasColumnName("id_produto_casado");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.NuQuantidade).HasColumnName("nu_quantidade");

                entity.Property(e => e.PcDescontoPbm)
                    .HasColumnName("pc_desconto_pbm")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("money");

                entity.Property(e => e.VlDescontoCasada)
                    .HasColumnName("vl_desconto_casada")
                    .HasColumnType("money");

                entity.Property(e => e.VlEmbalagem)
                    .HasColumnName("vl_embalagem")
                    .HasColumnType("money");

                entity.Property(e => e.VlProduto)
                    .HasColumnName("vl_produto")
                    .HasColumnType("money");

                entity.Property(e => e.VlProdutoDe)
                    .HasColumnName("vl_produto_de")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TbPedidoProdutoSku)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_produto_sku_tb_pedido");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbPedidoProdutoSku)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_pedido_produto_sku_tb_produto_sku");
            });

            modelBuilder.Entity<TbPedidoSevenpdv>(entity =>
            {
                entity.HasKey(e => e.IdPedidoSevenpdv)
                    .HasName("PK__tb_pedid__09E15CF271C95D1E");

                entity.ToTable("tb_pedido_sevenpdv");

                entity.HasComment("Tabela que guardas as requisições da sevenpdv");

                entity.Property(e => e.IdPedidoSevenpdv).HasColumnName("id_pedido_sevenpdv");

                entity.Property(e => e.DsEfetiva)
                    .HasColumnName("ds_efetiva")
                    .IsUnicode(false);

                entity.Property(e => e.DsFinaliza)
                    .HasColumnName("ds_finaliza")
                    .IsUnicode(false);

                entity.Property(e => e.DsPreauth)
                    .HasColumnName("ds_preauth")
                    .IsUnicode(false);

                entity.Property(e => e.DtAlteracao)
                    .HasColumnName("dt_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCriacao)
                    .HasColumnName("dt_criacao")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlEfetivado).HasColumnName("fl_efetivado");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TbPedidoSevenpdv)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("tb_pedido_sevenpdv_fk_tb_pedido");
            });

            modelBuilder.Entity<TbPedidoStatus>(entity =>
            {
                entity.HasKey(e => e.IdPedidoStatus);

                entity.ToTable("tb_pedido_status");

                entity.Property(e => e.IdPedidoStatus)
                    .HasColumnName("id_pedido_status")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlVendido).HasColumnName("fl_vendido");

                entity.Property(e => e.NmPedidoStatus)
                    .IsRequired()
                    .HasColumnName("nm_pedido_status")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPedidoStatusPbm>(entity =>
            {
                entity.HasKey(e => e.IdPedidoStatusPbm);

                entity.ToTable("tb_pedido_status_pbm");

                entity.HasIndex(e => e.CdExterno)
                    .HasName("EX_tb_pedido_status_pbm")
                    .IsUnique();

                entity.Property(e => e.IdPedidoStatusPbm).HasColumnName("id_pedido_status_pbm");

                entity.Property(e => e.CdExterno).HasColumnName("cd_externo");

                entity.Property(e => e.DsDescricao)
                    .HasColumnName("ds_descricao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DtAlteracao)
                    .HasColumnName("dt_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAutorizador).HasColumnName("id_autorizador");
            });

            modelBuilder.Entity<TbPosicao>(entity =>
            {
                entity.HasKey(e => e.IdPosicao);

                entity.ToTable("tb_posicao");

                entity.Property(e => e.IdPosicao).HasColumnName("id_posicao");

                entity.Property(e => e.NmPosicao)
                    .IsRequired()
                    .HasColumnName("nm_posicao")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPraca>(entity =>
            {
                entity.HasKey(e => e.IdPraca);

                entity.ToTable("tb_praca");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DsAlias)
                    .HasColumnName("ds_alias")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsArquivoLogo)
                    .HasColumnName("ds_arquivo_logo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsBairro)
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsCep)
                    .HasColumnName("ds_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DsCidade)
                    .HasColumnName("ds_cidade")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsComplemento)
                    .HasColumnName("ds_complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsEndereco)
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsEstado)
                    .HasColumnName("ds_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsHorarioAtendimento)
                    .HasColumnName("ds_horario_atendimento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsTelefone)
                    .HasColumnName("ds_telefone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsWhatsapp)
                    .HasColumnName("ds_whatsapp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtUltimoPedido)
                    .HasColumnName("dt_ultimo_pedido")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlAtivo).HasColumnName("fl_ativo");

                entity.Property(e => e.FlExibeFrontend).HasColumnName("fl_exibe_frontend");

                entity.Property(e => e.FlInicial).HasColumnName("fl_inicial");

                entity.Property(e => e.FlPadrao).HasColumnName("fl_padrao");

                entity.Property(e => e.IdPracaPadrao).HasColumnName("id_praca_padrao");

                entity.Property(e => e.NmPraca)
                    .IsRequired()
                    .HasColumnName("nm_praca")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuEndereco)
                    .HasColumnName("nu_endereco")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPracaPadraoNavigation)
                    .WithMany(p => p.InverseIdPracaPadraoNavigation)
                    .HasForeignKey(d => d.IdPracaPadrao)
                    .HasConstraintName("FK_tb_praca_tb_praca");
            });

            modelBuilder.Entity<TbPracaCep>(entity =>
            {
                entity.HasKey(e => e.IdPracaCep);

                entity.ToTable("tb_praca_cep");

                entity.Property(e => e.IdPracaCep).HasColumnName("id_praca_cep");

                entity.Property(e => e.DsBairro)
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsCepFinal)
                    .IsRequired()
                    .HasColumnName("ds_cep_final")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DsCepInicial)
                    .IsRequired()
                    .HasColumnName("ds_cep_inicial")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DsCidade)
                    .HasColumnName("ds_cidade")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsDdd)
                    .HasColumnName("ds_ddd")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsEstado)
                    .HasColumnName("ds_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.HasOne(d => d.IdPracaNavigation)
                    .WithMany(p => p.TbPracaCep)
                    .HasForeignKey(d => d.IdPraca)
                    .HasConstraintName("FK_tb_praca_cep_tb_praca");
            });

            modelBuilder.Entity<TbPrincipioAtivo>(entity =>
            {
                entity.HasKey(e => e.IdPrincipioAtivo);

                entity.ToTable("tb_principio_ativo");

                entity.Property(e => e.IdPrincipioAtivo).HasColumnName("id_principio_ativo");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DsPrincipioAtivo)
                    .HasColumnName("ds_principio_ativo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdPrincipioAtivoVannon).HasColumnName("id_principio_ativo_vannon");
            });

            modelBuilder.Entity<TbProduto>(entity =>
            {
                entity.HasKey(e => e.IdProduto);

                entity.ToTable("tb_produto");

                entity.HasIndex(e => new { e.IdProduto, e.IdMarca })
                    .HasName("ix_produto_marca");

                entity.HasIndex(e => new { e.IdProduto, e.NmProduto })
                    .HasName("ix_produto_nm_produto");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DsArquivoBula)
                    .HasColumnName("ds_arquivo_bula")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsCurvaAbc)
                    .HasColumnName("ds_curva_abc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsDescricaoCurta)
                    .HasColumnName("ds_descricao_curta")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsPalavraChave)
                    .HasColumnName("ds_palavra_chave")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DsUrlVideo)
                    .HasColumnName("ds_url_video")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLancamentoFinal)
                    .HasColumnName("dt_lancamento_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtLancamentoInicial)
                    .HasColumnName("dt_lancamento_inicial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtPreVenda)
                    .HasColumnName("dt_pre_venda")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlLancamento).HasColumnName("fl_lancamento");

                entity.Property(e => e.FlPerfil)
                    .HasColumnName("fl_perfil")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FlPreVenda).HasColumnName("fl_pre_venda");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.Property(e => e.IdProdutoControle).HasColumnName("id_produto_controle");

                entity.Property(e => e.IdProdutoFamilia).HasColumnName("id_produto_familia");

                entity.Property(e => e.IdProdutoSap)
                    .HasColumnName("id_produto_sap")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdProdutoTipo).HasColumnName("id_produto_tipo");

                entity.Property(e => e.IdProdutoVannon).HasColumnName("id_produto_vannon");

                entity.Property(e => e.NmProduto)
                    .HasColumnName("nm_produto")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NuClick).HasColumnName("nu_click");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.TbProduto)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_produto_tb_marca");

                entity.HasOne(d => d.IdProdutoControleNavigation)
                    .WithMany(p => p.TbProduto)
                    .HasForeignKey(d => d.IdProdutoControle)
                    .HasConstraintName("FK_tb_produto_tb_produto_controle");

                entity.HasOne(d => d.IdProdutoFamiliaNavigation)
                    .WithMany(p => p.TbProduto)
                    .HasForeignKey(d => d.IdProdutoFamilia)
                    .HasConstraintName("FK_tb_produto_tb_produto_familia");

                entity.HasOne(d => d.IdProdutoTipoNavigation)
                    .WithMany(p => p.TbProduto)
                    .HasForeignKey(d => d.IdProdutoTipo)
                    .HasConstraintName("FK_tb_produto_tb_produto_tipo");
            });

            modelBuilder.Entity<TbProdutoAtrStagging>(entity =>
            {
                entity.HasKey(e => e.IdProdutoAtrStagging)
                    .HasName("PK_tb_atr_stagging");

                entity.ToTable("tb_produto_atr_stagging");

                entity.Property(e => e.IdProdutoAtrStagging).HasColumnName("id_produto_atr_stagging");

                entity.Property(e => e.CdBarras).HasColumnName("cd_barras");

                entity.Property(e => e.CdMs).HasColumnName("cd_ms");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.NmProduto).HasColumnName("nm_produto");

                entity.Property(e => e.NmProdutoSku).HasColumnName("nm_produto_sku");

                entity.Property(e => e.NuAltura).HasColumnName("nu_altura");

                entity.Property(e => e.NuLargura).HasColumnName("nu_largura");

                entity.Property(e => e.NuPeso)
                    .HasColumnName("nu_peso")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NuProfundidade).HasColumnName("nu_profundidade");
            });

            modelBuilder.Entity<TbProdutoAvaliacao>(entity =>
            {
                entity.HasKey(e => e.IdProdutoAvaliacao);

                entity.ToTable("tb_produto_avaliacao");

                entity.Property(e => e.IdProdutoAvaliacao).HasColumnName("id_produto_avaliacao");

                entity.Property(e => e.DsComentario)
                    .IsRequired()
                    .HasColumnName("ds_comentario")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.DsTitulo)
                    .IsRequired()
                    .HasColumnName("ds_titulo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtAprovacao)
                    .HasColumnName("dt_aprovacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlStatus)
                    .HasColumnName("fl_status")
                    .HasComment("0 -Pendente / 1 - Aprovado / 2- Reprovado");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.NuAvaliacao).HasColumnName("nu_avaliacao");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbProdutoAvaliacao)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_tb_produto_avaliacao_tb_cliente");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoAvaliacao)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_produto_avaliacao_tb_produto");
            });

            modelBuilder.Entity<TbProdutoCategoria>(entity =>
            {
                entity.HasKey(e => e.IdProdutoCategoria);

                entity.ToTable("tb_produto_categoria");

                entity.HasIndex(e => new { e.IdProduto, e.FlPrincipal })
                    .HasName("ix_produto_categoria_id_produto_fl_principal");

                entity.HasIndex(e => new { e.IdProduto, e.IdSecao })
                    .HasName("ix_produto_categoria_id_secao");

                entity.Property(e => e.IdProdutoCategoria).HasColumnName("id_produto_categoria");

                entity.Property(e => e.FlPrincipal).HasColumnName("fl_principal");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdSecao).HasColumnName("id_secao");

                entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TbProdutoCategoriaIdCategoriaNavigation)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_tb_produto_categoria_tb_categoria2");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.TbProdutoCategoriaIdDepartamentoNavigation)
                    .HasForeignKey(d => d.IdDepartamento)
                    .HasConstraintName("FK_tb_produto_categoria_tb_categoria");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoCategoria)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_produto_categoria_tb_produto");

                entity.HasOne(d => d.IdSecaoNavigation)
                    .WithMany(p => p.TbProdutoCategoriaIdSecaoNavigation)
                    .HasForeignKey(d => d.IdSecao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_produto_categoria_tb_categoria1");

                entity.HasOne(d => d.IdSubcategoriaNavigation)
                    .WithMany(p => p.TbProdutoCategoriaIdSubcategoriaNavigation)
                    .HasForeignKey(d => d.IdSubcategoria)
                    .HasConstraintName("FK_tb_produto_categoria_tb_categoria3");
            });

            modelBuilder.Entity<TbProdutoControle>(entity =>
            {
                entity.HasKey(e => e.IdProdutoControle);

                entity.ToTable("tb_produto_controle");

                entity.Property(e => e.IdProdutoControle).HasColumnName("id_produto_controle");

                entity.Property(e => e.DsProdutoControle)
                    .IsRequired()
                    .HasColumnName("ds_produto_controle")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbProdutoControleStagging>(entity =>
            {
                entity.HasKey(e => e.IdProdutoControleStagging);

                entity.ToTable("tb_produto_controle_stagging");

                entity.Property(e => e.IdProdutoControleStagging).HasColumnName("id_produto_controle_stagging");

                entity.Property(e => e.CdBarras).HasColumnName("cd_barras");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdProdutoControle).HasColumnName("id_produto_controle");
            });

            modelBuilder.Entity<TbProdutoDescricao>(entity =>
            {
                entity.HasKey(e => e.IdProdutoDescricao);

                entity.ToTable("tb_produto_descricao");

                entity.Property(e => e.IdProdutoDescricao).HasColumnName("id_produto_descricao");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.FlTxProdutoTipo).HasColumnName("fl_tx_produto_tipo");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdProdutoDescricaoTipo).HasColumnName("id_produto_descricao_tipo");

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.Property(e => e.TxProdutoDescricao)
                    .IsRequired()
                    .HasColumnName("tx_produto_descricao")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoDescricao)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_produto_descricao_tb_produto");

                entity.HasOne(d => d.IdProdutoDescricaoTipoNavigation)
                    .WithMany(p => p.TbProdutoDescricao)
                    .HasForeignKey(d => d.IdProdutoDescricaoTipo)
                    .HasConstraintName("FK_tb_produto_descricao_tb_produto_descricao_tipo");
            });

            modelBuilder.Entity<TbProdutoDescricaoTipo>(entity =>
            {
                entity.HasKey(e => e.IdProdutoDescricaoTipo);

                entity.ToTable("tb_produto_descricao_tipo");

                entity.Property(e => e.IdProdutoDescricaoTipo).HasColumnName("id_produto_descricao_tipo");

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.NmProdutoDescricaoTipo)
                    .IsRequired()
                    .HasColumnName("nm_produto_descricao_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbProdutoEtiqueta>(entity =>
            {
                entity.HasKey(e => e.IdProdutoEtiqueta);

                entity.ToTable("tb_produto_etiqueta");

                entity.Property(e => e.IdProdutoEtiqueta).HasColumnName("id_produto_etiqueta");

                entity.Property(e => e.DtFinal)
                    .HasColumnName("dt_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtInicial)
                    .HasColumnName("dt_inicial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdEtiqueta).HasColumnName("id_etiqueta");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.HasOne(d => d.IdEtiquetaNavigation)
                    .WithMany(p => p.TbProdutoEtiqueta)
                    .HasForeignKey(d => d.IdEtiqueta)
                    .HasConstraintName("FK_tb_produto_etiqueta_tb_etiqueta");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoEtiqueta)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_produto_etiqueta_tb_produto");

                entity.HasOne(d => d.IdPromocaoNavigation)
                    .WithMany(p => p.TbProdutoEtiqueta)
                    .HasForeignKey(d => d.IdPromocao)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_produto_etiqueta_tb_promocao");
            });

            modelBuilder.Entity<TbProdutoFamilia>(entity =>
            {
                entity.HasKey(e => e.IdProdutoFamilia);

                entity.ToTable("tb_produto_familia");

                entity.Property(e => e.IdProdutoFamilia).HasColumnName("id_produto_familia");

                entity.Property(e => e.DsImagem)
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsProdutoFamilia)
                    .IsRequired()
                    .HasColumnName("ds_produto_familia")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbProdutoFamiliaModalidade>(entity =>
            {
                entity.HasKey(e => e.IdProdutoFamiliaModalidade);

                entity.ToTable("tb_produto_familia_modalidade");

                entity.HasIndex(e => e.IdProdutoFamilia)
                    .HasName("IDX_PRODUTO_FAMILIA");

                entity.Property(e => e.IdProdutoFamiliaModalidade).HasColumnName("id_produto_familia_modalidade");

                entity.Property(e => e.DsMensagem)
                    .HasColumnName("ds_mensagem")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IdModalidadeEntrega).HasColumnName("id_modalidade_entrega");

                entity.Property(e => e.IdProdutoFamilia).HasColumnName("id_produto_familia");

                entity.HasOne(d => d.IdModalidadeEntregaNavigation)
                    .WithMany(p => p.TbProdutoFamiliaModalidade)
                    .HasForeignKey(d => d.IdModalidadeEntrega)
                    .HasConstraintName("FK_tb_produto_familia_modalidade_tb_modalidade_entrega");

                entity.HasOne(d => d.IdProdutoFamiliaNavigation)
                    .WithMany(p => p.TbProdutoFamiliaModalidade)
                    .HasForeignKey(d => d.IdProdutoFamilia)
                    .HasConstraintName("FK_tb_produto_familia_modalidade_tb_produto_familia");
            });

            modelBuilder.Entity<TbProdutoFamiliaStagging>(entity =>
            {
                entity.HasKey(e => e.IdProdutoFamiliaStagging);

                entity.ToTable("tb_produto_familia_stagging");

                entity.Property(e => e.IdProdutoFamiliaStagging).HasColumnName("id_produto_familia_stagging");

                entity.Property(e => e.CdBarras).HasColumnName("cd_barras");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdProdutoFamilia).HasColumnName("id_produto_familia");
            });

            modelBuilder.Entity<TbProdutoKit>(entity =>
            {
                entity.HasKey(e => e.IdProdutoKit);

                entity.ToTable("tb_produto_kit");

                entity.Property(e => e.IdProdutoKit).HasColumnName("id_produto_kit");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.NuQuantidade).HasColumnName("nu_quantidade");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoKit)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_produto_kit_tb_produto");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbProdutoKit)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_produto_kit_tb_produto_sku");
            });

            modelBuilder.Entity<TbProdutoLancamento>(entity =>
            {
                entity.HasKey(e => e.IdProdutoLancamento);

                entity.ToTable("tb_produto_lancamento");

                entity.Property(e => e.IdProdutoLancamento).HasColumnName("id_produto_lancamento");

                entity.Property(e => e.DtFinal)
                    .HasColumnName("dt_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtInicial)
                    .HasColumnName("dt_inicial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoLancamento)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_produto_lancamento_tb_produto");
            });

            modelBuilder.Entity<TbProdutoLog>(entity =>
            {
                entity.HasKey(e => e.IdProdutoLog);

                entity.ToTable("tb_produto_log");

                entity.Property(e => e.IdProdutoLog)
                    .HasColumnName("id_produto_log")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsAcao)
                    .IsRequired()
                    .HasColumnName("ds_acao")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DtAlteracao)
                    .HasColumnName("dt_alteracao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoLog)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_produto_log_tb_produto");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TbProdutoLog)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_tb_produto_log_tb_usuario");
            });

            modelBuilder.Entity<TbProdutoPrincipioAtivo>(entity =>
            {
                entity.HasKey(e => e.IdProdutoPrincipioAtivo);

                entity.ToTable("tb_produto_principio_ativo");

                entity.Property(e => e.IdProdutoPrincipioAtivo).HasColumnName("id_produto_principio_ativo");

                entity.Property(e => e.FlPrincipal).HasColumnName("fl_principal");

                entity.Property(e => e.IdPrincipioAtivo).HasColumnName("id_principio_ativo");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.HasOne(d => d.IdPrincipioAtivoNavigation)
                    .WithMany(p => p.TbProdutoPrincipioAtivo)
                    .HasForeignKey(d => d.IdPrincipioAtivo)
                    .HasConstraintName("FK_tb_produto_principio_ativo_tb_principio_ativo");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoPrincipioAtivo)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_produto_principio_ativo_tb_produto");
            });

            modelBuilder.Entity<TbProdutoPrincipioAtivoBkp20191018>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_produto_principio_ativo_bkp_20191018");

                entity.Property(e => e.FlPrincipal).HasColumnName("fl_principal");

                entity.Property(e => e.IdPrincipioAtivo).HasColumnName("id_principio_ativo");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdProdutoPrincipioAtivo)
                    .HasColumnName("id_produto_principio_ativo")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TbProdutoSeo>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSeo);

                entity.ToTable("tb_produto_seo");

                entity.HasIndex(e => new { e.DsDescription, e.DsKeywords, e.DsTitle, e.IdProduto })
                    .HasName("idx_produto_seo");

                entity.Property(e => e.IdProdutoSeo).HasColumnName("id_produto_seo");

                entity.Property(e => e.DsDescription)
                    .HasColumnName("ds_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsKeywords)
                    .HasColumnName("ds_keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsTitle)
                    .HasColumnName("ds_title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoSeo)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_produto_seo_tb_produto");
            });

            modelBuilder.Entity<ProdutoSku>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSku);

                entity.ToTable("tb_produto_sku");

                entity.HasIndex(e => new { e.IdProduto, e.FlBrinde })
                    .HasName("IX_produto");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.CdBarras)
                    .HasColumnName("cd_barras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CdMs)
                    .HasColumnName("cd_ms")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlBrinde).HasColumnName("fl_brinde");

                entity.Property(e => e.FlExibirIndividualmente).HasColumnName("fl_exibir_individualmente");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdProdutoSap)
                    .HasColumnName("id_produto_sap")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NmProdutoSku)
                    .HasColumnName("nm_produto_sku")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NuAltura).HasColumnName("nu_altura");

                entity.Property(e => e.NuLargura).HasColumnName("nu_largura");

                entity.Property(e => e.NuPeso)
                    .HasColumnName("nu_peso")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NuProfundidade).HasColumnName("nu_profundidade");

                entity.Property(e => e.PcDescontoAtendente)
                    .HasColumnName("pc_desconto_atendente")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoSku)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_produto_sku_tb_produto");
            });

            modelBuilder.Entity<TbProdutoSkuAviseMe>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSkuAviseMe);

                entity.ToTable("tb_produto_sku_avise_me");

                entity.Property(e => e.IdProdutoSkuAviseMe).HasColumnName("id_produto_sku_avise_me");

                entity.Property(e => e.DsEmail)
                    .IsRequired()
                    .HasColumnName("ds_email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsNome)
                    .IsRequired()
                    .HasColumnName("ds_nome")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbProdutoSkuAviseMe)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_produto_sku_avise_me_tb_produto_sku");
            });

            modelBuilder.Entity<TbProdutoSkuEspecificacao>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSkuEspecificacao);

                entity.ToTable("tb_produto_sku_especificacao");

                entity.Property(e => e.IdProdutoSkuEspecificacao).HasColumnName("id_produto_sku_especificacao");

                entity.Property(e => e.IdEspecificacao1).HasColumnName("id_especificacao_1");

                entity.Property(e => e.IdEspecificacao2).HasColumnName("id_especificacao_2");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.HasOne(d => d.IdEspecificacao1Navigation)
                    .WithMany(p => p.TbProdutoSkuEspecificacaoIdEspecificacao1Navigation)
                    .HasForeignKey(d => d.IdEspecificacao1)
                    .HasConstraintName("FK_tb_produto_sku_especificacao_tb_especificacao");

                entity.HasOne(d => d.IdEspecificacao2Navigation)
                    .WithMany(p => p.TbProdutoSkuEspecificacaoIdEspecificacao2Navigation)
                    .HasForeignKey(d => d.IdEspecificacao2)
                    .HasConstraintName("FK_tb_produto_sku_especificacao_tb_especificacao1");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbProdutoSkuEspecificacao)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_produto_sku_especificacao_tb_produto_sku");
            });

            modelBuilder.Entity<TbProdutoSkuFiltro>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSkuFiltro);

                entity.ToTable("tb_produto_sku_filtro");

                entity.Property(e => e.IdProdutoSkuFiltro).HasColumnName("id_produto_sku_filtro");

                entity.Property(e => e.IdFiltro).HasColumnName("id_filtro");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.HasOne(d => d.IdFiltroNavigation)
                    .WithMany(p => p.TbProdutoSkuFiltro)
                    .HasForeignKey(d => d.IdFiltro)
                    .HasConstraintName("FK_tb_produto_sku_filtro_tb_filtro");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbProdutoSkuFiltro)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_produto_sku_filtro_tb_produto_sku");
            });

            modelBuilder.Entity<TbProdutoSkuGenerico>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSkuGenerico);

                entity.ToTable("tb_produto_sku_generico");

                entity.Property(e => e.IdProdutoSkuGenerico).HasColumnName("id_produto_sku_generico");

                entity.Property(e => e.IdGenerico).HasColumnName("id_generico");

                entity.Property(e => e.IdMedicamento).HasColumnName("id_medicamento");

                entity.HasOne(d => d.IdGenericoNavigation)
                    .WithMany(p => p.TbProdutoSkuGenericoIdGenericoNavigation)
                    .HasForeignKey(d => d.IdGenerico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_produto_sku_generico_tb_produto_sku1");

                entity.HasOne(d => d.IdMedicamentoNavigation)
                    .WithMany(p => p.TbProdutoSkuGenericoIdMedicamentoNavigation)
                    .HasForeignKey(d => d.IdMedicamento)
                    .HasConstraintName("FK_tb_produto_sku_generico_tb_produto_sku");
            });

            modelBuilder.Entity<TbProdutoSkuImagem>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSkuImagem);

                entity.ToTable("tb_produto_sku_imagem");

                entity.HasIndex(e => new { e.DsImagem, e.IdProdutoSku, e.FlStatus, e.FlPrincipal })
                    .HasName("idx_sku_imagem");

                entity.Property(e => e.IdProdutoSkuImagem).HasColumnName("id_produto_sku_imagem");

                entity.Property(e => e.AltImg)
                    .HasColumnName("alt_img")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsImagem)
                    .IsRequired()
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FlPrincipal).HasColumnName("fl_principal");

                entity.Property(e => e.FlSecundaria).HasColumnName("fl_secundaria");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbProdutoSkuImagem)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_produto_sku_imagem_tb_produto_sku");
            });

            modelBuilder.Entity<TbProdutoSkuOutrasOrigens>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_produto_sku_outras_origens");

                entity.Property(e => e.CdBarras)
                    .HasColumnName("cd_barras")
                    .IsUnicode(false);

                entity.Property(e => e.CdExterno)
                    .HasColumnName("cd_externo")
                    .IsUnicode(false);

                entity.Property(e => e.CdMs)
                    .HasColumnName("cd_ms")
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlBrinde).HasColumnName("fl_brinde");

                entity.Property(e => e.FlExibirIndividualmente).HasColumnName("fl_exibir_individualmente");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.NmProdutoSku)
                    .HasColumnName("nm_produto_sku")
                    .IsUnicode(false);

                entity.Property(e => e.NuAltura).HasColumnName("nu_altura");

                entity.Property(e => e.NuLargura).HasColumnName("nu_largura");

                entity.Property(e => e.NuPeso)
                    .HasColumnName("nu_peso")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.NuProfundidade).HasColumnName("nu_profundidade");

                entity.Property(e => e.Origem)
                    .IsRequired()
                    .HasColumnName("origem")
                    .IsUnicode(false);

                entity.Property(e => e.PcDescontoAtendente)
                    .HasColumnName("pc_desconto_atendente")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TbProdutoSkuPraca>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSkuPraca);

                entity.ToTable("tb_produto_sku_praca");

                entity.HasIndex(e => new { e.VlProdutoSkuPor, e.NuEstoque, e.IdProdutoSku, e.IdPraca, e.FlStatus })
                    .HasName("IX_produto_sku_praca");

                entity.HasIndex(e => new { e.DtFimPromocao, e.DtInicioPromocao, e.FlPromocao, e.NuEstoqueMinimo, e.VlProdutoSkuDe, e.VlProdutoSkuPromocaoDe, e.VlProdutoSkuPromocaoPor, e.VlProdutoSkuPor, e.NuEstoque, e.IdProdutoSku, e.IdPraca, e.FlStatus })
                    .HasName("idx_sku_praca");

                entity.Property(e => e.IdProdutoSkuPraca).HasColumnName("id_produto_sku_praca");

                entity.Property(e => e.DtFimPromocao)
                    .HasColumnName("dt_fim_promocao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtInicioPromocao)
                    .HasColumnName("dt_inicio_promocao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlPromocao).HasColumnName("fl_promocao");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.NuEstoque).HasColumnName("nu_estoque");

                entity.Property(e => e.NuEstoqueMinimo).HasColumnName("nu_estoque_minimo");

                entity.Property(e => e.NuPrazoPostagem).HasColumnName("nu_prazo_postagem");

                entity.Property(e => e.PcDesconto)
                    .HasColumnName("pc_desconto")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlEmbalagemPresente)
                    .HasColumnName("vl_embalagem_presente")
                    .HasColumnType("money");

                entity.Property(e => e.VlProdutoSkuDe)
                    .HasColumnName("vl_produto_sku_de")
                    .HasColumnType("money");

                entity.Property(e => e.VlProdutoSkuPor)
                    .HasColumnName("vl_produto_sku_por")
                    .HasColumnType("money");

                entity.Property(e => e.VlProdutoSkuPromocaoDe)
                    .HasColumnName("vl_produto_sku_promocao_de")
                    .HasColumnType("money");

                entity.Property(e => e.VlProdutoSkuPromocaoPor)
                    .HasColumnName("vl_produto_sku_promocao_por")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdPracaNavigation)
                    .WithMany(p => p.TbProdutoSkuPraca)
                    .HasForeignKey(d => d.IdPraca)
                    .HasConstraintName("FK_tb_produto_sku_praca_tb_praca");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbProdutoSkuPraca)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_produto_sku_praca_tb_produto_sku");
            });

            modelBuilder.Entity<TbProdutoSkuRelacionado>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSkuRelacionado);

                entity.ToTable("tb_produto_sku_relacionado");

                entity.HasIndex(e => new { e.IdProdutoSku, e.IdProdutoSkuRelacao })
                    .HasName("idx_relacionado");

                entity.Property(e => e.IdProdutoSkuRelacionado).HasColumnName("id_produto_sku_relacionado");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.IdProdutoSkuRelacao).HasColumnName("id_produto_sku_relacao");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbProdutoSkuRelacionadoIdProdutoSkuNavigation)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_produto_sku_relacionado_tb_produto_sku");

                entity.HasOne(d => d.IdProdutoSkuRelacaoNavigation)
                    .WithMany(p => p.TbProdutoSkuRelacionadoIdProdutoSkuRelacaoNavigation)
                    .HasForeignKey(d => d.IdProdutoSkuRelacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_produto_sku_relacionado_tb_produto_sku1");
            });

            modelBuilder.Entity<TbProdutoSkuSemImagens>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_produto_sku_sem_imagens");

                entity.HasIndex(e => e.SkuVfarma)
                    .HasName("IX_tb_produto_sku_sem_imagens")
                    .IsUnique();

                entity.Property(e => e.CdBarras)
                    .HasColumnName("cd_barras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DsImagem)
                    .IsRequired()
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FlIntegrado).HasColumnName("fl_integrado");

                entity.Property(e => e.FlPrincipal).HasColumnName("fl_principal");

                entity.Property(e => e.FlSecundaria).HasColumnName("fl_secundaria");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.Origem)
                    .IsRequired()
                    .HasColumnName("origem")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SkuVfarma).HasColumnName("sku_vfarma");
            });

            modelBuilder.Entity<TbProdutoSkuVendaCasada>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSkuVendaCasada);

                entity.ToTable("tb_produto_sku_venda_casada");

                entity.Property(e => e.IdProdutoSkuVendaCasada).HasColumnName("id_produto_sku_venda_casada");

                entity.Property(e => e.DtFim)
                    .HasColumnName("dt_fim")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtInicio)
                    .HasColumnName("dt_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlTipoDesconto).HasColumnName("fl_tipo_desconto");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.IdProdutoSkuCasado).HasColumnName("id_produto_sku_casado");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbProdutoSkuVendaCasadaIdProdutoSkuNavigation)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_produto_sku_venda_casada_tb_produto_sku");

                entity.HasOne(d => d.IdProdutoSkuCasadoNavigation)
                    .WithMany(p => p.TbProdutoSkuVendaCasadaIdProdutoSkuCasadoNavigation)
                    .HasForeignKey(d => d.IdProdutoSkuCasado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_produto_sku_venda_casada_tb_produto_sku1");
            });

            modelBuilder.Entity<TbProdutoTipo>(entity =>
            {
                entity.HasKey(e => e.IdProdutoTipo);

                entity.ToTable("tb_produto_tipo");

                entity.Property(e => e.IdProdutoTipo).HasColumnName("id_produto_tipo");

                entity.Property(e => e.DsProdutoTipo)
                    .IsRequired()
                    .HasColumnName("ds_produto_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbProdutoTipoStagging>(entity =>
            {
                entity.HasKey(e => e.IdProdutoFamiliaStagging);

                entity.ToTable("tb_produto_tipo_stagging");

                entity.Property(e => e.IdProdutoFamiliaStagging).HasColumnName("id_produto_familia_stagging");

                entity.Property(e => e.CdBarras).HasColumnName("cd_barras");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdProdutoTipo).HasColumnName("id_produto_tipo");
            });

            modelBuilder.Entity<TbProdutoVideo>(entity =>
            {
                entity.HasKey(e => e.IdProdutoVideo);

                entity.ToTable("tb_produto_video");

                entity.Property(e => e.IdProdutoVideo).HasColumnName("id_produto_video");

                entity.Property(e => e.DsUrl)
                    .IsRequired()
                    .HasColumnName("ds_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.NmVideo)
                    .HasColumnName("nm_video")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxVideo)
                    .HasColumnName("tx_video")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutoVideo)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_produto_video_tb_produto");
            });

            modelBuilder.Entity<TbProdutosAtualizados>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_produtos_atualizados");

                entity.Property(e => e.CdBarras)
                    .HasColumnName("cd_barras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fonte)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            });

            modelBuilder.Entity<TbPrograma>(entity =>
            {
                entity.HasKey(e => e.IdPrograma);

                entity.ToTable("tb_programa");

                entity.HasIndex(e => new { e.IdPrograma, e.NmPrograma, e.DsImagem, e.CdPrograma })
                    .HasName("idx_programa");

                entity.Property(e => e.IdPrograma).HasColumnName("id_programa");

                entity.Property(e => e.CdPrograma)
                    .IsRequired()
                    .HasColumnName("cd_programa")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DsImagem)
                    .IsRequired()
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(155)
                    .IsUnicode(false);

                entity.Property(e => e.NmPrograma)
                    .IsRequired()
                    .HasColumnName("nm_programa")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbProgramaProduto>(entity =>
            {
                entity.HasKey(e => e.IdProgramaProduto);

                entity.ToTable("tb_programa_produto");

                entity.HasIndex(e => new { e.IdPrograma, e.IdProdutoSku })
                    .HasName("idx_produto_programa");

                entity.Property(e => e.IdProgramaProduto).HasColumnName("id_programa_produto");

                entity.Property(e => e.DsPromocao)
                    .IsRequired()
                    .HasColumnName("ds_promocao")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnName("dt_atualizacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.IdPrograma).HasColumnName("id_programa");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbProgramaProduto)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_programa_produto_tb_produto_sku");

                entity.HasOne(d => d.IdProgramaNavigation)
                    .WithMany(p => p.TbProgramaProduto)
                    .HasForeignKey(d => d.IdPrograma)
                    .HasConstraintName("FK_tb_programa_produto_tb_programa");
            });

            modelBuilder.Entity<TbPromocao>(entity =>
            {
                entity.HasKey(e => e.IdPromocao);

                entity.ToTable("tb_promocao");

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.Property(e => e.DtFinal)
                    .HasColumnName("dt_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtInicial)
                    .HasColumnName("dt_inicial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlGeraCupomAutomatico).HasColumnName("fl_gera_cupom_automatico");

                entity.Property(e => e.FlStatus)
                    .HasColumnName("fl_status")
                    .HasComment("0 - Inativo /1 - Ativo");

                entity.Property(e => e.IdEtiqueta).HasColumnName("id_etiqueta");

                entity.Property(e => e.IdProdutoBrinde).HasColumnName("id_produto_brinde");

                entity.Property(e => e.IdPromocaoAcao).HasColumnName("id_promocao_acao");

                entity.Property(e => e.IdPromocaoBeneficio).HasColumnName("id_promocao_beneficio");

                entity.Property(e => e.IdPromocaoTipo).HasColumnName("id_promocao_tipo");

                entity.Property(e => e.NmPromocao)
                    .IsRequired()
                    .HasColumnName("nm_promocao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuPesoMaximo)
                    .HasColumnName("nu_peso_maximo")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlMinimoPedido)
                    .HasColumnName("vl_minimo_pedido")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdEtiquetaNavigation)
                    .WithMany(p => p.TbPromocao)
                    .HasForeignKey(d => d.IdEtiqueta)
                    .HasConstraintName("FK_tb_promocao_tb_etiqueta");

                entity.HasOne(d => d.IdPromocaoAcaoNavigation)
                    .WithMany(p => p.TbPromocao)
                    .HasForeignKey(d => d.IdPromocaoAcao)
                    .HasConstraintName("FK_tb_promocao_tb_promocao_acao");

                entity.HasOne(d => d.IdPromocaoBeneficioNavigation)
                    .WithMany(p => p.TbPromocao)
                    .HasForeignKey(d => d.IdPromocaoBeneficio)
                    .HasConstraintName("FK_tb_promocao_tb_promocao_beneficio");

                entity.HasOne(d => d.IdPromocaoTipoNavigation)
                    .WithMany(p => p.TbPromocao)
                    .HasForeignKey(d => d.IdPromocaoTipo)
                    .HasConstraintName("FK_tb_promocao_tb_promocao_tipo");
            });

            modelBuilder.Entity<TbPromocaoAcao>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoAcao);

                entity.ToTable("tb_promocao_acao");

                entity.Property(e => e.IdPromocaoAcao).HasColumnName("id_promocao_acao");

                entity.Property(e => e.NmPromocaoAcao)
                    .IsRequired()
                    .HasColumnName("nm_promocao_acao")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPromocaoBeneficio>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoBeneficio);

                entity.ToTable("tb_promocao_beneficio");

                entity.Property(e => e.IdPromocaoBeneficio).HasColumnName("id_promocao_beneficio");

                entity.Property(e => e.NmPromocaoBeneficio)
                    .IsRequired()
                    .HasColumnName("nm_promocao_beneficio")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPromocaoCategoria>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoCategoria);

                entity.ToTable("tb_promocao_categoria");

                entity.Property(e => e.IdPromocaoCategoria).HasColumnName("id_promocao_categoria");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.Property(e => e.IdSecao).HasColumnName("id_secao");

                entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TbPromocaoCategoriaIdCategoriaNavigation)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_promocao_categoria_tb_categoria");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.TbPromocaoCategoriaIdDepartamentoNavigation)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_promocao_categoria_tb_categoria1");

                entity.HasOne(d => d.IdPromocaoNavigation)
                    .WithMany(p => p.TbPromocaoCategoria)
                    .HasForeignKey(d => d.IdPromocao)
                    .HasConstraintName("FK_tb_promocao_categoria_tb_promocao");

                entity.HasOne(d => d.IdSecaoNavigation)
                    .WithMany(p => p.TbPromocaoCategoriaIdSecaoNavigation)
                    .HasForeignKey(d => d.IdSecao)
                    .HasConstraintName("FK_tb_promocao_categoria_tb_categoria2");

                entity.HasOne(d => d.IdSubcategoriaNavigation)
                    .WithMany(p => p.TbPromocaoCategoriaIdSubcategoriaNavigation)
                    .HasForeignKey(d => d.IdSubcategoria)
                    .HasConstraintName("FK_tb_promocao_categoria_tb_categoria3");
            });

            modelBuilder.Entity<TbPromocaoCep>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoCep);

                entity.ToTable("tb_promocao_cep");

                entity.Property(e => e.IdPromocaoCep).HasColumnName("id_promocao_cep");

                entity.Property(e => e.DsBairro)
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsCepFinal)
                    .IsRequired()
                    .HasColumnName("ds_cep_final")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsCepInicial)
                    .IsRequired()
                    .HasColumnName("ds_cep_inicial")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsCidade)
                    .HasColumnName("ds_cidade")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsEstado)
                    .HasColumnName("ds_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.HasOne(d => d.IdPromocaoNavigation)
                    .WithMany(p => p.TbPromocaoCep)
                    .HasForeignKey(d => d.IdPromocao)
                    .HasConstraintName("FK_tb_promocao_cep_tb_promocao");
            });

            modelBuilder.Entity<TbPromocaoCliente>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoCliente);

                entity.ToTable("tb_promocao_cliente");

                entity.Property(e => e.IdPromocaoCliente).HasColumnName("id_promocao_cliente");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPromocaoCliente)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_tb_promocao_cliente_tb_cliente");

                entity.HasOne(d => d.IdPromocaoNavigation)
                    .WithMany(p => p.TbPromocaoCliente)
                    .HasForeignKey(d => d.IdPromocao)
                    .HasConstraintName("FK_tb_promocao_cliente_tb_promocao");
            });

            modelBuilder.Entity<TbPromocaoCupom>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoCupom);

                entity.ToTable("tb_promocao_cupom");

                entity.Property(e => e.IdPromocaoCupom).HasColumnName("id_promocao_cupom");

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtValidade)
                    .HasColumnName("dt_validade")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlUnicoCliente).HasColumnName("fl_unico_cliente");

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.Property(e => e.NuCupom)
                    .IsRequired()
                    .HasColumnName("nu_cupom")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NuQtdUtiliza)
                    .HasColumnName("nu_qtd_utiliza")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPromocaoNavigation)
                    .WithMany(p => p.TbPromocaoCupom)
                    .HasForeignKey(d => d.IdPromocao)
                    .HasConstraintName("FK_tb_promocao_cupom_tb_promocao");
            });

            modelBuilder.Entity<TbPromocaoCupomUtilizado>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoCupomUtilizado);

                entity.ToTable("tb_promocao_cupom_utilizado");

                entity.Property(e => e.IdPromocaoCupomUtilizado).HasColumnName("id_promocao_cupom_utilizado");

                entity.Property(e => e.DtUtilizado)
                    .HasColumnName("dt_utilizado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.IdPromocaoCupom).HasColumnName("id_promocao_cupom");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPromocaoCupomUtilizado)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_promocao_cupom_utilizado_tb_cliente");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TbPromocaoCupomUtilizado)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_promocao_cupom_utilizado_tb_pedido");

                entity.HasOne(d => d.IdPromocaoCupomNavigation)
                    .WithMany(p => p.TbPromocaoCupomUtilizado)
                    .HasForeignKey(d => d.IdPromocaoCupom)
                    .HasConstraintName("FK_tb_promocao_cupom_utilizado_tb_promocao_cupom");
            });

            modelBuilder.Entity<TbPromocaoMarca>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoMarca);

                entity.ToTable("tb_promocao_marca");

                entity.Property(e => e.IdPromocaoMarca).HasColumnName("id_promocao_marca");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.TbPromocaoMarca)
                    .HasForeignKey(d => d.IdMarca)
                    .HasConstraintName("FK_tb_promocao_marca_tb_marca");

                entity.HasOne(d => d.IdPromocaoNavigation)
                    .WithMany(p => p.TbPromocaoMarca)
                    .HasForeignKey(d => d.IdPromocao)
                    .HasConstraintName("FK_tb_promocao_marca_tb_promocao");
            });

            modelBuilder.Entity<TbPromocaoModalidade>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoModalidade);

                entity.ToTable("tb_promocao_modalidade");

                entity.Property(e => e.IdPromocaoModalidade).HasColumnName("id_promocao_modalidade");

                entity.Property(e => e.IdModalidadeEntrega).HasColumnName("id_modalidade_entrega");

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.HasOne(d => d.IdModalidadeEntregaNavigation)
                    .WithMany(p => p.TbPromocaoModalidade)
                    .HasForeignKey(d => d.IdModalidadeEntrega)
                    .HasConstraintName("FK_tb_promocao_modalidade_tb_modalidade_entrega");

                entity.HasOne(d => d.IdPromocaoNavigation)
                    .WithMany(p => p.TbPromocaoModalidade)
                    .HasForeignKey(d => d.IdPromocao)
                    .HasConstraintName("FK_tb_promocao_modalidade_tb_promocao");
            });

            modelBuilder.Entity<TbPromocaoPagamento>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoPagamento);

                entity.ToTable("tb_promocao_pagamento");

                entity.Property(e => e.IdPromocaoPagamento).HasColumnName("id_promocao_pagamento");

                entity.Property(e => e.IdFormaPagamento).HasColumnName("id_forma_pagamento");

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.HasOne(d => d.IdFormaPagamentoNavigation)
                    .WithMany(p => p.TbPromocaoPagamento)
                    .HasForeignKey(d => d.IdFormaPagamento)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_promocao_pagamento_tb_forma_pagamento");

                entity.HasOne(d => d.IdPromocaoNavigation)
                    .WithMany(p => p.TbPromocaoPagamento)
                    .HasForeignKey(d => d.IdPromocao)
                    .HasConstraintName("FK_tb_promocao_pagamento_tb_promocao");
            });

            modelBuilder.Entity<TbPromocaoPraca>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoPraca);

                entity.ToTable("tb_promocao_praca");

                entity.Property(e => e.IdPromocaoPraca).HasColumnName("id_promocao_praca");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.HasOne(d => d.IdPracaNavigation)
                    .WithMany(p => p.TbPromocaoPraca)
                    .HasForeignKey(d => d.IdPraca)
                    .HasConstraintName("FK_tb_promocao_praca_tb_praca");

                entity.HasOne(d => d.IdPromocaoNavigation)
                    .WithMany(p => p.TbPromocaoPraca)
                    .HasForeignKey(d => d.IdPromocao)
                    .HasConstraintName("FK_tb_promocao_praca_tb_promocao");
            });

            modelBuilder.Entity<TbPromocaoProduto>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoProduto);

                entity.ToTable("tb_promocao_produto");

                entity.Property(e => e.IdPromocaoProduto).HasColumnName("id_promocao_produto");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.IdPromocao).HasColumnName("id_promocao");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbPromocaoProduto)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tb_promocao_produto_tb_produto");

                entity.HasOne(d => d.IdPromocaoNavigation)
                    .WithMany(p => p.TbPromocaoProduto)
                    .HasForeignKey(d => d.IdPromocao)
                    .HasConstraintName("FK_tb_promocao_produto_tb_promocao");
            });

            modelBuilder.Entity<TbPromocaoTipo>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoTipo);

                entity.ToTable("tb_promocao_tipo");

                entity.Property(e => e.IdPromocaoTipo).HasColumnName("id_promocao_tipo");

                entity.Property(e => e.NmPromocaoTipo)
                    .IsRequired()
                    .HasColumnName("nm_promocao_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPromocaoTipoAcao>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoTipoAcao);

                entity.ToTable("tb_promocao_tipo_acao");

                entity.Property(e => e.IdPromocaoTipoAcao).HasColumnName("id_promocao_tipo_acao");

                entity.Property(e => e.IdPromocaoAcao).HasColumnName("id_promocao_acao");

                entity.Property(e => e.IdPromocaoTipo).HasColumnName("id_promocao_tipo");

                entity.HasOne(d => d.IdPromocaoAcaoNavigation)
                    .WithMany(p => p.TbPromocaoTipoAcao)
                    .HasForeignKey(d => d.IdPromocaoAcao)
                    .HasConstraintName("FK_tb_promocao_tipo_acao_tb_promocao_acao");

                entity.HasOne(d => d.IdPromocaoTipoNavigation)
                    .WithMany(p => p.TbPromocaoTipoAcao)
                    .HasForeignKey(d => d.IdPromocaoTipo)
                    .HasConstraintName("FK_tb_promocao_tipo_acao_tb_promocao_tipo");
            });

            modelBuilder.Entity<TbPromocaoTipoBeneficio>(entity =>
            {
                entity.HasKey(e => e.IdPromocaoTipoBeneficio);

                entity.ToTable("tb_promocao_tipo_beneficio");

                entity.Property(e => e.IdPromocaoTipoBeneficio).HasColumnName("id_promocao_tipo_beneficio");

                entity.Property(e => e.IdPromocaoBeneficio).HasColumnName("id_promocao_beneficio");

                entity.Property(e => e.IdPromocaoTipo).HasColumnName("id_promocao_tipo");

                entity.HasOne(d => d.IdPromocaoBeneficioNavigation)
                    .WithMany(p => p.TbPromocaoTipoBeneficio)
                    .HasForeignKey(d => d.IdPromocaoBeneficio)
                    .HasConstraintName("FK_tb_promocao_tipo_beneficio_tb_promocao_beneficio");

                entity.HasOne(d => d.IdPromocaoTipoNavigation)
                    .WithMany(p => p.TbPromocaoTipoBeneficio)
                    .HasForeignKey(d => d.IdPromocaoTipo)
                    .HasConstraintName("FK_tb_promocao_tipo_beneficio_tb_promocao_tipo");
            });

            modelBuilder.Entity<TbQuemComprouComprouTambem>(entity =>
            {
                entity.HasKey(e => e.IdQuemComprouComprouTambem);

                entity.ToTable("tb_quem_comprou_comprou_tambem");

                entity.HasIndex(e => new { e.IdProdutoSku, e.NuQuantidade })
                    .HasName("idx_comprou_tambem");

                entity.Property(e => e.IdQuemComprouComprouTambem).HasColumnName("id_quem_comprou_comprou_tambem");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.IdProdutoSkuComprado).HasColumnName("id_produto_sku_comprado");

                entity.Property(e => e.NuQuantidade).HasColumnName("nu_quantidade");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbQuemComprouComprouTambem)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_quem_comprou_comprou_tambem_tb_produto_sku");
            });

            modelBuilder.Entity<TbQuemViuComprou>(entity =>
            {
                entity.HasKey(e => e.IdQuemViuComprou);

                entity.ToTable("tb_quem_viu_comprou");

                entity.HasIndex(e => new { e.IdProdutoSkuVisto, e.NuQuantidade })
                    .HasName("idx_quem_viu");

                entity.Property(e => e.IdQuemViuComprou).HasColumnName("id_quem_viu_comprou");

                entity.Property(e => e.IdProdutoSkuComprado).HasColumnName("id_produto_sku_comprado");

                entity.Property(e => e.IdProdutoSkuVisto).HasColumnName("id_produto_sku_visto");

                entity.Property(e => e.NuQuantidade).HasColumnName("nu_quantidade");

                entity.HasOne(d => d.IdProdutoSkuCompradoNavigation)
                    .WithMany(p => p.TbQuemViuComprouIdProdutoSkuCompradoNavigation)
                    .HasForeignKey(d => d.IdProdutoSkuComprado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_quem_viu_comprou_tb_produto_sku1");

                entity.HasOne(d => d.IdProdutoSkuVistoNavigation)
                    .WithMany(p => p.TbQuemViuComprouIdProdutoSkuVistoNavigation)
                    .HasForeignKey(d => d.IdProdutoSkuVisto)
                    .HasConstraintName("FK_tb_quem_viu_comprou_tb_produto_sku");
            });

            modelBuilder.Entity<TbQuemViuViuTambem>(entity =>
            {
                entity.HasKey(e => e.IdQuemViuViuTambem);

                entity.ToTable("tb_quem_viu_viu_tambem");

                entity.Property(e => e.IdQuemViuViuTambem).HasColumnName("id_quem_viu_viu_tambem");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.IdProdutoSkuVisto).HasColumnName("id_produto_sku_visto");

                entity.Property(e => e.NuQuantidade).HasColumnName("nu_quantidade");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbQuemViuViuTambemIdProdutoSkuNavigation)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_quem_viu_viu_tambem_tb_produto_sku");

                entity.HasOne(d => d.IdProdutoSkuVistoNavigation)
                    .WithMany(p => p.TbQuemViuViuTambemIdProdutoSkuVistoNavigation)
                    .HasForeignKey(d => d.IdProdutoSkuVisto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_quem_viu_viu_tambem_tb_produto_sku1");
            });

            modelBuilder.Entity<TbRedeSocial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_rede_social");

                entity.Property(e => e.DsLink)
                    .IsRequired()
                    .HasColumnName("ds_link")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsLogo)
                    .IsRequired()
                    .HasColumnName("ds_logo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdRedeSocial)
                    .HasColumnName("id_rede_social")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NmRedeSocial)
                    .IsRequired()
                    .HasColumnName("nm_rede_social")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxPlugin)
                    .HasColumnName("tx_plugin")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TbRodape>(entity =>
            {
                entity.HasKey(e => e.IdRodape);

                entity.ToTable("tb_rodape");

                entity.Property(e => e.IdRodape).HasColumnName("id_rodape");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.NmRodape)
                    .IsRequired()
                    .HasColumnName("nm_rodape")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxConteudo)
                    .IsRequired()
                    .HasColumnName("tx_conteudo")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdPracaNavigation)
                    .WithMany(p => p.TbRodape)
                    .HasForeignKey(d => d.IdPraca)
                    .HasConstraintName("FK_tb_rodape_tb_praca");
            });

            modelBuilder.Entity<TbSecApps>(entity =>
            {
                entity.HasKey(e => e.AppName)
                    .HasName("PK__tb_sec_a__A5AEA8370B0A0C34");

                entity.ToTable("tb_sec_apps");

                entity.Property(e => e.AppName)
                    .HasColumnName("app_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.AppType)
                    .HasColumnName("app_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSecGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK__tb_sec_g__D57795A00EDA9D18");

                entity.ToTable("tb_sec_groups");

                entity.HasIndex(e => e.Description)
                    .HasName("UQ__tb_sec_g__489B0D9711B709C3")
                    .IsUnique();

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSecGroupsApps>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.AppName })
                    .HasName("PK__tb_sec_g__BF2D7F2319582B8B");

                entity.ToTable("tb_sec_groups_apps");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.AppName)
                    .HasColumnName("app_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PrivAccess)
                    .HasColumnName("priv_access")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrivDelete)
                    .HasColumnName("priv_delete")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrivExport)
                    .HasColumnName("priv_export")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrivInsert)
                    .HasColumnName("priv_insert")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrivPrint)
                    .HasColumnName("priv_print")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrivUpdate)
                    .HasColumnName("priv_update")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.AppNameNavigation)
                    .WithMany(p => p.TbSecGroupsApps)
                    .HasForeignKey(d => d.AppName)
                    .HasConstraintName("FK_tb_sec_groups_apps_tb_sec_apps");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TbSecGroupsApps)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_tb_sec_groups_apps_tb_sec_groups");
            });

            modelBuilder.Entity<TbSecLogged>(entity =>
            {
                entity.HasKey(e => e.Login);

                entity.ToTable("tb_sec_logged");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DateLogin).HasColumnName("date_login");

                entity.Property(e => e.ScSession)
                    .HasColumnName("sc_session")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSecUsers>(entity =>
            {
                entity.HasKey(e => e.Login)
                    .HasName("PK_tb_sec_users_1");

                entity.ToTable("tb_sec_users");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ActivationCode)
                    .HasColumnName("activation_code")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PrivAdmin)
                    .HasColumnName("priv_admin")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pswd)
                    .IsRequired()
                    .HasColumnName("pswd")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSecUsersGroups>(entity =>
            {
                entity.HasKey(e => new { e.Login, e.GroupId })
                    .HasName("PK__tb_sec_u__656F8B2915879AA7");

                entity.ToTable("tb_sec_users_groups");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TbSecUsersGroups)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_tb_sec_users_groups_tb_sec_groups");

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany(p => p.TbSecUsersGroups)
                    .HasForeignKey(d => d.Login)
                    .HasConstraintName("FK_tb_sec_users_groups_tb_sec_users");
            });

            modelBuilder.Entity<TbServicoCorreios>(entity =>
            {
                entity.HasKey(e => e.IdServicoCorreios);

                entity.ToTable("tb_servico_correios");

                entity.Property(e => e.IdServicoCorreios).HasColumnName("id_servico_correios");

                entity.Property(e => e.CdServicoCorreios)
                    .IsRequired()
                    .HasColumnName("cd_servico_correios")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmServicoCorreios)
                    .IsRequired()
                    .HasColumnName("nm_servico_correios")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbServicoTotalexpress>(entity =>
            {
                entity.HasKey(e => e.IdServicoTotalexpress)
                    .HasName("PK__tb_servi__5DE56E4322E659CF");

                entity.ToTable("tb_servico_totalexpress");

                entity.HasComment("Serviços da Total Express");

                entity.HasIndex(e => e.IdServicoTotalexpress)
                    .HasName("tb_servico_totalexpress_id_servico_totalexpress_uindex")
                    .IsUnique();

                entity.Property(e => e.IdServicoTotalexpress).HasColumnName("id_servico_totalexpress");

                entity.Property(e => e.CdServicoTotalexpress)
                    .IsRequired()
                    .HasColumnName("cd_servico_totalexpress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NmServicoTotalexpress)
                    .IsRequired()
                    .HasColumnName("nm_servico_totalexpress")
                    .HasMaxLength(450)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSevenpdvLogon>(entity =>
            {
                entity.HasKey(e => e.IdSevenpdvLogon);

                entity.ToTable("tb_sevenpdv_logon");

                entity.Property(e => e.IdSevenpdvLogon).HasColumnName("id_sevenpdv_logon");

                entity.Property(e => e.CdSistema)
                    .IsRequired()
                    .HasColumnName("cd_sistema")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DsChaveMestre)
                    .IsRequired()
                    .HasColumnName("ds_chave_mestre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsVersaoInterface).HasColumnName("ds_versao_interface");

                entity.Property(e => e.DsVersaoTabela).HasColumnName("ds_versao_tabela");

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlAtivo).HasColumnName("fl_ativo");

                entity.Property(e => e.IdAutorizador).HasColumnName("id_autorizador");

                entity.Property(e => e.IdOrigem).HasColumnName("id_origem");
            });

            modelBuilder.Entity<TbSevenpdvSessao>(entity =>
            {
                entity.HasKey(e => e.IdSevenpdvSessao)
                    .HasName("PK__tb_seven__97CFC634153CB68D");

                entity.ToTable("tb_sevenpdv_sessao");

                entity.Property(e => e.IdSevenpdvSessao).HasColumnName("id_sevenpdv_sessao");

                entity.Property(e => e.CdRetorno)
                    .HasColumnName("cd_retorno")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CdStatusServico).HasColumnName("cd_status_servico");

                entity.Property(e => e.DsChave)
                    .HasColumnName("ds_chave")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsControleAcesso)
                    .HasColumnName("ds_controle_acesso")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DsDesvioFluxo)
                    .HasColumnName("ds_desvio_fluxo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtCentral).HasColumnName("dt_central");

                entity.Property(e => e.DtExecucao).HasColumnName("dt_execucao");

                entity.Property(e => e.IdSevenpdvLogon).HasColumnName("id_sevenpdv_logon");

                entity.Property(e => e.NuCentral).HasColumnName("nu_central");

                entity.Property(e => e.NuHorasExpiracao).HasColumnName("nu_horas_expiracao");

                entity.Property(e => e.TxInformativo)
                    .HasColumnName("tx_informativo")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdSevenpdvLogonNavigation)
                    .WithMany(p => p.TbSevenpdvSessao)
                    .HasForeignKey(d => d.IdSevenpdvLogon)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_sevenpdv_sessao_tb_sevenpdv_logon");
            });

            modelBuilder.Entity<TbSkuPracaMovimentacao>(entity =>
            {
                entity.HasKey(e => e.IdProdutoSkuPraca)
                    .HasName("PK_tb_sku_praca_movimentacao_1");

                entity.ToTable("tb_sku_praca_movimentacao");

                entity.Property(e => e.IdProdutoSkuPraca)
                    .HasColumnName("id_produto_sku_praca")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtMovimentacao)
                    .HasColumnName("dt_movimentacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NuEstoqueAtual).HasColumnName("nu_estoque_atual");

                entity.Property(e => e.NuEstoqueDisponivel).HasColumnName("nu_estoque_disponivel");

                entity.Property(e => e.NuEstoqueEntrada).HasColumnName("nu_estoque_entrada");

                entity.Property(e => e.NuEstoqueReservado).HasColumnName("nu_estoque_reservado");

                entity.Property(e => e.VlPrecoAtual)
                    .HasColumnName("vl_preco_atual")
                    .HasColumnType("money");

                entity.Property(e => e.VlPrecoNovo)
                    .HasColumnName("vl_preco_novo")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdProdutoSkuPracaNavigation)
                    .WithOne(p => p.TbSkuPracaMovimentacao)
                    .HasForeignKey<TbSkuPracaMovimentacao>(d => d.IdProdutoSkuPraca)
                    .HasConstraintName("FK_tb_sku_praca_movimentacao_tb_produto_sku_praca1");
            });

            modelBuilder.Entity<TbSli>(entity =>
            {
                entity.HasKey(e => e.IdSli);

                entity.ToTable("tb_sli");

                entity.Property(e => e.IdSli).HasColumnName("id_sli");

                entity.Property(e => e.DsFtpHost)
                    .HasColumnName("ds_ftp_host")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsSenha)
                    .HasColumnName("ds_senha")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuario)
                    .HasColumnName("ds_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSuperDesconto>(entity =>
            {
                entity.HasKey(e => e.IdSuperDesconto);

                entity.ToTable("tb_super_desconto");

                entity.HasIndex(e => new { e.DtValidadeInicial, e.DtValidadeFinal })
                    .HasName("idx_super_desconto");

                entity.Property(e => e.IdSuperDesconto).HasColumnName("id_super_desconto");

                entity.Property(e => e.DtValidadeFinal)
                    .HasColumnName("dt_validade_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtValidadeInicial)
                    .HasColumnName("dt_validade_inicial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbSuperDesconto)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .HasConstraintName("FK_tb_super_desconto_tb_produto_sku");
            });

            modelBuilder.Entity<TbUploadImagem>(entity =>
            {
                entity.HasKey(e => e.IdUploadImagem);

                entity.ToTable("tb_upload_imagem");

                entity.Property(e => e.IdUploadImagem).HasColumnName("id_upload_imagem");

                entity.Property(e => e.DsArquivo)
                    .IsRequired()
                    .HasColumnName("ds_arquivo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsUrl)
                    .IsRequired()
                    .HasColumnName("ds_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("tb_usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.DsEmail)
                    .IsRequired()
                    .HasColumnName("ds_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsLogin)
                    .IsRequired()
                    .HasColumnName("ds_login")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DsSenha)
                    .IsRequired()
                    .HasColumnName("ds_senha")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlSenhaAutomatica)
                    .IsRequired()
                    .HasColumnName("fl_senha_automatica")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.FlTipo)
                    .IsRequired()
                    .HasColumnName("fl_tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.IdUsuarioGrupo).HasColumnName("id_usuario_grupo");

                entity.Property(e => e.NmUsuario)
                    .IsRequired()
                    .HasColumnName("nm_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcComissaoTelevendas)
                    .HasColumnName("pc_comissao_televendas")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdUsuarioGrupoNavigation)
                    .WithMany(p => p.TbUsuario)
                    .HasForeignKey(d => d.IdUsuarioGrupo)
                    .HasConstraintName("FK_tb_usuario_tb_usuario_grupo");
            });

            modelBuilder.Entity<TbUsuarioGrupo>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioGrupo);

                entity.ToTable("tb_usuario_grupo");

                entity.Property(e => e.IdUsuarioGrupo).HasColumnName("id_usuario_grupo");

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.NmUsuarioGrupo)
                    .IsRequired()
                    .HasColumnName("nm_usuario_grupo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbUsuarioGrupoAcesso>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioGrupoAcesso);

                entity.ToTable("tb_usuario_grupo_acesso");

                entity.Property(e => e.IdUsuarioGrupoAcesso).HasColumnName("id_usuario_grupo_acesso");

                entity.Property(e => e.FlAltera).HasColumnName("fl_altera");

                entity.Property(e => e.FlConsulta).HasColumnName("fl_consulta");

                entity.Property(e => e.FlExclui).HasColumnName("fl_exclui");

                entity.Property(e => e.FlInclui).HasColumnName("fl_inclui");

                entity.Property(e => e.IdAcesso).HasColumnName("id_acesso");

                entity.Property(e => e.IdUsuarioGrupo).HasColumnName("id_usuario_grupo");

                entity.HasOne(d => d.IdAcessoNavigation)
                    .WithMany(p => p.TbUsuarioGrupoAcesso)
                    .HasForeignKey(d => d.IdAcesso)
                    .HasConstraintName("FK_tb_usuario_grupo_acesso_tb_acesso");

                entity.HasOne(d => d.IdUsuarioGrupoNavigation)
                    .WithMany(p => p.TbUsuarioGrupoAcesso)
                    .HasForeignKey(d => d.IdUsuarioGrupo)
                    .HasConstraintName("FK_tb_usuario_grupo_acesso_tb_usuario_grupo");
            });

            modelBuilder.Entity<TbUsuarioGrupoTelevendas>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioGrupoTelevendas);

                entity.ToTable("tb_usuario_grupo_televendas");

                entity.Property(e => e.IdUsuarioGrupoTelevendas).HasColumnName("id_usuario_grupo_televendas");

                entity.Property(e => e.NmUsuarioGrupoTelevendas)
                    .IsRequired()
                    .HasColumnName("nm_usuario_grupo_televendas")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbUsuarioIp>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioIp);

                entity.ToTable("tb_usuario_ip");

                entity.Property(e => e.IdUsuarioIp).HasColumnName("id_usuario_ip");

                entity.Property(e => e.DsIp)
                    .IsRequired()
                    .HasColumnName("ds_ip")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TbUsuarioIp)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_tb_usuario_ip_tb_usuario");
            });

            modelBuilder.Entity<TbUsuarioPraca>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioPraca);

                entity.ToTable("tb_usuario_praca");

                entity.Property(e => e.IdUsuarioPraca).HasColumnName("id_usuario_praca");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdPracaNavigation)
                    .WithMany(p => p.TbUsuarioPraca)
                    .HasForeignKey(d => d.IdPraca)
                    .HasConstraintName("FK_tb_usuario_praca_tb_praca");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TbUsuarioPraca)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_tb_usuario_praca_tb_usuario");
            });

            modelBuilder.Entity<TbUsuarioRecuperacao>(entity =>
            {
                entity.ToTable("tb_usuario_recuperacao");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cookie)
                    .HasColumnName("cookie")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbUsuarioTelevendas>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioTelevendas)
                    .HasName("PK_tb_usuario_televedas");

                entity.ToTable("tb_usuario_televendas");

                entity.Property(e => e.IdUsuarioTelevendas).HasColumnName("id_usuario_televendas");

                entity.Property(e => e.DsLogin)
                    .IsRequired()
                    .HasColumnName("ds_login")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsNome)
                    .HasColumnName("ds_nome")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DsSenha)
                    .IsRequired()
                    .HasColumnName("ds_senha")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlPrimeiroAcesso).HasColumnName("fl_primeiro_acesso");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.Property(e => e.IdUsuarioGrupoTelevendas).HasColumnName("id_usuario_grupo_televendas");

                entity.Property(e => e.PcComissao)
                    .HasColumnName("pc_comissao")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdUsuarioGrupoTelevendasNavigation)
                    .WithMany(p => p.TbUsuarioTelevendas)
                    .HasForeignKey(d => d.IdUsuarioGrupoTelevendas)
                    .HasConstraintName("FK_tb_usuario_televedas_tb_usuario_grupo_televendas");
            });

            modelBuilder.Entity<TbVitrine>(entity =>
            {
                entity.HasKey(e => e.IdVitrine);

                entity.ToTable("tb_vitrine");

                entity.HasIndex(e => new { e.NmVitrine, e.FlStatus, e.DtInicio, e.DtFinal, e.NuOrdem })
                    .HasName("idx_vitrine");

                entity.Property(e => e.IdVitrine).HasColumnName("id_vitrine");

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtFinal)
                    .HasColumnName("dt_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtInicio)
                    .HasColumnName("dt_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlStatus)
                    .HasColumnName("fl_status")
                    .HasComment("0 - Inativo / 1 - Ativo");

                entity.Property(e => e.IdVitrineTipo).HasColumnName("id_vitrine_tipo");

                entity.Property(e => e.NmVitrine)
                    .IsRequired()
                    .HasColumnName("nm_vitrine")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdVitrineTipoNavigation)
                    .WithMany(p => p.TbVitrine)
                    .HasForeignKey(d => d.IdVitrineTipo)
                    .HasConstraintName("FK_tb_vitrine_tb_vitrine_tipo");
            });

            modelBuilder.Entity<TbVitrineCategoria>(entity =>
            {
                entity.HasKey(e => e.IdVitrineCategoria);

                entity.ToTable("tb_vitrine_categoria");

                entity.HasIndex(e => new { e.IdVitrine, e.IdCategoria })
                    .HasName("idx_vitrine_categoria");

                entity.Property(e => e.IdVitrineCategoria).HasColumnName("id_vitrine_categoria");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdVitrine).HasColumnName("id_vitrine");

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TbVitrineCategoria)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_tb_vitrine_categoria_tb_categoria");

                entity.HasOne(d => d.IdVitrineNavigation)
                    .WithMany(p => p.TbVitrineCategoria)
                    .HasForeignKey(d => d.IdVitrine)
                    .HasConstraintName("FK_tb_vitrine_categoria_tb_vitrine");
            });

            modelBuilder.Entity<TbVitrinePraca>(entity =>
            {
                entity.HasKey(e => e.IdVitrinePraca);

                entity.ToTable("tb_vitrine_praca");

                entity.HasIndex(e => new { e.IdPraca, e.IdVitrine })
                    .HasName("idx_vitrine_praca");

                entity.Property(e => e.IdVitrinePraca).HasColumnName("id_vitrine_praca");

                entity.Property(e => e.IdPraca).HasColumnName("id_praca");

                entity.Property(e => e.IdVitrine).HasColumnName("id_vitrine");

                entity.HasOne(d => d.IdPracaNavigation)
                    .WithMany(p => p.TbVitrinePraca)
                    .HasForeignKey(d => d.IdPraca)
                    .HasConstraintName("FK_tb_vitrine_praca_tb_praca");

                entity.HasOne(d => d.IdVitrineNavigation)
                    .WithMany(p => p.TbVitrinePraca)
                    .HasForeignKey(d => d.IdVitrine)
                    .HasConstraintName("FK_tb_vitrine_praca_tb_vitrine");
            });

            modelBuilder.Entity<TbVitrineProdutoSku>(entity =>
            {
                entity.HasKey(e => e.IdVitrineProdutoSku);

                entity.ToTable("tb_vitrine_produto_sku");

                entity.HasIndex(e => new { e.NuOrdem, e.IdVitrine })
                    .HasName("idx_vitrine_produto");

                entity.Property(e => e.IdVitrineProdutoSku).HasColumnName("id_vitrine_produto_sku");

                entity.Property(e => e.IdProdutoSku).HasColumnName("id_produto_sku");

                entity.Property(e => e.IdVitrine).HasColumnName("id_vitrine");

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.IdProdutoSkuNavigation)
                    .WithMany(p => p.TbVitrineProdutoSku)
                    .HasForeignKey(d => d.IdProdutoSku)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_vitrine_produto_sku_tb_produto_sku");

                entity.HasOne(d => d.IdVitrineNavigation)
                    .WithMany(p => p.TbVitrineProdutoSku)
                    .HasForeignKey(d => d.IdVitrine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_vitrine_produto_sku_tb_vitrine");
            });

            modelBuilder.Entity<TbVitrineTipo>(entity =>
            {
                entity.HasKey(e => e.IdVitrineTipo);

                entity.ToTable("tb_vitrine_tipo");

                entity.Property(e => e.IdVitrineTipo).HasColumnName("id_vitrine_tipo");

                entity.Property(e => e.NmVitrineTipo)
                    .IsRequired()
                    .HasColumnName("nm_vitrine_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vannonline>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vannonline");

                entity.Property(e => e.Assunto).HasMaxLength(255);

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255);

                entity.Property(e => e.Organizacao)
                    .HasColumnName("organizacao")
                    .HasMaxLength(255);

                entity.Property(e => e.Satisfacao)
                    .HasColumnName("satisfacao")
                    .HasMaxLength(255);

                entity.Property(e => e.Solicitante).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);
            });
        
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
