using Lanchonete001.UI;

namespace Lanchonete001.Mesas
{
    partial class FrmPedidoMesa
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
            this.pnlHeader = new Lanchonete001.UI.RoundedPanel();
            this.lblTituloMesa = new System.Windows.Forms.Label();
            this.lblStatusDot = new System.Windows.Forms.Label();
            this.lblStatusTexto = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();

            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.btnAdicionarItem = new Lanchonete001.UI.RoundedButton();

            this.pnlListaItens = new System.Windows.Forms.Panel();
            this.lvItens = new System.Windows.Forms.ListView();
            this.colProduto = new System.Windows.Forms.ColumnHeader();
            this.colQuantidade = new System.Windows.Forms.ColumnHeader();
            this.colPrecoUnitario = new System.Windows.Forms.ColumnHeader();
            this.colSubtotal = new System.Windows.Forms.ColumnHeader();
            this.pnlFerramentasItens = new System.Windows.Forms.Panel();
            this.btnDiminuirQtd = new Lanchonete001.UI.RoundedButton();
            this.btnAumentarQtd = new Lanchonete001.UI.RoundedButton();
            this.btnRemoverItem = new Lanchonete001.UI.RoundedButton();
            this.lblItensLancados = new System.Windows.Forms.Label();

            this.pnlTotais = new System.Windows.Forms.Panel();
            this.lblDescontoCaption = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.btnAplicarDesconto = new Lanchonete001.UI.RoundedButton();
            this.lblSubtotalCaption = new System.Windows.Forms.Label();
            this.lblSubtotalValor = new System.Windows.Forms.Label();
            this.lblDescontoValorCaption = new System.Windows.Forms.Label();
            this.lblDescontoValor = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();

            this.pnlAcoes = new System.Windows.Forms.Panel();
            this.flpAcoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTransferirMesa = new Lanchonete001.UI.RoundedButton();
            this.btnDividirConta = new Lanchonete001.UI.RoundedButton();
            this.btnEnviarCozinha = new Lanchonete001.UI.RoundedButton();
            this.btnFecharConta = new Lanchonete001.UI.RoundedButton();

            this.pnlHeader.SuspendLayout();
            this.pnlProdutos.SuspendLayout();
            this.pnlListaItens.SuspendLayout();
            this.pnlFerramentasItens.SuspendLayout();
            this.pnlTotais.SuspendLayout();
            this.pnlAcoes.SuspendLayout();
            this.flpAcoes.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = AppColors.Background;
            this.pnlHeader.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderThickness = 0;
            this.pnlHeader.Controls.Add(this.lblStatusTexto);
            this.pnlHeader.Controls.Add(this.lblStatusDot);
            this.pnlHeader.Controls.Add(this.lblTituloMesa);
            this.pnlHeader.Controls.Add(this.btnFechar);
            this.pnlHeader.CornerRadius = 0;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(860, 70);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTituloMesa
            //
            this.lblTituloMesa.AutoSize = true;
            this.lblTituloMesa.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMesa.ForeColor = AppColors.TextDark;
            this.lblTituloMesa.Location = new System.Drawing.Point(32, 12);
            this.lblTituloMesa.Name = "lblTituloMesa";
            this.lblTituloMesa.Size = new System.Drawing.Size(120, 34);
            this.lblTituloMesa.TabIndex = 0;
            this.lblTituloMesa.Text = "Mesa 00";
            //
            // lblStatusDot
            //
            this.lblStatusDot.AutoSize = true;
            this.lblStatusDot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusDot.Location = new System.Drawing.Point(34, 46);
            this.lblStatusDot.Name = "lblStatusDot";
            this.lblStatusDot.Size = new System.Drawing.Size(15, 20);
            this.lblStatusDot.TabIndex = 1;
            this.lblStatusDot.Text = "●";
            //
            // lblStatusTexto
            //
            this.lblStatusTexto.AutoSize = true;
            this.lblStatusTexto.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTexto.ForeColor = AppColors.TextMuted;
            this.lblStatusTexto.Location = new System.Drawing.Point(52, 46);
            this.lblStatusTexto.Name = "lblStatusTexto";
            this.lblStatusTexto.Size = new System.Drawing.Size(60, 23);
            this.lblStatusTexto.TabIndex = 2;
            this.lblStatusTexto.Text = "Livre";
            //
            // btnFechar
            //
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = AppColors.TextMuted;
            this.btnFechar.Location = new System.Drawing.Point(806, 16);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(38, 38);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "×";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            //
            // pnlProdutos
            //
            this.pnlProdutos.BackColor = AppColors.Background;
            this.pnlProdutos.Controls.Add(this.btnAdicionarItem);
            this.pnlProdutos.Controls.Add(this.cboProdutos);
            this.pnlProdutos.Controls.Add(this.lblProduto);
            this.pnlProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProdutos.Location = new System.Drawing.Point(0, 70);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Padding = new System.Windows.Forms.Padding(32, 12, 32, 12);
            this.pnlProdutos.Size = new System.Drawing.Size(860, 64);
            this.pnlProdutos.TabIndex = 1;
            //
            // lblProduto
            //
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = AppColors.TextDark;
            this.lblProduto.Location = new System.Drawing.Point(32, 20);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(60, 23);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Lanche:";
            //
            // cboProdutos
            //
            this.cboProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdutos.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(100, 17);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(320, 29);
            this.cboProdutos.TabIndex = 1;
            //
            // btnAdicionarItem
            //
            this.btnAdicionarItem.BackColor = AppColors.Primary;
            this.btnAdicionarItem.CornerRadius = 10;
            this.btnAdicionarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarItem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarItem.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItem.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarItem.Location = new System.Drawing.Point(432, 15);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(140, 33);
            this.btnAdicionarItem.TabIndex = 2;
            this.btnAdicionarItem.Text = "+ Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            //
            // pnlListaItens
            //
            this.pnlListaItens.BackColor = AppColors.Background;
            this.pnlListaItens.Controls.Add(this.lvItens);
            this.pnlListaItens.Controls.Add(this.pnlFerramentasItens);
            this.pnlListaItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListaItens.Location = new System.Drawing.Point(0, 134);
            this.pnlListaItens.Name = "pnlListaItens";
            this.pnlListaItens.Padding = new System.Windows.Forms.Padding(32, 8, 32, 8);
            this.pnlListaItens.Size = new System.Drawing.Size(860, 302);
            this.pnlListaItens.TabIndex = 2;
            //
            // pnlFerramentasItens
            //
            this.pnlFerramentasItens.Controls.Add(this.btnRemoverItem);
            this.pnlFerramentasItens.Controls.Add(this.btnAumentarQtd);
            this.pnlFerramentasItens.Controls.Add(this.btnDiminuirQtd);
            this.pnlFerramentasItens.Controls.Add(this.lblItensLancados);
            this.pnlFerramentasItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFerramentasItens.Location = new System.Drawing.Point(32, 8);
            this.pnlFerramentasItens.Name = "pnlFerramentasItens";
            this.pnlFerramentasItens.Size = new System.Drawing.Size(796, 42);
            this.pnlFerramentasItens.TabIndex = 0;
            //
            // lblItensLancados
            //
            this.lblItensLancados.AutoSize = true;
            this.lblItensLancados.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItensLancados.ForeColor = AppColors.TextDark;
            this.lblItensLancados.Location = new System.Drawing.Point(0, 10);
            this.lblItensLancados.Name = "lblItensLancados";
            this.lblItensLancados.Size = new System.Drawing.Size(120, 23);
            this.lblItensLancados.TabIndex = 0;
            this.lblItensLancados.Text = "Itens do pedido";
            //
            // btnDiminuirQtd
            //
            this.btnDiminuirQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiminuirQtd.BackColor = AppColors.Background;
            this.btnDiminuirQtd.CornerRadius = 8;
            this.btnDiminuirQtd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiminuirQtd.FlatAppearance.BorderSize = 1;
            this.btnDiminuirQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiminuirQtd.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirQtd.ForeColor = AppColors.TextDark;
            this.btnDiminuirQtd.Location = new System.Drawing.Point(616, 4);
            this.btnDiminuirQtd.Name = "btnDiminuirQtd";
            this.btnDiminuirQtd.Size = new System.Drawing.Size(34, 34);
            this.btnDiminuirQtd.TabIndex = 1;
            this.btnDiminuirQtd.Text = "-";
            this.btnDiminuirQtd.UseVisualStyleBackColor = false;
            this.btnDiminuirQtd.Click += new System.EventHandler(this.btnDiminuirQtd_Click);
            //
            // btnAumentarQtd
            //
            this.btnAumentarQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAumentarQtd.BackColor = AppColors.Background;
            this.btnAumentarQtd.CornerRadius = 8;
            this.btnAumentarQtd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAumentarQtd.FlatAppearance.BorderSize = 1;
            this.btnAumentarQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumentarQtd.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentarQtd.ForeColor = AppColors.TextDark;
            this.btnAumentarQtd.Location = new System.Drawing.Point(656, 4);
            this.btnAumentarQtd.Name = "btnAumentarQtd";
            this.btnAumentarQtd.Size = new System.Drawing.Size(34, 34);
            this.btnAumentarQtd.TabIndex = 2;
            this.btnAumentarQtd.Text = "+";
            this.btnAumentarQtd.UseVisualStyleBackColor = false;
            this.btnAumentarQtd.Click += new System.EventHandler(this.btnAumentarQtd_Click);
            //
            // btnRemoverItem
            //
            this.btnRemoverItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverItem.BackColor = AppColors.DangerLight;
            this.btnRemoverItem.CornerRadius = 8;
            this.btnRemoverItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverItem.FlatAppearance.BorderSize = 0;
            this.btnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.ForeColor = AppColors.Danger;
            this.btnRemoverItem.Location = new System.Drawing.Point(696, 4);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(100, 34);
            this.btnRemoverItem.TabIndex = 3;
            this.btnRemoverItem.Text = "Remover";
            this.btnRemoverItem.UseVisualStyleBackColor = false;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            //
            // lvItens
            //
            this.lvItens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduto,
            this.colQuantidade,
            this.colPrecoUnitario,
            this.colSubtotal});
            this.lvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvItens.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItens.FullRowSelect = true;
            this.lvItens.GridLines = true;
            this.lvItens.HideSelection = false;
            this.lvItens.Location = new System.Drawing.Point(32, 50);
            this.lvItens.MultiSelect = false;
            this.lvItens.Name = "lvItens";
            this.lvItens.Size = new System.Drawing.Size(796, 244);
            this.lvItens.TabIndex = 1;
            this.lvItens.UseCompatibleStateImageBehavior = false;
            this.lvItens.View = System.Windows.Forms.View.Details;
            //
            // colProduto
            //
            this.colProduto.Text = "Lanche";
            this.colProduto.Width = 340;
            //
            // colQuantidade
            //
            this.colQuantidade.Text = "Qtd";
            this.colQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQuantidade.Width = 80;
            //
            // colPrecoUnitario
            //
            this.colPrecoUnitario.Text = "Preço Unit.";
            this.colPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPrecoUnitario.Width = 150;
            //
            // colSubtotal
            //
            this.colSubtotal.Text = "Subtotal";
            this.colSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSubtotal.Width = 150;
            //
            // pnlTotais
            //
            this.pnlTotais.BackColor = AppColors.Background;
            this.pnlTotais.Controls.Add(this.lblTotalValor);
            this.pnlTotais.Controls.Add(this.lblTotalCaption);
            this.pnlTotais.Controls.Add(this.lblDescontoValor);
            this.pnlTotais.Controls.Add(this.lblDescontoValorCaption);
            this.pnlTotais.Controls.Add(this.lblSubtotalValor);
            this.pnlTotais.Controls.Add(this.lblSubtotalCaption);
            this.pnlTotais.Controls.Add(this.btnAplicarDesconto);
            this.pnlTotais.Controls.Add(this.txtDesconto);
            this.pnlTotais.Controls.Add(this.lblDescontoCaption);
            this.pnlTotais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotais.Location = new System.Drawing.Point(0, 436);
            this.pnlTotais.Name = "pnlTotais";
            this.pnlTotais.Padding = new System.Windows.Forms.Padding(32, 10, 32, 10);
            this.pnlTotais.Size = new System.Drawing.Size(860, 110);
            this.pnlTotais.TabIndex = 3;
            //
            // lblDescontoCaption
            //
            this.lblDescontoCaption.AutoSize = true;
            this.lblDescontoCaption.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoCaption.ForeColor = AppColors.TextDark;
            this.lblDescontoCaption.Location = new System.Drawing.Point(32, 14);
            this.lblDescontoCaption.Name = "lblDescontoCaption";
            this.lblDescontoCaption.Size = new System.Drawing.Size(90, 23);
            this.lblDescontoCaption.TabIndex = 0;
            this.lblDescontoCaption.Text = "Desconto R$:";
            //
            // txtDesconto
            //
            this.txtDesconto.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(150, 12);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 27);
            this.txtDesconto.TabIndex = 1;
            this.txtDesconto.Text = "0,00";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // btnAplicarDesconto
            //
            this.btnAplicarDesconto.BackColor = AppColors.Background;
            this.btnAplicarDesconto.CornerRadius = 10;
            this.btnAplicarDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicarDesconto.FlatAppearance.BorderSize = 1;
            this.btnAplicarDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarDesconto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarDesconto.ForeColor = AppColors.TextDark;
            this.btnAplicarDesconto.Location = new System.Drawing.Point(260, 11);
            this.btnAplicarDesconto.Name = "btnAplicarDesconto";
            this.btnAplicarDesconto.Size = new System.Drawing.Size(100, 30);
            this.btnAplicarDesconto.TabIndex = 2;
            this.btnAplicarDesconto.Text = "Aplicar";
            this.btnAplicarDesconto.UseVisualStyleBackColor = false;
            this.btnAplicarDesconto.Click += new System.EventHandler(this.btnAplicarDesconto_Click);
            //
            // lblSubtotalCaption
            //
            this.lblSubtotalCaption.AutoSize = true;
            this.lblSubtotalCaption.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalCaption.ForeColor = AppColors.TextMuted;
            this.lblSubtotalCaption.Location = new System.Drawing.Point(430, 12);
            this.lblSubtotalCaption.Name = "lblSubtotalCaption";
            this.lblSubtotalCaption.Size = new System.Drawing.Size(75, 23);
            this.lblSubtotalCaption.TabIndex = 3;
            this.lblSubtotalCaption.Text = "Subtotal:";
            //
            // lblSubtotalValor
            //
            this.lblSubtotalValor.AutoSize = true;
            this.lblSubtotalValor.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalValor.ForeColor = AppColors.TextDark;
            this.lblSubtotalValor.Location = new System.Drawing.Point(514, 12);
            this.lblSubtotalValor.Name = "lblSubtotalValor";
            this.lblSubtotalValor.Size = new System.Drawing.Size(90, 23);
            this.lblSubtotalValor.TabIndex = 4;
            this.lblSubtotalValor.Text = "R$ 0,00";
            //
            // lblDescontoValorCaption
            //
            this.lblDescontoValorCaption.AutoSize = true;
            this.lblDescontoValorCaption.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoValorCaption.ForeColor = AppColors.TextMuted;
            this.lblDescontoValorCaption.Location = new System.Drawing.Point(430, 40);
            this.lblDescontoValorCaption.Name = "lblDescontoValorCaption";
            this.lblDescontoValorCaption.Size = new System.Drawing.Size(75, 23);
            this.lblDescontoValorCaption.TabIndex = 5;
            this.lblDescontoValorCaption.Text = "Desconto:";
            //
            // lblDescontoValor
            //
            this.lblDescontoValor.AutoSize = true;
            this.lblDescontoValor.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoValor.ForeColor = AppColors.Danger;
            this.lblDescontoValor.Location = new System.Drawing.Point(514, 40);
            this.lblDescontoValor.Name = "lblDescontoValor";
            this.lblDescontoValor.Size = new System.Drawing.Size(90, 23);
            this.lblDescontoValor.TabIndex = 6;
            this.lblDescontoValor.Text = "R$ 0,00";
            //
            // lblTotalCaption
            //
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCaption.ForeColor = AppColors.TextDark;
            this.lblTotalCaption.Location = new System.Drawing.Point(650, 20);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(60, 26);
            this.lblTotalCaption.TabIndex = 7;
            this.lblTotalCaption.Text = "Total:";
            //
            // lblTotalValor
            //
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.ForeColor = AppColors.Success;
            this.lblTotalValor.Location = new System.Drawing.Point(716, 16);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(110, 32);
            this.lblTotalValor.TabIndex = 8;
            this.lblTotalValor.Text = "R$ 0,00";
            //
            // pnlAcoes
            //
            this.pnlAcoes.BackColor = AppColors.Background;
            this.pnlAcoes.Controls.Add(this.flpAcoes);
            this.pnlAcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcoes.Location = new System.Drawing.Point(0, 546);
            this.pnlAcoes.Name = "pnlAcoes";
            this.pnlAcoes.Padding = new System.Windows.Forms.Padding(32, 12, 32, 12);
            this.pnlAcoes.Size = new System.Drawing.Size(860, 68);
            this.pnlAcoes.TabIndex = 4;
            //
            // flpAcoes
            //
            this.flpAcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcoes.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpAcoes.Controls.Add(this.btnTransferirMesa);
            this.flpAcoes.Controls.Add(this.btnDividirConta);
            this.flpAcoes.Controls.Add(this.btnEnviarCozinha);
            this.flpAcoes.Controls.Add(this.btnFecharConta);
            this.flpAcoes.Location = new System.Drawing.Point(32, 12);
            this.flpAcoes.Name = "flpAcoes";
            this.flpAcoes.Size = new System.Drawing.Size(796, 44);
            this.flpAcoes.TabIndex = 0;
            this.flpAcoes.WrapContents = false;
            //
            // btnTransferirMesa
            //
            this.btnTransferirMesa.BackColor = AppColors.Background;
            this.btnTransferirMesa.CornerRadius = 10;
            this.btnTransferirMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferirMesa.FlatAppearance.BorderSize = 1;
            this.btnTransferirMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferirMesa.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferirMesa.ForeColor = AppColors.TextDark;
            this.btnTransferirMesa.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnTransferirMesa.Name = "btnTransferirMesa";
            this.btnTransferirMesa.Size = new System.Drawing.Size(140, 40);
            this.btnTransferirMesa.TabIndex = 0;
            this.btnTransferirMesa.Text = "Transferir Mesa";
            this.btnTransferirMesa.UseVisualStyleBackColor = false;
            this.btnTransferirMesa.Click += new System.EventHandler(this.btnTransferirMesa_Click);
            //
            // btnDividirConta
            //
            this.btnDividirConta.BackColor = AppColors.Background;
            this.btnDividirConta.CornerRadius = 10;
            this.btnDividirConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividirConta.FlatAppearance.BorderSize = 1;
            this.btnDividirConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividirConta.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividirConta.ForeColor = AppColors.TextDark;
            this.btnDividirConta.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnDividirConta.Name = "btnDividirConta";
            this.btnDividirConta.Size = new System.Drawing.Size(130, 40);
            this.btnDividirConta.TabIndex = 1;
            this.btnDividirConta.Text = "Dividir Conta";
            this.btnDividirConta.UseVisualStyleBackColor = false;
            this.btnDividirConta.Click += new System.EventHandler(this.btnDividirConta_Click);
            //
            // btnEnviarCozinha
            //
            this.btnEnviarCozinha.BackColor = AppColors.Primary;
            this.btnEnviarCozinha.CornerRadius = 10;
            this.btnEnviarCozinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarCozinha.FlatAppearance.BorderSize = 0;
            this.btnEnviarCozinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCozinha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCozinha.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCozinha.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnEnviarCozinha.Name = "btnEnviarCozinha";
            this.btnEnviarCozinha.Size = new System.Drawing.Size(160, 40);
            this.btnEnviarCozinha.TabIndex = 2;
            this.btnEnviarCozinha.Text = "Enviar para Cozinha";
            this.btnEnviarCozinha.UseVisualStyleBackColor = false;
            this.btnEnviarCozinha.Click += new System.EventHandler(this.btnEnviarCozinha_Click);
            //
            // btnFecharConta
            //
            this.btnFecharConta.BackColor = AppColors.Success;
            this.btnFecharConta.CornerRadius = 10;
            this.btnFecharConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharConta.FlatAppearance.BorderSize = 0;
            this.btnFecharConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharConta.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharConta.ForeColor = System.Drawing.Color.White;
            this.btnFecharConta.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnFecharConta.Name = "btnFecharConta";
            this.btnFecharConta.Size = new System.Drawing.Size(140, 40);
            this.btnFecharConta.TabIndex = 3;
            this.btnFecharConta.Text = "Fechar Conta";
            this.btnFecharConta.UseVisualStyleBackColor = false;
            this.btnFecharConta.Click += new System.EventHandler(this.btnFecharConta_Click);
            
            //
            // FrmPedidoMesa
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppColors.Background;
            this.ClientSize = new System.Drawing.Size(860, 614);
            this.Controls.Add(this.pnlListaItens);
            this.Controls.Add(this.pnlTotais);
            this.Controls.Add(this.pnlAcoes);
            this.Controls.Add(this.pnlProdutos);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidoMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedido da Mesa";
            this.Load += new System.EventHandler(this.FrmPedidoMesa_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlProdutos.ResumeLayout(false);
            this.pnlProdutos.PerformLayout();
            this.pnlListaItens.ResumeLayout(false);
            this.pnlFerramentasItens.ResumeLayout(false);
            this.pnlFerramentasItens.PerformLayout();
            this.pnlTotais.ResumeLayout(false);
            this.pnlTotais.PerformLayout();
            this.pnlAcoes.ResumeLayout(false);
            this.flpAcoes.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Lanchonete001.UI.RoundedPanel pnlHeader;
        private System.Windows.Forms.Label lblTituloMesa;
        private System.Windows.Forms.Label lblStatusDot;
        private System.Windows.Forms.Label lblStatusTexto;
        private System.Windows.Forms.Button btnFechar;

        private System.Windows.Forms.Panel pnlProdutos;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox cboProdutos;
        private Lanchonete001.UI.RoundedButton btnAdicionarItem;

        private System.Windows.Forms.Panel pnlListaItens;
        private System.Windows.Forms.Panel pnlFerramentasItens;
        private System.Windows.Forms.Label lblItensLancados;
        private Lanchonete001.UI.RoundedButton btnDiminuirQtd;
        private Lanchonete001.UI.RoundedButton btnAumentarQtd;
        private Lanchonete001.UI.RoundedButton btnRemoverItem;
        private System.Windows.Forms.ListView lvItens;
        private System.Windows.Forms.ColumnHeader colProduto;
        private System.Windows.Forms.ColumnHeader colQuantidade;
        private System.Windows.Forms.ColumnHeader colPrecoUnitario;
        private System.Windows.Forms.ColumnHeader colSubtotal;

        private System.Windows.Forms.Panel pnlTotais;
        private System.Windows.Forms.Label lblDescontoCaption;
        private System.Windows.Forms.TextBox txtDesconto;
        private Lanchonete001.UI.RoundedButton btnAplicarDesconto;
        private System.Windows.Forms.Label lblSubtotalCaption;
        private System.Windows.Forms.Label lblSubtotalValor;
        private System.Windows.Forms.Label lblDescontoValorCaption;
        private System.Windows.Forms.Label lblDescontoValor;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalValor;

        private System.Windows.Forms.Panel pnlAcoes;
        private System.Windows.Forms.FlowLayoutPanel flpAcoes;
        private Lanchonete001.UI.RoundedButton btnTransferirMesa;
        private Lanchonete001.UI.RoundedButton btnDividirConta;
        private Lanchonete001.UI.RoundedButton btnEnviarCozinha;
        private Lanchonete001.UI.RoundedButton btnFecharConta;
    }
}