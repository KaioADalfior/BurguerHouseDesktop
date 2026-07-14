using System.Drawing;
using System.Windows.Forms;

namespace Lanchonete001
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.pnlCorpo = new System.Windows.Forms.Panel();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.lblUsuarioConectado = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.pnlStatusDot = new System.Windows.Forms.Panel();
            this.lblStatusBanco = new System.Windows.Forms.Label();
            this.lblVersaoApp = new System.Windows.Forms.Label();
            this.pnlAreaConteudo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCardVendas = new System.Windows.Forms.Panel();
            this.pnlAccentVendas = new System.Windows.Forms.Panel();
            this.pnlIconVendas = new System.Windows.Forms.Panel();
            this.picIconVendas = new System.Windows.Forms.PictureBox();
            this.lblCaptionVendas = new System.Windows.Forms.Label();
            this.lblDescricaoCardVendas = new System.Windows.Forms.Label();
            this.lblValorCardVendas = new System.Windows.Forms.Label();
            this.pnlCardPedidos = new System.Windows.Forms.Panel();
            this.pnlAccentPedidos = new System.Windows.Forms.Panel();
            this.pnlIconPedidos = new System.Windows.Forms.Panel();
            this.picIconPedidos = new System.Windows.Forms.PictureBox();
            this.lblCaptionPedidos = new System.Windows.Forms.Label();
            this.lblDescricaoCardPedidos = new System.Windows.Forms.Label();
            this.lblValorCardPedidos = new System.Windows.Forms.Label();
            this.pnlCardEstoque = new System.Windows.Forms.Panel();
            this.pnlAccentEstoque = new System.Windows.Forms.Panel();
            this.pnlIconEstoque = new System.Windows.Forms.Panel();
            this.picIconEstoqueCard = new System.Windows.Forms.PictureBox();
            this.lblCaptionEstoqueCard = new System.Windows.Forms.Label();
            this.lblDescricaoCardEstoque = new System.Windows.Forms.Label();
            this.lblValorCardEstoque = new System.Windows.Forms.Label();
            this.pnlCardMesas = new System.Windows.Forms.Panel();
            this.pnlAccentMesas = new System.Windows.Forms.Panel();
            this.pnlIconMesas = new System.Windows.Forms.Panel();
            this.picIconMesas = new System.Windows.Forms.PictureBox();
            this.lblCaptionMesas = new System.Windows.Forms.Label();
            this.lblDescricaoCardMesas = new System.Windows.Forms.Label();
            this.lblValorCardMesas = new System.Windows.Forms.Label();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlDivisorMenuBase = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Panel();
            this.picMenuSair = new System.Windows.Forms.PictureBox();
            this.lblMenuSair = new System.Windows.Forms.Label();
            this.btnConfiguracoes = new System.Windows.Forms.Panel();
            this.picMenuConfiguracoes = new System.Windows.Forms.PictureBox();
            this.lblMenuConfiguracoes = new System.Windows.Forms.Label();
            this.btnRelatorios = new System.Windows.Forms.Panel();
            this.picMenuRelatorios = new System.Windows.Forms.PictureBox();
            this.lblMenuRelatorios = new System.Windows.Forms.Label();
            this.btnFinanceiro = new System.Windows.Forms.Panel();
            this.picMenuFinanceiro = new System.Windows.Forms.PictureBox();
            this.lblMenuFinanceiro = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Panel();
            this.picMenuClientes = new System.Windows.Forms.PictureBox();
            this.lblMenuClientes = new System.Windows.Forms.Label();
            this.btnDelivery = new System.Windows.Forms.Panel();
            this.picMenuDelivery = new System.Windows.Forms.PictureBox();
            this.lblMenuDelivery = new System.Windows.Forms.Label();
            this.btnMesas = new System.Windows.Forms.Panel();
            this.picMenuMesas = new System.Windows.Forms.PictureBox();
            this.lblMenuMesas = new System.Windows.Forms.Label();
            this.btnPedidos = new System.Windows.Forms.Panel();
            this.picMenuPedidos = new System.Windows.Forms.PictureBox();
            this.lblMenuPedidos = new System.Windows.Forms.Label();
            this.btnEstoque = new System.Windows.Forms.Panel();
            this.picMenuEstoque = new System.Windows.Forms.PictureBox();
            this.lblMenuEstoque = new System.Windows.Forms.Label();
            this.btnBebidas = new System.Windows.Forms.Panel();
            this.picMenuBebidas = new System.Windows.Forms.PictureBox();
            this.lblMenuBebidas = new System.Windows.Forms.Label();
            this.btnLanches = new System.Windows.Forms.Panel();
            this.picMenuLanches = new System.Windows.Forms.PictureBox();
            this.lblMenuLanches = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Panel();
            this.picMenuDashboard = new System.Windows.Forms.PictureBox();
            this.lblMenuDashboard = new System.Windows.Forms.Label();
            this.pnlIndicadorAtivo = new System.Windows.Forms.Panel();
            this.pnlDivisorMenuTopo = new System.Windows.Forms.Panel();
            this.lblMarcaApp = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlPerfilUsuario = new System.Windows.Forms.Panel();
            this.picNotificacoes = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.picAvatarUsuario = new System.Windows.Forms.PictureBox();
            this.btnConfiguracoes02 = new System.Windows.Forms.PictureBox();
            this.pnlBusca = new System.Windows.Forms.Panel();
            this.txtBuscaGlobal = new System.Windows.Forms.TextBox();
            this.picBuscarGlobal = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlRoot.SuspendLayout();
            this.pnlCorpo.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlAreaConteudo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlCardVendas.SuspendLayout();
            this.pnlIconVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconVendas)).BeginInit();
            this.pnlCardPedidos.SuspendLayout();
            this.pnlIconPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPedidos)).BeginInit();
            this.pnlCardEstoque.SuspendLayout();
            this.pnlIconEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconEstoqueCard)).BeginInit();
            this.pnlCardMesas.SuspendLayout();
            this.pnlIconMesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconMesas)).BeginInit();
            this.pnlMenuLateral.SuspendLayout();
            this.btnSair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuSair)).BeginInit();
            this.btnConfiguracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuConfiguracoes)).BeginInit();
            this.btnRelatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuRelatorios)).BeginInit();
            this.btnFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuFinanceiro)).BeginInit();
            this.btnClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuClientes)).BeginInit();
            this.btnDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuDelivery)).BeginInit();
            this.btnMesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuMesas)).BeginInit();
            this.btnPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPedidos)).BeginInit();
            this.btnEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuEstoque)).BeginInit();
            this.btnBebidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuBebidas)).BeginInit();
            this.btnLanches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuLanches)).BeginInit();
            this.btnDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlPerfilUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotificacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfiguracoes02)).BeginInit();
            this.pnlBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarGlobal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.Controls.Add(this.pnlCorpo);
            this.pnlRoot.Controls.Add(this.pnlHeader);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Size = new System.Drawing.Size(1326, 817);
            this.pnlRoot.TabIndex = 2;
            // 
            // pnlCorpo
            // 
            this.pnlCorpo.Controls.Add(this.pnlConteudo);
            this.pnlCorpo.Controls.Add(this.pnlMenuLateral);
            this.pnlCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCorpo.Location = new System.Drawing.Point(0, 46);
            this.pnlCorpo.Name = "pnlCorpo";
            this.pnlCorpo.Size = new System.Drawing.Size(1326, 771);
            this.pnlCorpo.TabIndex = 1;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.pnlRodape);
            this.pnlConteudo.Controls.Add(this.pnlAreaConteudo);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pnlConteudo.Location = new System.Drawing.Point(280, 0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Padding = new System.Windows.Forms.Padding(32);
            this.pnlConteudo.Size = new System.Drawing.Size(1046, 771);
            this.pnlConteudo.TabIndex = 1;
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.lblUsuarioConectado);
            this.pnlRodape.Controls.Add(this.lblHora);
            this.pnlRodape.Controls.Add(this.lblData);
            this.pnlRodape.Controls.Add(this.pnlStatusDot);
            this.pnlRodape.Controls.Add(this.lblStatusBanco);
            this.pnlRodape.Controls.Add(this.lblVersaoApp);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(32, 707);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(982, 32);
            this.pnlRodape.TabIndex = 0;
            // 
            // lblUsuarioConectado
            // 
            this.lblUsuarioConectado.AutoSize = true;
            this.lblUsuarioConectado.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.lblUsuarioConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblUsuarioConectado.Location = new System.Drawing.Point(732, 8);
            this.lblUsuarioConectado.Name = "lblUsuarioConectado";
            this.lblUsuarioConectado.Size = new System.Drawing.Size(124, 19);
            this.lblUsuarioConectado.TabIndex = 4;
            this.lblUsuarioConectado.Text = "lblUsuarioConectado";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblHora.Location = new System.Drawing.Point(665, 8);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 19);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "--:--";
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblData.Location = new System.Drawing.Point(478, 8);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(67, 19);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "--/--/----";
            // 
            // pnlStatusDot
            // 
            this.pnlStatusDot.BackColor = System.Drawing.Color.Green;
            this.pnlStatusDot.Location = new System.Drawing.Point(224, 12);
            this.pnlStatusDot.Name = "pnlStatusDot";
            this.pnlStatusDot.Size = new System.Drawing.Size(8, 8);
            this.pnlStatusDot.TabIndex = 5;
            // 
            // lblStatusBanco
            // 
            this.lblStatusBanco.AutoSize = true;
            this.lblStatusBanco.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.lblStatusBanco.ForeColor = System.Drawing.Color.Green;
            this.lblStatusBanco.Location = new System.Drawing.Point(238, 8);
            this.lblStatusBanco.Name = "lblStatusBanco";
            this.lblStatusBanco.Size = new System.Drawing.Size(91, 19);
            this.lblStatusBanco.TabIndex = 1;
            this.lblStatusBanco.Text = "lblStatusBanco";
            // 
            // lblVersaoApp
            // 
            this.lblVersaoApp.AutoSize = true;
            this.lblVersaoApp.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.lblVersaoApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblVersaoApp.Location = new System.Drawing.Point(16, 8);
            this.lblVersaoApp.Name = "lblVersaoApp";
            this.lblVersaoApp.Size = new System.Drawing.Size(112, 19);
            this.lblVersaoApp.TabIndex = 0;
            this.lblVersaoApp.Text = "Burguer House v1.0";
            // 
            // pnlAreaConteudo
            // 
            this.pnlAreaConteudo.AutoScroll = true;
            this.pnlAreaConteudo.Controls.Add(this.flowLayoutPanel1);
            this.pnlAreaConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAreaConteudo.Location = new System.Drawing.Point(32, 32);
            this.pnlAreaConteudo.Name = "pnlAreaConteudo";
            this.pnlAreaConteudo.Size = new System.Drawing.Size(982, 707);
            this.pnlAreaConteudo.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.pnlCardVendas);
            this.flowLayoutPanel1.Controls.Add(this.pnlCardPedidos);
            this.flowLayoutPanel1.Controls.Add(this.pnlCardEstoque);
            this.flowLayoutPanel1.Controls.Add(this.pnlCardMesas);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 150);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pnlCardVendas
            // 
            this.pnlCardVendas.BackColor = System.Drawing.Color.White;
            this.pnlCardVendas.Controls.Add(this.pnlAccentVendas);
            this.pnlCardVendas.Controls.Add(this.pnlIconVendas);
            this.pnlCardVendas.Controls.Add(this.lblCaptionVendas);
            this.pnlCardVendas.Controls.Add(this.lblDescricaoCardVendas);
            this.pnlCardVendas.Controls.Add(this.lblValorCardVendas);
            this.pnlCardVendas.Location = new System.Drawing.Point(0, 0);
            this.pnlCardVendas.Margin = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.pnlCardVendas.Name = "pnlCardVendas";
            this.pnlCardVendas.Size = new System.Drawing.Size(230, 140);
            this.pnlCardVendas.TabIndex = 8;
            // 
            // pnlAccentVendas
            // 
            this.pnlAccentVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.pnlAccentVendas.Location = new System.Drawing.Point(0, 0);
            this.pnlAccentVendas.Name = "pnlAccentVendas";
            this.pnlAccentVendas.Size = new System.Drawing.Size(6, 140);
            this.pnlAccentVendas.TabIndex = 8;
            // 
            // pnlIconVendas
            // 
            this.pnlIconVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.pnlIconVendas.Controls.Add(this.picIconVendas);
            this.pnlIconVendas.Location = new System.Drawing.Point(26, 20);
            this.pnlIconVendas.Name = "pnlIconVendas";
            this.pnlIconVendas.Size = new System.Drawing.Size(48, 48);
            this.pnlIconVendas.TabIndex = 7;
            // 
            // picIconVendas
            // 
            this.picIconVendas.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_us_dollar_circled_32;
            this.picIconVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconVendas.Location = new System.Drawing.Point(8, 8);
            this.picIconVendas.Name = "picIconVendas";
            this.picIconVendas.Size = new System.Drawing.Size(32, 32);
            this.picIconVendas.TabIndex = 4;
            this.picIconVendas.TabStop = false;
            // 
            // lblCaptionVendas
            // 
            this.lblCaptionVendas.AutoSize = true;
            this.lblCaptionVendas.Font = new System.Drawing.Font("Poppins", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCaptionVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCaptionVendas.Location = new System.Drawing.Point(84, 34);
            this.lblCaptionVendas.Name = "lblCaptionVendas";
            this.lblCaptionVendas.Size = new System.Drawing.Size(130, 25);
            this.lblCaptionVendas.TabIndex = 7;
            this.lblCaptionVendas.Text = "Total de Vendas";
            // 
            // lblDescricaoCardVendas
            // 
            this.lblDescricaoCardVendas.AutoSize = true;
            this.lblDescricaoCardVendas.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescricaoCardVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lblDescricaoCardVendas.Location = new System.Drawing.Point(26, 105);
            this.lblDescricaoCardVendas.Name = "lblDescricaoCardVendas";
            this.lblDescricaoCardVendas.Size = new System.Drawing.Size(45, 22);
            this.lblDescricaoCardVendas.TabIndex = 6;
            this.lblDescricaoCardVendas.Text = "Hoje!";
            // 
            // lblValorCardVendas
            // 
            this.lblValorCardVendas.AutoSize = true;
            this.lblValorCardVendas.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold);
            this.lblValorCardVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblValorCardVendas.Location = new System.Drawing.Point(26, 76);
            this.lblValorCardVendas.Name = "lblValorCardVendas";
            this.lblValorCardVendas.Size = new System.Drawing.Size(98, 39);
            this.lblValorCardVendas.TabIndex = 5;
            this.lblValorCardVendas.Text = "R$ 0,00";
            // 
            // pnlCardPedidos
            // 
            this.pnlCardPedidos.BackColor = System.Drawing.Color.White;
            this.pnlCardPedidos.Controls.Add(this.pnlAccentPedidos);
            this.pnlCardPedidos.Controls.Add(this.pnlIconPedidos);
            this.pnlCardPedidos.Controls.Add(this.lblCaptionPedidos);
            this.pnlCardPedidos.Controls.Add(this.lblDescricaoCardPedidos);
            this.pnlCardPedidos.Controls.Add(this.lblValorCardPedidos);
            this.pnlCardPedidos.Location = new System.Drawing.Point(254, 0);
            this.pnlCardPedidos.Margin = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.pnlCardPedidos.Name = "pnlCardPedidos";
            this.pnlCardPedidos.Size = new System.Drawing.Size(230, 140);
            this.pnlCardPedidos.TabIndex = 1;
            // 
            // pnlAccentPedidos
            // 
            this.pnlAccentPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.pnlAccentPedidos.Location = new System.Drawing.Point(0, 0);
            this.pnlAccentPedidos.Name = "pnlAccentPedidos";
            this.pnlAccentPedidos.Size = new System.Drawing.Size(6, 140);
            this.pnlAccentPedidos.TabIndex = 8;
            // 
            // pnlIconPedidos
            // 
            this.pnlIconPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.pnlIconPedidos.Controls.Add(this.picIconPedidos);
            this.pnlIconPedidos.Location = new System.Drawing.Point(26, 20);
            this.pnlIconPedidos.Name = "pnlIconPedidos";
            this.pnlIconPedidos.Size = new System.Drawing.Size(48, 48);
            this.pnlIconPedidos.TabIndex = 7;
            // 
            // picIconPedidos
            // 
            this.picIconPedidos.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_receipt_32;
            this.picIconPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconPedidos.Location = new System.Drawing.Point(8, 8);
            this.picIconPedidos.Name = "picIconPedidos";
            this.picIconPedidos.Size = new System.Drawing.Size(32, 32);
            this.picIconPedidos.TabIndex = 4;
            this.picIconPedidos.TabStop = false;
            // 
            // lblCaptionPedidos
            // 
            this.lblCaptionPedidos.AutoSize = true;
            this.lblCaptionPedidos.Font = new System.Drawing.Font("Poppins", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCaptionPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCaptionPedidos.Location = new System.Drawing.Point(84, 34);
            this.lblCaptionPedidos.Name = "lblCaptionPedidos";
            this.lblCaptionPedidos.Size = new System.Drawing.Size(106, 25);
            this.lblCaptionPedidos.TabIndex = 7;
            this.lblCaptionPedidos.Text = "Pedidos Hoje";
            // 
            // lblDescricaoCardPedidos
            // 
            this.lblDescricaoCardPedidos.AutoSize = true;
            this.lblDescricaoCardPedidos.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescricaoCardPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lblDescricaoCardPedidos.Location = new System.Drawing.Point(26, 105);
            this.lblDescricaoCardPedidos.Name = "lblDescricaoCardPedidos";
            this.lblDescricaoCardPedidos.Size = new System.Drawing.Size(0, 22);
            this.lblDescricaoCardPedidos.TabIndex = 6;
            // 
            // lblValorCardPedidos
            // 
            this.lblValorCardPedidos.AutoSize = true;
            this.lblValorCardPedidos.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold);
            this.lblValorCardPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblValorCardPedidos.Location = new System.Drawing.Point(26, 76);
            this.lblValorCardPedidos.Name = "lblValorCardPedidos";
            this.lblValorCardPedidos.Size = new System.Drawing.Size(31, 39);
            this.lblValorCardPedidos.TabIndex = 5;
            this.lblValorCardPedidos.Text = "0";
            // 
            // pnlCardEstoque
            // 
            this.pnlCardEstoque.BackColor = System.Drawing.Color.White;
            this.pnlCardEstoque.Controls.Add(this.pnlAccentEstoque);
            this.pnlCardEstoque.Controls.Add(this.pnlIconEstoque);
            this.pnlCardEstoque.Controls.Add(this.lblCaptionEstoqueCard);
            this.pnlCardEstoque.Controls.Add(this.lblDescricaoCardEstoque);
            this.pnlCardEstoque.Controls.Add(this.lblValorCardEstoque);
            this.pnlCardEstoque.Location = new System.Drawing.Point(508, 0);
            this.pnlCardEstoque.Margin = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.pnlCardEstoque.Name = "pnlCardEstoque";
            this.pnlCardEstoque.Size = new System.Drawing.Size(230, 140);
            this.pnlCardEstoque.TabIndex = 9;
            // 
            // pnlAccentEstoque
            // 
            this.pnlAccentEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAccentEstoque.Location = new System.Drawing.Point(0, 0);
            this.pnlAccentEstoque.Name = "pnlAccentEstoque";
            this.pnlAccentEstoque.Size = new System.Drawing.Size(6, 140);
            this.pnlAccentEstoque.TabIndex = 8;
            // 
            // pnlIconEstoque
            // 
            this.pnlIconEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlIconEstoque.Controls.Add(this.picIconEstoqueCard);
            this.pnlIconEstoque.Location = new System.Drawing.Point(26, 20);
            this.pnlIconEstoque.Name = "pnlIconEstoque";
            this.pnlIconEstoque.Size = new System.Drawing.Size(48, 48);
            this.pnlIconEstoque.TabIndex = 7;
            // 
            // picIconEstoqueCard
            // 
            this.picIconEstoqueCard.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_error_32;
            this.picIconEstoqueCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconEstoqueCard.Location = new System.Drawing.Point(8, 8);
            this.picIconEstoqueCard.Name = "picIconEstoqueCard";
            this.picIconEstoqueCard.Size = new System.Drawing.Size(32, 32);
            this.picIconEstoqueCard.TabIndex = 4;
            this.picIconEstoqueCard.TabStop = false;
            // 
            // lblCaptionEstoqueCard
            // 
            this.lblCaptionEstoqueCard.AutoSize = true;
            this.lblCaptionEstoqueCard.Font = new System.Drawing.Font("Poppins", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCaptionEstoqueCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCaptionEstoqueCard.Location = new System.Drawing.Point(84, 34);
            this.lblCaptionEstoqueCard.Name = "lblCaptionEstoqueCard";
            this.lblCaptionEstoqueCard.Size = new System.Drawing.Size(114, 25);
            this.lblCaptionEstoqueCard.TabIndex = 7;
            this.lblCaptionEstoqueCard.Text = "Estoque Baixo";
            // 
            // lblDescricaoCardEstoque
            // 
            this.lblDescricaoCardEstoque.AutoSize = true;
            this.lblDescricaoCardEstoque.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescricaoCardEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDescricaoCardEstoque.Location = new System.Drawing.Point(26, 105);
            this.lblDescricaoCardEstoque.Name = "lblDescricaoCardEstoque";
            this.lblDescricaoCardEstoque.Size = new System.Drawing.Size(0, 22);
            this.lblDescricaoCardEstoque.TabIndex = 6;
            // 
            // lblValorCardEstoque
            // 
            this.lblValorCardEstoque.AutoSize = true;
            this.lblValorCardEstoque.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold);
            this.lblValorCardEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblValorCardEstoque.Location = new System.Drawing.Point(26, 76);
            this.lblValorCardEstoque.Name = "lblValorCardEstoque";
            this.lblValorCardEstoque.Size = new System.Drawing.Size(92, 39);
            this.lblValorCardEstoque.TabIndex = 5;
            this.lblValorCardEstoque.Text = "0 itens";
            // 
            // pnlCardMesas
            // 
            this.pnlCardMesas.BackColor = System.Drawing.Color.White;
            this.pnlCardMesas.Controls.Add(this.pnlAccentMesas);
            this.pnlCardMesas.Controls.Add(this.pnlIconMesas);
            this.pnlCardMesas.Controls.Add(this.lblCaptionMesas);
            this.pnlCardMesas.Controls.Add(this.lblDescricaoCardMesas);
            this.pnlCardMesas.Controls.Add(this.lblValorCardMesas);
            this.pnlCardMesas.Location = new System.Drawing.Point(762, 0);
            this.pnlCardMesas.Margin = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.pnlCardMesas.Name = "pnlCardMesas";
            this.pnlCardMesas.Size = new System.Drawing.Size(230, 140);
            this.pnlCardMesas.TabIndex = 8;
            // 
            // pnlAccentMesas
            // 
            this.pnlAccentMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.pnlAccentMesas.Location = new System.Drawing.Point(0, 0);
            this.pnlAccentMesas.Name = "pnlAccentMesas";
            this.pnlAccentMesas.Size = new System.Drawing.Size(6, 140);
            this.pnlAccentMesas.TabIndex = 8;
            // 
            // pnlIconMesas
            // 
            this.pnlIconMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.pnlIconMesas.Controls.Add(this.picIconMesas);
            this.pnlIconMesas.Location = new System.Drawing.Point(26, 20);
            this.pnlIconMesas.Name = "pnlIconMesas";
            this.pnlIconMesas.Size = new System.Drawing.Size(48, 48);
            this.pnlIconMesas.TabIndex = 7;
            // 
            // picIconMesas
            // 
            this.picIconMesas.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_utensils_32;
            this.picIconMesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconMesas.Location = new System.Drawing.Point(8, 8);
            this.picIconMesas.Name = "picIconMesas";
            this.picIconMesas.Size = new System.Drawing.Size(32, 32);
            this.picIconMesas.TabIndex = 4;
            this.picIconMesas.TabStop = false;
            // 
            // lblCaptionMesas
            // 
            this.lblCaptionMesas.AutoSize = true;
            this.lblCaptionMesas.Font = new System.Drawing.Font("Poppins", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCaptionMesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCaptionMesas.Location = new System.Drawing.Point(84, 34);
            this.lblCaptionMesas.Name = "lblCaptionMesas";
            this.lblCaptionMesas.Size = new System.Drawing.Size(139, 25);
            this.lblCaptionMesas.TabIndex = 7;
            this.lblCaptionMesas.Text = "Mesas Ocupadas";
            // 
            // lblDescricaoCardMesas
            // 
            this.lblDescricaoCardMesas.AutoSize = true;
            this.lblDescricaoCardMesas.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescricaoCardMesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(120)))), ((int)(((byte)(70)))));
            this.lblDescricaoCardMesas.Location = new System.Drawing.Point(26, 105);
            this.lblDescricaoCardMesas.Name = "lblDescricaoCardMesas";
            this.lblDescricaoCardMesas.Size = new System.Drawing.Size(0, 22);
            this.lblDescricaoCardMesas.TabIndex = 6;
            // 
            // lblValorCardMesas
            // 
            this.lblValorCardMesas.AutoSize = true;
            this.lblValorCardMesas.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold);
            this.lblValorCardMesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblValorCardMesas.Location = new System.Drawing.Point(26, 76);
            this.lblValorCardMesas.Name = "lblValorCardMesas";
            this.lblValorCardMesas.Size = new System.Drawing.Size(55, 39);
            this.lblValorCardMesas.TabIndex = 5;
            this.lblValorCardMesas.Text = "0/0";
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.pnlMenuLateral.Controls.Add(this.pnlDivisorMenuBase);
            this.pnlMenuLateral.Controls.Add(this.btnSair);
            this.pnlMenuLateral.Controls.Add(this.btnConfiguracoes);
            this.pnlMenuLateral.Controls.Add(this.btnRelatorios);
            this.pnlMenuLateral.Controls.Add(this.btnFinanceiro);
            this.pnlMenuLateral.Controls.Add(this.btnClientes);
            this.pnlMenuLateral.Controls.Add(this.btnDelivery);
            this.pnlMenuLateral.Controls.Add(this.btnMesas);
            this.pnlMenuLateral.Controls.Add(this.btnPedidos);
            this.pnlMenuLateral.Controls.Add(this.btnEstoque);
            this.pnlMenuLateral.Controls.Add(this.btnBebidas);
            this.pnlMenuLateral.Controls.Add(this.btnLanches);
            this.pnlMenuLateral.Controls.Add(this.btnDashboard);
            this.pnlMenuLateral.Controls.Add(this.pnlIndicadorAtivo);
            this.pnlMenuLateral.Controls.Add(this.pnlDivisorMenuTopo);
            this.pnlMenuLateral.Controls.Add(this.lblMarcaApp);
            this.pnlMenuLateral.Controls.Add(this.picLogo);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Padding = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.pnlMenuLateral.Size = new System.Drawing.Size(280, 771);
            this.pnlMenuLateral.TabIndex = 0;
            // 
            // pnlDivisorMenuBase
            // 
            this.pnlDivisorMenuBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.pnlDivisorMenuBase.Location = new System.Drawing.Point(24, 656);
            this.pnlDivisorMenuBase.Name = "pnlDivisorMenuBase";
            this.pnlDivisorMenuBase.Size = new System.Drawing.Size(212, 1);
            this.pnlDivisorMenuBase.TabIndex = 14;
            // 
            // btnSair
            // 
            this.btnSair.Controls.Add(this.picMenuSair);
            this.btnSair.Controls.Add(this.lblMenuSair);
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnSair.Location = new System.Drawing.Point(0, 663);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(260, 48);
            this.btnSair.TabIndex = 15;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picMenuSair
            // 
            this.picMenuSair.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_close_38;
            this.picMenuSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuSair.Location = new System.Drawing.Point(24, 3);
            this.picMenuSair.Name = "picMenuSair";
            this.picMenuSair.Size = new System.Drawing.Size(40, 40);
            this.picMenuSair.TabIndex = 3;
            this.picMenuSair.TabStop = false;
            this.picMenuSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMenuSair
            // 
            this.lblMenuSair.AutoSize = true;
            this.lblMenuSair.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuSair.Location = new System.Drawing.Point(77, 13);
            this.lblMenuSair.Name = "lblMenuSair";
            this.lblMenuSair.Size = new System.Drawing.Size(37, 25);
            this.lblMenuSair.TabIndex = 1;
            this.lblMenuSair.Text = "Sair";
            this.lblMenuSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Controls.Add(this.picMenuConfiguracoes);
            this.btnConfiguracoes.Controls.Add(this.lblMenuConfiguracoes);
            this.btnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 602);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnConfiguracoes.Size = new System.Drawing.Size(260, 48);
            this.btnConfiguracoes.TabIndex = 13;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // picMenuConfiguracoes
            // 
            this.picMenuConfiguracoes.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_config_38;
            this.picMenuConfiguracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuConfiguracoes.Location = new System.Drawing.Point(24, 3);
            this.picMenuConfiguracoes.Name = "picMenuConfiguracoes";
            this.picMenuConfiguracoes.Size = new System.Drawing.Size(40, 40);
            this.picMenuConfiguracoes.TabIndex = 3;
            this.picMenuConfiguracoes.TabStop = false;
            this.picMenuConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // lblMenuConfiguracoes
            // 
            this.lblMenuConfiguracoes.AutoSize = true;
            this.lblMenuConfiguracoes.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuConfiguracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuConfiguracoes.Location = new System.Drawing.Point(77, 13);
            this.lblMenuConfiguracoes.Name = "lblMenuConfiguracoes";
            this.lblMenuConfiguracoes.Size = new System.Drawing.Size(115, 25);
            this.lblMenuConfiguracoes.TabIndex = 1;
            this.lblMenuConfiguracoes.Text = "Configurações";
            this.lblMenuConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Controls.Add(this.picMenuRelatorios);
            this.btnRelatorios.Controls.Add(this.lblMenuRelatorios);
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnRelatorios.Location = new System.Drawing.Point(0, 548);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(260, 48);
            this.btnRelatorios.TabIndex = 12;
            // 
            // picMenuRelatorios
            // 
            this.picMenuRelatorios.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_combo_chart_38;
            this.picMenuRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuRelatorios.Location = new System.Drawing.Point(24, 3);
            this.picMenuRelatorios.Name = "picMenuRelatorios";
            this.picMenuRelatorios.Size = new System.Drawing.Size(40, 40);
            this.picMenuRelatorios.TabIndex = 3;
            this.picMenuRelatorios.TabStop = false;
            // 
            // lblMenuRelatorios
            // 
            this.lblMenuRelatorios.AutoSize = true;
            this.lblMenuRelatorios.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuRelatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuRelatorios.Location = new System.Drawing.Point(77, 13);
            this.lblMenuRelatorios.Name = "lblMenuRelatorios";
            this.lblMenuRelatorios.Size = new System.Drawing.Size(80, 25);
            this.lblMenuRelatorios.TabIndex = 1;
            this.lblMenuRelatorios.Text = "Relatórios";
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Controls.Add(this.picMenuFinanceiro);
            this.btnFinanceiro.Controls.Add(this.lblMenuFinanceiro);
            this.btnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanceiro.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnFinanceiro.Location = new System.Drawing.Point(0, 494);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnFinanceiro.Size = new System.Drawing.Size(260, 48);
            this.btnFinanceiro.TabIndex = 11;
            // 
            // picMenuFinanceiro
            // 
            this.picMenuFinanceiro.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_us_dollar_circled_38;
            this.picMenuFinanceiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuFinanceiro.Location = new System.Drawing.Point(24, 3);
            this.picMenuFinanceiro.Name = "picMenuFinanceiro";
            this.picMenuFinanceiro.Size = new System.Drawing.Size(40, 40);
            this.picMenuFinanceiro.TabIndex = 3;
            this.picMenuFinanceiro.TabStop = false;
            // 
            // lblMenuFinanceiro
            // 
            this.lblMenuFinanceiro.AutoSize = true;
            this.lblMenuFinanceiro.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuFinanceiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuFinanceiro.Location = new System.Drawing.Point(77, 13);
            this.lblMenuFinanceiro.Name = "lblMenuFinanceiro";
            this.lblMenuFinanceiro.Size = new System.Drawing.Size(84, 25);
            this.lblMenuFinanceiro.TabIndex = 1;
            this.lblMenuFinanceiro.Text = "Financeiro";
            // 
            // btnClientes
            // 
            this.btnClientes.Controls.Add(this.picMenuClientes);
            this.btnClientes.Controls.Add(this.lblMenuClientes);
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnClientes.Location = new System.Drawing.Point(0, 440);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(260, 48);
            this.btnClientes.TabIndex = 10;
            // 
            // picMenuClientes
            // 
            this.picMenuClientes.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_users_38;
            this.picMenuClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuClientes.Location = new System.Drawing.Point(24, 3);
            this.picMenuClientes.Name = "picMenuClientes";
            this.picMenuClientes.Size = new System.Drawing.Size(40, 40);
            this.picMenuClientes.TabIndex = 3;
            this.picMenuClientes.TabStop = false;
            // 
            // lblMenuClientes
            // 
            this.lblMenuClientes.AutoSize = true;
            this.lblMenuClientes.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuClientes.Location = new System.Drawing.Point(77, 13);
            this.lblMenuClientes.Name = "lblMenuClientes";
            this.lblMenuClientes.Size = new System.Drawing.Size(68, 25);
            this.lblMenuClientes.TabIndex = 1;
            this.lblMenuClientes.Text = "Clientes";
            // 
            // btnDelivery
            // 
            this.btnDelivery.Controls.Add(this.picMenuDelivery);
            this.btnDelivery.Controls.Add(this.lblMenuDelivery);
            this.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelivery.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnDelivery.Location = new System.Drawing.Point(0, 386);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnDelivery.Size = new System.Drawing.Size(260, 48);
            this.btnDelivery.TabIndex = 9;
            // 
            // picMenuDelivery
            // 
            this.picMenuDelivery.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_motorcycle_38;
            this.picMenuDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuDelivery.Location = new System.Drawing.Point(24, 3);
            this.picMenuDelivery.Name = "picMenuDelivery";
            this.picMenuDelivery.Size = new System.Drawing.Size(40, 40);
            this.picMenuDelivery.TabIndex = 3;
            this.picMenuDelivery.TabStop = false;
            // 
            // lblMenuDelivery
            // 
            this.lblMenuDelivery.AutoSize = true;
            this.lblMenuDelivery.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuDelivery.Location = new System.Drawing.Point(77, 13);
            this.lblMenuDelivery.Name = "lblMenuDelivery";
            this.lblMenuDelivery.Size = new System.Drawing.Size(67, 25);
            this.lblMenuDelivery.TabIndex = 1;
            this.lblMenuDelivery.Text = "Delivery";
            // 
            // btnMesas
            // 
            this.btnMesas.Controls.Add(this.picMenuMesas);
            this.btnMesas.Controls.Add(this.lblMenuMesas);
            this.btnMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesas.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnMesas.Location = new System.Drawing.Point(0, 332);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnMesas.Size = new System.Drawing.Size(260, 48);
            this.btnMesas.TabIndex = 8;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // picMenuMesas
            // 
            this.picMenuMesas.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_utensils_38;
            this.picMenuMesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuMesas.Location = new System.Drawing.Point(24, 3);
            this.picMenuMesas.Name = "picMenuMesas";
            this.picMenuMesas.Size = new System.Drawing.Size(40, 40);
            this.picMenuMesas.TabIndex = 3;
            this.picMenuMesas.TabStop = false;
            this.picMenuMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // lblMenuMesas
            // 
            this.lblMenuMesas.AutoSize = true;
            this.lblMenuMesas.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuMesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuMesas.Location = new System.Drawing.Point(77, 13);
            this.lblMenuMesas.Name = "lblMenuMesas";
            this.lblMenuMesas.Size = new System.Drawing.Size(56, 25);
            this.lblMenuMesas.TabIndex = 1;
            this.lblMenuMesas.Text = "Mesas";
            this.lblMenuMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Controls.Add(this.picMenuPedidos);
            this.btnPedidos.Controls.Add(this.lblMenuPedidos);
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnPedidos.Location = new System.Drawing.Point(0, 278);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnPedidos.Size = new System.Drawing.Size(260, 48);
            this.btnPedidos.TabIndex = 7;
            // 
            // picMenuPedidos
            // 
            this.picMenuPedidos.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_receipt_38;
            this.picMenuPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuPedidos.Location = new System.Drawing.Point(24, 3);
            this.picMenuPedidos.Name = "picMenuPedidos";
            this.picMenuPedidos.Size = new System.Drawing.Size(40, 40);
            this.picMenuPedidos.TabIndex = 3;
            this.picMenuPedidos.TabStop = false;
            // 
            // lblMenuPedidos
            // 
            this.lblMenuPedidos.AutoSize = true;
            this.lblMenuPedidos.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuPedidos.Location = new System.Drawing.Point(77, 13);
            this.lblMenuPedidos.Name = "lblMenuPedidos";
            this.lblMenuPedidos.Size = new System.Drawing.Size(66, 25);
            this.lblMenuPedidos.TabIndex = 1;
            this.lblMenuPedidos.Text = "Pedidos";
            // 
            // btnEstoque
            // 
            this.btnEstoque.Controls.Add(this.picMenuEstoque);
            this.btnEstoque.Controls.Add(this.lblMenuEstoque);
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnEstoque.Location = new System.Drawing.Point(0, 224);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnEstoque.Size = new System.Drawing.Size(260, 48);
            this.btnEstoque.TabIndex = 6;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // picMenuEstoque
            // 
            this.picMenuEstoque.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_box_38;
            this.picMenuEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuEstoque.Location = new System.Drawing.Point(24, 3);
            this.picMenuEstoque.Name = "picMenuEstoque";
            this.picMenuEstoque.Size = new System.Drawing.Size(40, 40);
            this.picMenuEstoque.TabIndex = 3;
            this.picMenuEstoque.TabStop = false;
            this.picMenuEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // lblMenuEstoque
            // 
            this.lblMenuEstoque.AutoSize = true;
            this.lblMenuEstoque.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuEstoque.Location = new System.Drawing.Point(77, 13);
            this.lblMenuEstoque.Name = "lblMenuEstoque";
            this.lblMenuEstoque.Size = new System.Drawing.Size(67, 25);
            this.lblMenuEstoque.TabIndex = 1;
            this.lblMenuEstoque.Text = "Estoque";
            this.lblMenuEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.Controls.Add(this.picMenuBebidas);
            this.btnBebidas.Controls.Add(this.lblMenuBebidas);
            this.btnBebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBebidas.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnBebidas.Location = new System.Drawing.Point(0, 170);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnBebidas.Size = new System.Drawing.Size(260, 48);
            this.btnBebidas.TabIndex = 5;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // picMenuBebidas
            // 
            this.picMenuBebidas.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_soda_38;
            this.picMenuBebidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuBebidas.Location = new System.Drawing.Point(24, 3);
            this.picMenuBebidas.Name = "picMenuBebidas";
            this.picMenuBebidas.Size = new System.Drawing.Size(40, 40);
            this.picMenuBebidas.TabIndex = 3;
            this.picMenuBebidas.TabStop = false;
            this.picMenuBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // lblMenuBebidas
            // 
            this.lblMenuBebidas.AutoSize = true;
            this.lblMenuBebidas.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuBebidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuBebidas.Location = new System.Drawing.Point(77, 13);
            this.lblMenuBebidas.Name = "lblMenuBebidas";
            this.lblMenuBebidas.Size = new System.Drawing.Size(67, 25);
            this.lblMenuBebidas.TabIndex = 1;
            this.lblMenuBebidas.Text = "Bebidas";
            this.lblMenuBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnLanches
            // 
            this.btnLanches.Controls.Add(this.picMenuLanches);
            this.btnLanches.Controls.Add(this.lblMenuLanches);
            this.btnLanches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanches.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnLanches.Location = new System.Drawing.Point(0, 116);
            this.btnLanches.Name = "btnLanches";
            this.btnLanches.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnLanches.Size = new System.Drawing.Size(260, 48);
            this.btnLanches.TabIndex = 4;
            this.btnLanches.Click += new System.EventHandler(this.btnLanches_Click);
            // 
            // picMenuLanches
            // 
            this.picMenuLanches.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_burguer_38;
            this.picMenuLanches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuLanches.Location = new System.Drawing.Point(24, 3);
            this.picMenuLanches.Name = "picMenuLanches";
            this.picMenuLanches.Size = new System.Drawing.Size(40, 40);
            this.picMenuLanches.TabIndex = 3;
            this.picMenuLanches.TabStop = false;
            this.picMenuLanches.Click += new System.EventHandler(this.btnLanches_Click);
            // 
            // lblMenuLanches
            // 
            this.lblMenuLanches.AutoSize = true;
            this.lblMenuLanches.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuLanches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuLanches.Location = new System.Drawing.Point(77, 13);
            this.lblMenuLanches.Name = "lblMenuLanches";
            this.lblMenuLanches.Size = new System.Drawing.Size(70, 25);
            this.lblMenuLanches.TabIndex = 1;
            this.lblMenuLanches.Text = "Lanches";
            this.lblMenuLanches.Click += new System.EventHandler(this.btnLanches_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Controls.Add(this.picMenuDashboard);
            this.btnDashboard.Controls.Add(this.lblMenuDashboard);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnDashboard.Location = new System.Drawing.Point(0, 62);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(260, 48);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // picMenuDashboard
            // 
            this.picMenuDashboard.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_house_38;
            this.picMenuDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMenuDashboard.Location = new System.Drawing.Point(24, 3);
            this.picMenuDashboard.Name = "picMenuDashboard";
            this.picMenuDashboard.Size = new System.Drawing.Size(40, 40);
            this.picMenuDashboard.TabIndex = 3;
            this.picMenuDashboard.TabStop = false;
            this.picMenuDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblMenuDashboard
            // 
            this.lblMenuDashboard.AutoSize = true;
            this.lblMenuDashboard.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.lblMenuDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMenuDashboard.Location = new System.Drawing.Point(77, 13);
            this.lblMenuDashboard.Name = "lblMenuDashboard";
            this.lblMenuDashboard.Size = new System.Drawing.Size(88, 25);
            this.lblMenuDashboard.TabIndex = 1;
            this.lblMenuDashboard.Text = "Dashboard";
            this.lblMenuDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlIndicadorAtivo
            // 
            this.pnlIndicadorAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.pnlIndicadorAtivo.Location = new System.Drawing.Point(0, 62);
            this.pnlIndicadorAtivo.Name = "pnlIndicadorAtivo";
            this.pnlIndicadorAtivo.Size = new System.Drawing.Size(4, 48);
            this.pnlIndicadorAtivo.TabIndex = 20;
            // 
            // pnlDivisorMenuTopo
            // 
            this.pnlDivisorMenuTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.pnlDivisorMenuTopo.Location = new System.Drawing.Point(24, 55);
            this.pnlDivisorMenuTopo.Name = "pnlDivisorMenuTopo";
            this.pnlDivisorMenuTopo.Size = new System.Drawing.Size(212, 1);
            this.pnlDivisorMenuTopo.TabIndex = 2;
            // 
            // lblMarcaApp
            // 
            this.lblMarcaApp.AutoSize = true;
            this.lblMarcaApp.Font = new System.Drawing.Font("Poppins ExtraBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMarcaApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblMarcaApp.Location = new System.Drawing.Point(70, 18);
            this.lblMarcaApp.Name = "lblMarcaApp";
            this.lblMarcaApp.Size = new System.Drawing.Size(175, 34);
            this.lblMarcaApp.TabIndex = 1;
            this.lblMarcaApp.Text = "BURGUER HOUSE";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_burguer_38;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(24, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(40, 40);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.pnlHeader.Controls.Add(this.pnlPerfilUsuario);
            this.pnlHeader.Controls.Add(this.pnlBusca);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1326, 46);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlPerfilUsuario
            // 
            this.pnlPerfilUsuario.Controls.Add(this.picNotificacoes);
            this.pnlPerfilUsuario.Controls.Add(this.lblUsuario);
            this.pnlPerfilUsuario.Controls.Add(this.lblCargo);
            this.pnlPerfilUsuario.Controls.Add(this.picAvatarUsuario);
            this.pnlPerfilUsuario.Controls.Add(this.btnConfiguracoes02);
            this.pnlPerfilUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPerfilUsuario.Location = new System.Drawing.Point(967, 0);
            this.pnlPerfilUsuario.Name = "pnlPerfilUsuario";
            this.pnlPerfilUsuario.Size = new System.Drawing.Size(359, 46);
            this.pnlPerfilUsuario.TabIndex = 14;
            // 
            // picNotificacoes
            // 
            this.picNotificacoes.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_alarm_38;
            this.picNotificacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picNotificacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNotificacoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.picNotificacoes.Location = new System.Drawing.Point(239, 0);
            this.picNotificacoes.Name = "picNotificacoes";
            this.picNotificacoes.Size = new System.Drawing.Size(40, 46);
            this.picNotificacoes.TabIndex = 8;
            this.picNotificacoes.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Poppins SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.lblUsuario.Location = new System.Drawing.Point(3, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 22);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Poppins", 8F);
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(205)))));
            this.lblCargo.Location = new System.Drawing.Point(3, 23);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(55, 19);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "lblCargo";
            // 
            // picAvatarUsuario
            // 
            this.picAvatarUsuario.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_avatar_38;
            this.picAvatarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAvatarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatarUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAvatarUsuario.Location = new System.Drawing.Point(279, 0);
            this.picAvatarUsuario.Name = "picAvatarUsuario";
            this.picAvatarUsuario.Size = new System.Drawing.Size(40, 46);
            this.picAvatarUsuario.TabIndex = 5;
            this.picAvatarUsuario.TabStop = false;
            // 
            // btnConfiguracoes02
            // 
            this.btnConfiguracoes02.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_config_38;
            this.btnConfiguracoes02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfiguracoes02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracoes02.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfiguracoes02.Location = new System.Drawing.Point(319, 0);
            this.btnConfiguracoes02.Name = "btnConfiguracoes02";
            this.btnConfiguracoes02.Size = new System.Drawing.Size(40, 46);
            this.btnConfiguracoes02.TabIndex = 4;
            this.btnConfiguracoes02.TabStop = false;
            this.btnConfiguracoes02.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // pnlBusca
            // 
            this.pnlBusca.BackColor = System.Drawing.Color.White;
            this.pnlBusca.Controls.Add(this.txtBuscaGlobal);
            this.pnlBusca.Controls.Add(this.picBuscarGlobal);
            this.pnlBusca.Location = new System.Drawing.Point(16, 8);
            this.pnlBusca.Name = "pnlBusca";
            this.pnlBusca.Size = new System.Drawing.Size(260, 30);
            this.pnlBusca.TabIndex = 15;
            // 
            // txtBuscaGlobal
            // 
            this.txtBuscaGlobal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscaGlobal.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtBuscaGlobal.Location = new System.Drawing.Point(12, 6);
            this.txtBuscaGlobal.Name = "txtBuscaGlobal";
            this.txtBuscaGlobal.Size = new System.Drawing.Size(206, 20);
            this.txtBuscaGlobal.TabIndex = 0;
            // 
            // picBuscarGlobal
            // 
            this.picBuscarGlobal.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_search_30;
            this.picBuscarGlobal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBuscarGlobal.Location = new System.Drawing.Point(224, 0);
            this.picBuscarGlobal.Name = "picBuscarGlobal";
            this.picBuscarGlobal.Size = new System.Drawing.Size(30, 30);
            this.picBuscarGlobal.TabIndex = 13;
            this.picBuscarGlobal.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1326, 817);
            this.Controls.Add(this.pnlRoot);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento - Lanchonete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlRoot.ResumeLayout(false);
            this.pnlCorpo.ResumeLayout(false);
            this.pnlConteudo.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.pnlAreaConteudo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlCardVendas.ResumeLayout(false);
            this.pnlCardVendas.PerformLayout();
            this.pnlIconVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconVendas)).EndInit();
            this.pnlCardPedidos.ResumeLayout(false);
            this.pnlCardPedidos.PerformLayout();
            this.pnlIconPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconPedidos)).EndInit();
            this.pnlCardEstoque.ResumeLayout(false);
            this.pnlCardEstoque.PerformLayout();
            this.pnlIconEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconEstoqueCard)).EndInit();
            this.pnlCardMesas.ResumeLayout(false);
            this.pnlCardMesas.PerformLayout();
            this.pnlIconMesas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconMesas)).EndInit();
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlMenuLateral.PerformLayout();
            this.btnSair.ResumeLayout(false);
            this.btnSair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuSair)).EndInit();
            this.btnConfiguracoes.ResumeLayout(false);
            this.btnConfiguracoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuConfiguracoes)).EndInit();
            this.btnRelatorios.ResumeLayout(false);
            this.btnRelatorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuRelatorios)).EndInit();
            this.btnFinanceiro.ResumeLayout(false);
            this.btnFinanceiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuFinanceiro)).EndInit();
            this.btnClientes.ResumeLayout(false);
            this.btnClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuClientes)).EndInit();
            this.btnDelivery.ResumeLayout(false);
            this.btnDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuDelivery)).EndInit();
            this.btnMesas.ResumeLayout(false);
            this.btnMesas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuMesas)).EndInit();
            this.btnPedidos.ResumeLayout(false);
            this.btnPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPedidos)).EndInit();
            this.btnEstoque.ResumeLayout(false);
            this.btnEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuEstoque)).EndInit();
            this.btnBebidas.ResumeLayout(false);
            this.btnBebidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuBebidas)).EndInit();
            this.btnLanches.ResumeLayout(false);
            this.btnLanches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuLanches)).EndInit();
            this.btnDashboard.ResumeLayout(false);
            this.btnDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlPerfilUsuario.ResumeLayout(false);
            this.pnlPerfilUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotificacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfiguracoes02)).EndInit();
            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarGlobal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Raiz / cabeçalho / corpo
        private Panel pnlRoot;
        private Panel pnlCorpo;
        private Panel pnlHeader;
        private Panel pnlBusca;
        private TextBox txtBuscaGlobal;
        private PictureBox picBuscarGlobal;
        private Panel pnlPerfilUsuario;
        private PictureBox picNotificacoes;
        private Label lblUsuario;
        private Label lblCargo;
        private PictureBox picAvatarUsuario;
        private PictureBox btnConfiguracoes02;

        // Menu lateral
        private Panel pnlMenuLateral;
        private PictureBox picLogo;
        private Label lblMarcaApp;
        private Panel pnlDivisorMenuTopo;
        private Panel pnlIndicadorAtivo;

        private Panel btnDashboard;
        private PictureBox picMenuDashboard;
        private Label lblMenuDashboard;

        private Panel btnLanches;
        private PictureBox picMenuLanches;
        private Label lblMenuLanches;

        private Panel btnBebidas;
        private PictureBox picMenuBebidas;
        private Label lblMenuBebidas;

        private Panel btnEstoque;
        private PictureBox picMenuEstoque;
        private Label lblMenuEstoque;

        private Panel btnPedidos;
        private PictureBox picMenuPedidos;
        private Label lblMenuPedidos;

        private Panel btnMesas;
        private PictureBox picMenuMesas;
        private Label lblMenuMesas;

        private Panel btnDelivery;
        private PictureBox picMenuDelivery;
        private Label lblMenuDelivery;

        private Panel btnClientes;
        private PictureBox picMenuClientes;
        private Label lblMenuClientes;

        private Panel btnFinanceiro;
        private PictureBox picMenuFinanceiro;
        private Label lblMenuFinanceiro;

        private Panel btnRelatorios;
        private PictureBox picMenuRelatorios;
        private Label lblMenuRelatorios;

        private Panel btnConfiguracoes;
        private PictureBox picMenuConfiguracoes;
        private Label lblMenuConfiguracoes;

        private Panel pnlDivisorMenuBase;

        private Panel btnSair;
        private PictureBox picMenuSair;
        private Label lblMenuSair;

        // Área de conteúdo
        private Panel pnlConteudo;
        private Panel pnlAreaConteudo;

        private FlowLayoutPanel flowLayoutPanel1;

        private Panel pnlCardVendas;
        private Panel pnlAccentVendas;
        private Panel pnlIconVendas;
        private PictureBox picIconVendas;
        private Label lblCaptionVendas;
        private Label lblDescricaoCardVendas;
        private Label lblValorCardVendas;

        private Panel pnlCardPedidos;
        private Panel pnlAccentPedidos;
        private Panel pnlIconPedidos;
        private PictureBox picIconPedidos;
        private Label lblCaptionPedidos;
        private Label lblDescricaoCardPedidos;
        private Label lblValorCardPedidos;

        private Panel pnlCardMesas;
        private Panel pnlAccentMesas;
        private Panel pnlIconMesas;
        private PictureBox picIconMesas;
        private Label lblCaptionMesas;
        private Label lblDescricaoCardMesas;
        private Label lblValorCardMesas;

        private Panel pnlCardEstoque;
        private Panel pnlAccentEstoque;
        private Panel pnlIconEstoque;
        private PictureBox picIconEstoqueCard;
        private Label lblCaptionEstoqueCard;
        private Label lblDescricaoCardEstoque;
        private Label lblValorCardEstoque;

        // Rodapé
        private Panel pnlRodape;
        private Label lblUsuarioConectado;
        private Label lblHora;
        private Label lblData;
        private Panel pnlStatusDot;
        private Label lblStatusBanco;
        private Label lblVersaoApp;

        private System.Windows.Forms.Timer timer1;
    }
}