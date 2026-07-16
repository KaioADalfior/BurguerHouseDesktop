using System.Drawing;
using System.Windows.Forms;
using Lanchonete001.UI;

namespace Lanchonete001.Estoque
{
    partial class UcEstoque
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Lanchonete001.UI.RoundedPanel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCardTotal = new Lanchonete001.UI.RoundedPanel();
            this.pnlIconTotal = new Lanchonete001.UI.RoundedPanel();
            this.picIconTotal = new System.Windows.Forms.PictureBox();
            this.lblCaptionTotal = new System.Windows.Forms.Label();
            this.lblTotalInsumos = new System.Windows.Forms.Label();
            this.pnlCardBaixo = new Lanchonete001.UI.RoundedPanel();
            this.pnlIconBaixo = new Lanchonete001.UI.RoundedPanel();
            this.picIconBaixo = new System.Windows.Forms.PictureBox();
            this.lblCaptionBaixo = new System.Windows.Forms.Label();
            this.lblEstoqueBaixo = new System.Windows.Forms.Label();
            this.pnlCardSemEstoque = new Lanchonete001.UI.RoundedPanel();
            this.pnlIconSemEstoque = new Lanchonete001.UI.RoundedPanel();
            this.picIconSemEstoque = new System.Windows.Forms.PictureBox();
            this.lblCaptionSemEstoque = new System.Windows.Forms.Label();
            this.lblSemEstoque = new System.Windows.Forms.Label();
            this.pnlCardValor = new Lanchonete001.UI.RoundedPanel();
            this.pnlIconValor = new Lanchonete001.UI.RoundedPanel();
            this.picIconValor = new System.Windows.Forms.PictureBox();
            this.lblCaptionValor = new System.Windows.Forms.Label();
            this.lblValorEstoque = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.tlpToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.cboFiltroCategoriaInsumo = new System.Windows.Forms.ComboBox();
            this.pnlSearch = new Lanchonete001.UI.RoundedPanel();
            this.txtBuscaInsumo = new System.Windows.Forms.TextBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.btnNovoInsumo = new Lanchonete001.UI.RoundedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlCardTotal.SuspendLayout();
            this.pnlIconTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconTotal)).BeginInit();
            this.pnlCardBaixo.SuspendLayout();
            this.pnlIconBaixo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconBaixo)).BeginInit();
            this.pnlCardSemEstoque.SuspendLayout();
            this.pnlIconSemEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSemEstoque)).BeginInit();
            this.pnlCardValor.SuspendLayout();
            this.pnlIconValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconValor)).BeginInit();
            this.pnlToolbar.SuspendLayout();
            this.tlpToolbar.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.pnlHeader.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderThickness = 0;
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.CornerRadius = 0;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(747, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(302, 23);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Gerencie os insumos do seu estabelecimento";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.lblTitulo.Location = new System.Drawing.Point(32, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 48);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Estoque";
            // 
            // pnlCards
            // 
            this.pnlCards.AutoScroll = true;
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.pnlCards.Controls.Add(this.pnlCardTotal);
            this.pnlCards.Controls.Add(this.pnlCardBaixo);
            this.pnlCards.Controls.Add(this.pnlCardSemEstoque);
            this.pnlCards.Controls.Add(this.pnlCardValor);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 70);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(32, 12, 0, 16);
            this.pnlCards.Size = new System.Drawing.Size(747, 152);
            this.pnlCards.TabIndex = 1;
            this.pnlCards.WrapContents = false;
            // 
            // pnlCardTotal
            // 
            this.pnlCardTotal.BackColor = System.Drawing.Color.White;
            this.pnlCardTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlCardTotal.BorderThickness = 1;
            this.pnlCardTotal.Controls.Add(this.pnlIconTotal);
            this.pnlCardTotal.Controls.Add(this.lblCaptionTotal);
            this.pnlCardTotal.Controls.Add(this.lblTotalInsumos);
            this.pnlCardTotal.CornerRadius = 16;
            this.pnlCardTotal.Location = new System.Drawing.Point(32, 12);
            this.pnlCardTotal.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlCardTotal.Name = "pnlCardTotal";
            this.pnlCardTotal.Size = new System.Drawing.Size(210, 120);
            this.pnlCardTotal.TabIndex = 0;
            // 
            // pnlIconTotal
            // 
            this.pnlIconTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(209)))));
            this.pnlIconTotal.BorderColor = System.Drawing.Color.Transparent;
            this.pnlIconTotal.BorderThickness = 0;
            this.pnlIconTotal.Controls.Add(this.picIconTotal);
            this.pnlIconTotal.CornerRadius = 24;
            this.pnlIconTotal.Location = new System.Drawing.Point(18, 20);
            this.pnlIconTotal.Name = "pnlIconTotal";
            this.pnlIconTotal.Size = new System.Drawing.Size(48, 48);
            this.pnlIconTotal.TabIndex = 0;
            // 
            // picIconTotal
            // 
            this.picIconTotal.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_box_32;
            this.picIconTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconTotal.Location = new System.Drawing.Point(12, 12);
            this.picIconTotal.Name = "picIconTotal";
            this.picIconTotal.Size = new System.Drawing.Size(24, 24);
            this.picIconTotal.TabIndex = 0;
            this.picIconTotal.TabStop = false;
            // 
            // lblCaptionTotal
            // 
            this.lblCaptionTotal.AutoSize = true;
            this.lblCaptionTotal.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCaptionTotal.Location = new System.Drawing.Point(76, 32);
            this.lblCaptionTotal.Name = "lblCaptionTotal";
            this.lblCaptionTotal.Size = new System.Drawing.Size(125, 23);
            this.lblCaptionTotal.TabIndex = 1;
            this.lblCaptionTotal.Text = "Total de Insumos";
            // 
            // lblTotalInsumos
            // 
            this.lblTotalInsumos.AutoSize = true;
            this.lblTotalInsumos.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.lblTotalInsumos.Location = new System.Drawing.Point(18, 74);
            this.lblTotalInsumos.Name = "lblTotalInsumos";
            this.lblTotalInsumos.Size = new System.Drawing.Size(38, 48);
            this.lblTotalInsumos.TabIndex = 2;
            this.lblTotalInsumos.Text = "0";
            // 
            // pnlCardBaixo
            // 
            this.pnlCardBaixo.BackColor = System.Drawing.Color.White;
            this.pnlCardBaixo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlCardBaixo.BorderThickness = 1;
            this.pnlCardBaixo.Controls.Add(this.pnlIconBaixo);
            this.pnlCardBaixo.Controls.Add(this.lblCaptionBaixo);
            this.pnlCardBaixo.Controls.Add(this.lblEstoqueBaixo);
            this.pnlCardBaixo.CornerRadius = 16;
            this.pnlCardBaixo.Location = new System.Drawing.Point(258, 12);
            this.pnlCardBaixo.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlCardBaixo.Name = "pnlCardBaixo";
            this.pnlCardBaixo.Size = new System.Drawing.Size(210, 120);
            this.pnlCardBaixo.TabIndex = 1;
            // 
            // pnlIconBaixo
            // 
            this.pnlIconBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.pnlIconBaixo.BorderColor = System.Drawing.Color.Transparent;
            this.pnlIconBaixo.BorderThickness = 0;
            this.pnlIconBaixo.Controls.Add(this.picIconBaixo);
            this.pnlIconBaixo.CornerRadius = 24;
            this.pnlIconBaixo.Location = new System.Drawing.Point(18, 20);
            this.pnlIconBaixo.Name = "pnlIconBaixo";
            this.pnlIconBaixo.Size = new System.Drawing.Size(48, 48);
            this.pnlIconBaixo.TabIndex = 0;
            // 
            // picIconBaixo
            // 
            this.picIconBaixo.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_error_32;
            this.picIconBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconBaixo.Location = new System.Drawing.Point(12, 12);
            this.picIconBaixo.Name = "picIconBaixo";
            this.picIconBaixo.Size = new System.Drawing.Size(24, 24);
            this.picIconBaixo.TabIndex = 0;
            this.picIconBaixo.TabStop = false;
            // 
            // lblCaptionBaixo
            // 
            this.lblCaptionBaixo.AutoSize = true;
            this.lblCaptionBaixo.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionBaixo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCaptionBaixo.Location = new System.Drawing.Point(76, 32);
            this.lblCaptionBaixo.Name = "lblCaptionBaixo";
            this.lblCaptionBaixo.Size = new System.Drawing.Size(104, 23);
            this.lblCaptionBaixo.TabIndex = 1;
            this.lblCaptionBaixo.Text = "Estoque Baixo";
            // 
            // lblEstoqueBaixo
            // 
            this.lblEstoqueBaixo.AutoSize = true;
            this.lblEstoqueBaixo.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueBaixo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(54)))));
            this.lblEstoqueBaixo.Location = new System.Drawing.Point(18, 74);
            this.lblEstoqueBaixo.Name = "lblEstoqueBaixo";
            this.lblEstoqueBaixo.Size = new System.Drawing.Size(38, 48);
            this.lblEstoqueBaixo.TabIndex = 2;
            this.lblEstoqueBaixo.Text = "0";
            // 
            // pnlCardSemEstoque
            // 
            this.pnlCardSemEstoque.BackColor = System.Drawing.Color.White;
            this.pnlCardSemEstoque.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlCardSemEstoque.BorderThickness = 1;
            this.pnlCardSemEstoque.Controls.Add(this.pnlIconSemEstoque);
            this.pnlCardSemEstoque.Controls.Add(this.lblCaptionSemEstoque);
            this.pnlCardSemEstoque.Controls.Add(this.lblSemEstoque);
            this.pnlCardSemEstoque.CornerRadius = 16;
            this.pnlCardSemEstoque.Location = new System.Drawing.Point(484, 12);
            this.pnlCardSemEstoque.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlCardSemEstoque.Name = "pnlCardSemEstoque";
            this.pnlCardSemEstoque.Size = new System.Drawing.Size(210, 120);
            this.pnlCardSemEstoque.TabIndex = 2;
            // 
            // pnlIconSemEstoque
            // 
            this.pnlIconSemEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.pnlIconSemEstoque.BorderColor = System.Drawing.Color.Transparent;
            this.pnlIconSemEstoque.BorderThickness = 0;
            this.pnlIconSemEstoque.Controls.Add(this.picIconSemEstoque);
            this.pnlIconSemEstoque.CornerRadius = 24;
            this.pnlIconSemEstoque.Location = new System.Drawing.Point(18, 20);
            this.pnlIconSemEstoque.Name = "pnlIconSemEstoque";
            this.pnlIconSemEstoque.Size = new System.Drawing.Size(48, 48);
            this.pnlIconSemEstoque.TabIndex = 0;
            // 
            // picIconSemEstoque
            // 
            this.picIconSemEstoque.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_error_32;
            this.picIconSemEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconSemEstoque.Location = new System.Drawing.Point(12, 12);
            this.picIconSemEstoque.Name = "picIconSemEstoque";
            this.picIconSemEstoque.Size = new System.Drawing.Size(24, 24);
            this.picIconSemEstoque.TabIndex = 0;
            this.picIconSemEstoque.TabStop = false;
            // 
            // lblCaptionSemEstoque
            // 
            this.lblCaptionSemEstoque.AutoSize = true;
            this.lblCaptionSemEstoque.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionSemEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCaptionSemEstoque.Location = new System.Drawing.Point(76, 32);
            this.lblCaptionSemEstoque.Name = "lblCaptionSemEstoque";
            this.lblCaptionSemEstoque.Size = new System.Drawing.Size(96, 23);
            this.lblCaptionSemEstoque.TabIndex = 1;
            this.lblCaptionSemEstoque.Text = "Sem Estoque";
            // 
            // lblSemEstoque
            // 
            this.lblSemEstoque.AutoSize = true;
            this.lblSemEstoque.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.lblSemEstoque.Location = new System.Drawing.Point(18, 74);
            this.lblSemEstoque.Name = "lblSemEstoque";
            this.lblSemEstoque.Size = new System.Drawing.Size(38, 48);
            this.lblSemEstoque.TabIndex = 2;
            this.lblSemEstoque.Text = "0";
            // 
            // pnlCardValor
            // 
            this.pnlCardValor.BackColor = System.Drawing.Color.White;
            this.pnlCardValor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlCardValor.BorderThickness = 1;
            this.pnlCardValor.Controls.Add(this.pnlIconValor);
            this.pnlCardValor.Controls.Add(this.lblCaptionValor);
            this.pnlCardValor.Controls.Add(this.lblValorEstoque);
            this.pnlCardValor.CornerRadius = 16;
            this.pnlCardValor.Location = new System.Drawing.Point(710, 12);
            this.pnlCardValor.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlCardValor.Name = "pnlCardValor";
            this.pnlCardValor.Size = new System.Drawing.Size(210, 120);
            this.pnlCardValor.TabIndex = 3;
            // 
            // pnlIconValor
            // 
            this.pnlIconValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(230)))));
            this.pnlIconValor.BorderColor = System.Drawing.Color.Transparent;
            this.pnlIconValor.BorderThickness = 0;
            this.pnlIconValor.Controls.Add(this.picIconValor);
            this.pnlIconValor.CornerRadius = 24;
            this.pnlIconValor.Location = new System.Drawing.Point(18, 20);
            this.pnlIconValor.Name = "pnlIconValor";
            this.pnlIconValor.Size = new System.Drawing.Size(48, 48);
            this.pnlIconValor.TabIndex = 0;
            // 
            // picIconValor
            // 
            this.picIconValor.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_us_dollar_circled_32;
            this.picIconValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconValor.Location = new System.Drawing.Point(12, 12);
            this.picIconValor.Name = "picIconValor";
            this.picIconValor.Size = new System.Drawing.Size(24, 24);
            this.picIconValor.TabIndex = 0;
            this.picIconValor.TabStop = false;
            // 
            // lblCaptionValor
            // 
            this.lblCaptionValor.AutoSize = true;
            this.lblCaptionValor.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCaptionValor.Location = new System.Drawing.Point(76, 32);
            this.lblCaptionValor.Name = "lblCaptionValor";
            this.lblCaptionValor.Size = new System.Drawing.Size(127, 23);
            this.lblCaptionValor.TabIndex = 1;
            this.lblCaptionValor.Text = "Valor em Estoque";
            // 
            // lblValorEstoque
            // 
            this.lblValorEstoque.AutoSize = true;
            this.lblValorEstoque.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.lblValorEstoque.Location = new System.Drawing.Point(18, 78);
            this.lblValorEstoque.Name = "lblValorEstoque";
            this.lblValorEstoque.Size = new System.Drawing.Size(90, 36);
            this.lblValorEstoque.TabIndex = 2;
            this.lblValorEstoque.Text = "R$ 0,00";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.pnlToolbar.Controls.Add(this.tlpToolbar);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 222);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(32, 8, 32, 12);
            this.pnlToolbar.Size = new System.Drawing.Size(747, 56);
            this.pnlToolbar.TabIndex = 2;
            // 
            // tlpToolbar
            // 
            this.tlpToolbar.ColumnCount = 5;
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpToolbar.Controls.Add(this.cboFiltroCategoriaInsumo, 0, 0);
            this.tlpToolbar.Controls.Add(this.pnlSearch, 2, 0);
            this.tlpToolbar.Controls.Add(this.btnNovoInsumo, 4, 0);
            this.tlpToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpToolbar.Location = new System.Drawing.Point(32, 8);
            this.tlpToolbar.Name = "tlpToolbar";
            this.tlpToolbar.RowCount = 1;
            this.tlpToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToolbar.Size = new System.Drawing.Size(683, 36);
            this.tlpToolbar.TabIndex = 0;
            // 
            // cboFiltroCategoriaInsumo
            // 
            this.cboFiltroCategoriaInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFiltroCategoriaInsumo.BackColor = System.Drawing.Color.White;
            this.cboFiltroCategoriaInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCategoriaInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltroCategoriaInsumo.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroCategoriaInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.cboFiltroCategoriaInsumo.FormattingEnabled = true;
            this.cboFiltroCategoriaInsumo.Location = new System.Drawing.Point(3, 4);
            this.cboFiltroCategoriaInsumo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFiltroCategoriaInsumo.Name = "cboFiltroCategoriaInsumo";
            this.cboFiltroCategoriaInsumo.Size = new System.Drawing.Size(204, 31);
            this.cboFiltroCategoriaInsumo.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlSearch.BorderThickness = 1;
            this.pnlSearch.Controls.Add(this.txtBuscaInsumo);
            this.pnlSearch.Controls.Add(this.picBuscar);
            this.pnlSearch.CornerRadius = 12;
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(226, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(271, 36);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtBuscaInsumo
            // 
            this.txtBuscaInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaInsumo.BackColor = System.Drawing.Color.White;
            this.txtBuscaInsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscaInsumo.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.txtBuscaInsumo.Location = new System.Drawing.Point(44, 9);
            this.txtBuscaInsumo.Name = "txtBuscaInsumo";
            this.txtBuscaInsumo.Size = new System.Drawing.Size(215, 20);
            this.txtBuscaInsumo.TabIndex = 1;
            // 
            // picBuscar
            // 
            this.picBuscar.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_search_25;
            this.picBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBuscar.Location = new System.Drawing.Point(14, 8);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(20, 20);
            this.picBuscar.TabIndex = 0;
            this.picBuscar.TabStop = false;
            // 
            // btnNovoInsumo
            // 
            this.btnNovoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.btnNovoInsumo.CornerRadius = 12;
            this.btnNovoInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoInsumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovoInsumo.FlatAppearance.BorderSize = 0;
            this.btnNovoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoInsumo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoInsumo.ForeColor = System.Drawing.Color.White;
            this.btnNovoInsumo.Location = new System.Drawing.Point(513, 0);
            this.btnNovoInsumo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovoInsumo.Name = "btnNovoInsumo";
            this.btnNovoInsumo.Size = new System.Drawing.Size(170, 36);
            this.btnNovoInsumo.TabIndex = 2;
            this.btnNovoInsumo.Text = "+  Novo Insumo";
            this.btnNovoInsumo.UseVisualStyleBackColor = false;
            this.btnNovoInsumo.Click += new System.EventHandler(this.btnNovoInsumo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 48;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 278);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 52;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 299);
            this.dataGridView1.TabIndex = 3;
            // 
            // UcEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UcEstoque";
            this.Size = new System.Drawing.Size(747, 577);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlCardTotal.ResumeLayout(false);
            this.pnlCardTotal.PerformLayout();
            this.pnlIconTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconTotal)).EndInit();
            this.pnlCardBaixo.ResumeLayout(false);
            this.pnlCardBaixo.PerformLayout();
            this.pnlIconBaixo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconBaixo)).EndInit();
            this.pnlCardSemEstoque.ResumeLayout(false);
            this.pnlCardSemEstoque.PerformLayout();
            this.pnlIconSemEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconSemEstoque)).EndInit();
            this.pnlCardValor.ResumeLayout(false);
            this.pnlCardValor.PerformLayout();
            this.pnlIconValor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconValor)).EndInit();
            this.pnlToolbar.ResumeLayout(false);
            this.tlpToolbar.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Lanchonete001.UI.RoundedPanel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.FlowLayoutPanel pnlCards;

        private Lanchonete001.UI.RoundedPanel pnlCardTotal;
        private Lanchonete001.UI.RoundedPanel pnlIconTotal;
        private System.Windows.Forms.PictureBox picIconTotal;
        private System.Windows.Forms.Label lblCaptionTotal;
        private System.Windows.Forms.Label lblTotalInsumos;

        private Lanchonete001.UI.RoundedPanel pnlCardBaixo;
        private Lanchonete001.UI.RoundedPanel pnlIconBaixo;
        private System.Windows.Forms.PictureBox picIconBaixo;
        private System.Windows.Forms.Label lblCaptionBaixo;
        private System.Windows.Forms.Label lblEstoqueBaixo;

        private Lanchonete001.UI.RoundedPanel pnlCardSemEstoque;
        private Lanchonete001.UI.RoundedPanel pnlIconSemEstoque;
        private System.Windows.Forms.PictureBox picIconSemEstoque;
        private System.Windows.Forms.Label lblCaptionSemEstoque;
        private System.Windows.Forms.Label lblSemEstoque;

        private Lanchonete001.UI.RoundedPanel pnlCardValor;
        private Lanchonete001.UI.RoundedPanel pnlIconValor;
        private System.Windows.Forms.PictureBox picIconValor;
        private System.Windows.Forms.Label lblCaptionValor;
        private System.Windows.Forms.Label lblValorEstoque;

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TableLayoutPanel tlpToolbar;
        private System.Windows.Forms.ComboBox cboFiltroCategoriaInsumo;
        private Lanchonete001.UI.RoundedPanel pnlSearch;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.TextBox txtBuscaInsumo;
        private Lanchonete001.UI.RoundedButton btnNovoInsumo;

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}