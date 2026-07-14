using Lanchonete001.UI;

namespace Lanchonete001.Mesas
{
    partial class FrmFecharConta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMesaInfo = new System.Windows.Forms.Label();

            this.pnlListaItens = new System.Windows.Forms.Panel();
            this.lvResumoItens = new System.Windows.Forms.ListView();
            this.colProdutoR = new System.Windows.Forms.ColumnHeader();
            this.colQtdR = new System.Windows.Forms.ColumnHeader();
            this.colPrecoR = new System.Windows.Forms.ColumnHeader();
            this.colSubtotalR = new System.Windows.Forms.ColumnHeader();

            this.pnlTotais = new System.Windows.Forms.Panel();
            this.lblSubtotalCaption = new System.Windows.Forms.Label();
            this.lblSubtotalValor = new System.Windows.Forms.Label();
            this.lblDescontoCaption = new System.Windows.Forms.Label();
            this.lblDescontoValor = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();

            this.pnlPagamento = new System.Windows.Forms.Panel();
            this.lblFormaPagamentoCaption = new System.Windows.Forms.Label();
            this.flpFormaPagamento = new System.Windows.Forms.FlowLayoutPanel();
            this.rbDinheiro = new System.Windows.Forms.RadioButton();
            this.rbCartaoDebito = new System.Windows.Forms.RadioButton();
            this.rbCartaoCredito = new System.Windows.Forms.RadioButton();
            this.rbPix = new System.Windows.Forms.RadioButton();

            this.pnlDinheiro = new System.Windows.Forms.Panel();
            this.lblValorRecebidoCaption = new System.Windows.Forms.Label();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.lblTrocoCaption = new System.Windows.Forms.Label();
            this.lblTrocoValor = new System.Windows.Forms.Label();

            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnConfirmar = new Lanchonete001.UI.RoundedButton();
            this.btnCancelar = new Lanchonete001.UI.RoundedButton();

            this.pnlHeader.SuspendLayout();
            this.pnlListaItens.SuspendLayout();
            this.pnlTotais.SuspendLayout();
            this.pnlPagamento.SuspendLayout();
            this.flpFormaPagamento.SuspendLayout();
            this.pnlDinheiro.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = AppColors.Background;
            this.pnlHeader.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderThickness = 0;
            this.pnlHeader.Controls.Add(this.lblMesaInfo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.CornerRadius = 0;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(480, 64);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = AppColors.TextDark;
            this.lblTitulo.Location = new System.Drawing.Point(24, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Fechar Conta";
            //
            // lblMesaInfo
            //
            this.lblMesaInfo.AutoSize = true;
            this.lblMesaInfo.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaInfo.ForeColor = AppColors.TextMuted;
            this.lblMesaInfo.Location = new System.Drawing.Point(25, 38);
            this.lblMesaInfo.Name = "lblMesaInfo";
            this.lblMesaInfo.Size = new System.Drawing.Size(90, 23);
            this.lblMesaInfo.TabIndex = 1;
            this.lblMesaInfo.Text = "Mesa 00";
            //
            // pnlListaItens
            //
            this.pnlListaItens.BackColor = AppColors.Background;
            this.pnlListaItens.Controls.Add(this.lvResumoItens);
            this.pnlListaItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListaItens.Location = new System.Drawing.Point(0, 64);
            this.pnlListaItens.Name = "pnlListaItens";
            this.pnlListaItens.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
            this.pnlListaItens.Size = new System.Drawing.Size(480, 190);
            this.pnlListaItens.TabIndex = 1;
            //
            // lvResumoItens
            //
            this.lvResumoItens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProdutoR,
            this.colQtdR,
            this.colPrecoR,
            this.colSubtotalR});
            this.lvResumoItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResumoItens.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResumoItens.FullRowSelect = true;
            this.lvResumoItens.GridLines = true;
            this.lvResumoItens.Location = new System.Drawing.Point(24, 8);
            this.lvResumoItens.MultiSelect = false;
            this.lvResumoItens.Name = "lvResumoItens";
            this.lvResumoItens.Size = new System.Drawing.Size(432, 174);
            this.lvResumoItens.TabIndex = 0;
            this.lvResumoItens.UseCompatibleStateImageBehavior = false;
            this.lvResumoItens.View = System.Windows.Forms.View.Details;
            //
            // colProdutoR
            //
            this.colProdutoR.Text = "Lanche";
            this.colProdutoR.Width = 190;
            //
            // colQtdR
            //
            this.colQtdR.Text = "Qtd";
            this.colQtdR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQtdR.Width = 60;
            //
            // colPrecoR
            //
            this.colPrecoR.Text = "Preço Unit.";
            this.colPrecoR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPrecoR.Width = 90;
            //
            // colSubtotalR
            //
            this.colSubtotalR.Text = "Subtotal";
            this.colSubtotalR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSubtotalR.Width = 90;
            //
            // pnlTotais
            //
            this.pnlTotais.BackColor = AppColors.Background;
            this.pnlTotais.Controls.Add(this.lblTotalValor);
            this.pnlTotais.Controls.Add(this.lblTotalCaption);
            this.pnlTotais.Controls.Add(this.lblDescontoValor);
            this.pnlTotais.Controls.Add(this.lblDescontoCaption);
            this.pnlTotais.Controls.Add(this.lblSubtotalValor);
            this.pnlTotais.Controls.Add(this.lblSubtotalCaption);
            this.pnlTotais.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTotais.Location = new System.Drawing.Point(0, 254);
            this.pnlTotais.Name = "pnlTotais";
            this.pnlTotais.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
            this.pnlTotais.Size = new System.Drawing.Size(480, 92);
            this.pnlTotais.TabIndex = 2;
            //
            // lblSubtotalCaption
            //
            this.lblSubtotalCaption.AutoSize = true;
            this.lblSubtotalCaption.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalCaption.ForeColor = AppColors.TextMuted;
            this.lblSubtotalCaption.Location = new System.Drawing.Point(24, 8);
            this.lblSubtotalCaption.Name = "lblSubtotalCaption";
            this.lblSubtotalCaption.Size = new System.Drawing.Size(75, 23);
            this.lblSubtotalCaption.TabIndex = 0;
            this.lblSubtotalCaption.Text = "Subtotal:";
            //
            // lblSubtotalValor
            //
            this.lblSubtotalValor.AutoSize = true;
            this.lblSubtotalValor.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalValor.ForeColor = AppColors.TextDark;
            this.lblSubtotalValor.Location = new System.Drawing.Point(360, 8);
            this.lblSubtotalValor.Name = "lblSubtotalValor";
            this.lblSubtotalValor.Size = new System.Drawing.Size(90, 23);
            this.lblSubtotalValor.TabIndex = 1;
            this.lblSubtotalValor.Text = "R$ 0,00";
            //
            // lblDescontoCaption
            //
            this.lblDescontoCaption.AutoSize = true;
            this.lblDescontoCaption.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoCaption.ForeColor = AppColors.TextMuted;
            this.lblDescontoCaption.Location = new System.Drawing.Point(24, 34);
            this.lblDescontoCaption.Name = "lblDescontoCaption";
            this.lblDescontoCaption.Size = new System.Drawing.Size(75, 23);
            this.lblDescontoCaption.TabIndex = 2;
            this.lblDescontoCaption.Text = "Desconto:";
            //
            // lblDescontoValor
            //
            this.lblDescontoValor.AutoSize = true;
            this.lblDescontoValor.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoValor.ForeColor = AppColors.Danger;
            this.lblDescontoValor.Location = new System.Drawing.Point(360, 34);
            this.lblDescontoValor.Name = "lblDescontoValor";
            this.lblDescontoValor.Size = new System.Drawing.Size(90, 23);
            this.lblDescontoValor.TabIndex = 3;
            this.lblDescontoValor.Text = "R$ 0,00";
            //
            // lblTotalCaption
            //
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCaption.ForeColor = AppColors.TextDark;
            this.lblTotalCaption.Location = new System.Drawing.Point(24, 62);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(60, 26);
            this.lblTotalCaption.TabIndex = 4;
            this.lblTotalCaption.Text = "Total:";
            //
            // lblTotalValor
            //
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.ForeColor = AppColors.Success;
            this.lblTotalValor.Location = new System.Drawing.Point(320, 58);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(110, 32);
            this.lblTotalValor.TabIndex = 5;
            this.lblTotalValor.Text = "R$ 0,00";
            //
            // pnlPagamento
            //
            this.pnlPagamento.BackColor = AppColors.Background;
            this.pnlPagamento.Controls.Add(this.flpFormaPagamento);
            this.pnlPagamento.Controls.Add(this.lblFormaPagamentoCaption);
            this.pnlPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPagamento.Location = new System.Drawing.Point(0, 346);
            this.pnlPagamento.Name = "pnlPagamento";
            this.pnlPagamento.Padding = new System.Windows.Forms.Padding(24, 10, 24, 4);
            this.pnlPagamento.Size = new System.Drawing.Size(480, 108);
            this.pnlPagamento.TabIndex = 3;
            //
            // lblFormaPagamentoCaption
            //
            this.lblFormaPagamentoCaption.AutoSize = true;
            this.lblFormaPagamentoCaption.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagamentoCaption.ForeColor = AppColors.TextDark;
            this.lblFormaPagamentoCaption.Location = new System.Drawing.Point(24, 10);
            this.lblFormaPagamentoCaption.Name = "lblFormaPagamentoCaption";
            this.lblFormaPagamentoCaption.Size = new System.Drawing.Size(150, 23);
            this.lblFormaPagamentoCaption.TabIndex = 0;
            this.lblFormaPagamentoCaption.Text = "Forma de pagamento:";
            //
            // flpFormaPagamento
            //
            this.flpFormaPagamento.Controls.Add(this.rbDinheiro);
            this.flpFormaPagamento.Controls.Add(this.rbCartaoDebito);
            this.flpFormaPagamento.Controls.Add(this.rbCartaoCredito);
            this.flpFormaPagamento.Controls.Add(this.rbPix);
            this.flpFormaPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpFormaPagamento.Location = new System.Drawing.Point(24, 36);
            this.flpFormaPagamento.Name = "flpFormaPagamento";
            this.flpFormaPagamento.Size = new System.Drawing.Size(432, 66);
            this.flpFormaPagamento.TabIndex = 1;
            this.flpFormaPagamento.WrapContents = true;
            //
            // rbDinheiro
            //
            this.rbDinheiro.AutoSize = true;
            this.rbDinheiro.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDinheiro.Margin = new System.Windows.Forms.Padding(0, 0, 24, 12);
            this.rbDinheiro.Name = "rbDinheiro";
            this.rbDinheiro.Size = new System.Drawing.Size(90, 27);
            this.rbDinheiro.TabIndex = 0;
            this.rbDinheiro.Text = "Dinheiro";
            this.rbDinheiro.UseVisualStyleBackColor = true;
            this.rbDinheiro.CheckedChanged += new System.EventHandler(this.rbFormaPagamento_CheckedChanged);
            //
            // rbCartaoDebito
            //
            this.rbCartaoDebito.AutoSize = true;
            this.rbCartaoDebito.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCartaoDebito.Margin = new System.Windows.Forms.Padding(0, 0, 24, 12);
            this.rbCartaoDebito.Name = "rbCartaoDebito";
            this.rbCartaoDebito.Size = new System.Drawing.Size(150, 27);
            this.rbCartaoDebito.TabIndex = 1;
            this.rbCartaoDebito.Text = "Cartão de Débito";
            this.rbCartaoDebito.UseVisualStyleBackColor = true;
            this.rbCartaoDebito.CheckedChanged += new System.EventHandler(this.rbFormaPagamento_CheckedChanged);
            //
            // rbCartaoCredito
            //
            this.rbCartaoCredito.AutoSize = true;
            this.rbCartaoCredito.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCartaoCredito.Margin = new System.Windows.Forms.Padding(0, 0, 24, 12);
            this.rbCartaoCredito.Name = "rbCartaoCredito";
            this.rbCartaoCredito.Size = new System.Drawing.Size(150, 27);
            this.rbCartaoCredito.TabIndex = 2;
            this.rbCartaoCredito.Text = "Cartão de Crédito";
            this.rbCartaoCredito.UseVisualStyleBackColor = true;
            this.rbCartaoCredito.CheckedChanged += new System.EventHandler(this.rbFormaPagamento_CheckedChanged);
            //
            // rbPix
            //
            this.rbPix.AutoSize = true;
            this.rbPix.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPix.Margin = new System.Windows.Forms.Padding(0, 0, 24, 12);
            this.rbPix.Name = "rbPix";
            this.rbPix.Size = new System.Drawing.Size(60, 27);
            this.rbPix.TabIndex = 3;
            this.rbPix.Text = "Pix";
            this.rbPix.UseVisualStyleBackColor = true;
            this.rbPix.CheckedChanged += new System.EventHandler(this.rbFormaPagamento_CheckedChanged);
            //
            // pnlDinheiro
            //
            this.pnlDinheiro.BackColor = AppColors.SuccessLight;
            this.pnlDinheiro.Controls.Add(this.lblTrocoValor);
            this.pnlDinheiro.Controls.Add(this.lblTrocoCaption);
            this.pnlDinheiro.Controls.Add(this.txtValorRecebido);
            this.pnlDinheiro.Controls.Add(this.lblValorRecebidoCaption);
            this.pnlDinheiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDinheiro.Location = new System.Drawing.Point(0, 454);
            this.pnlDinheiro.Name = "pnlDinheiro";
            this.pnlDinheiro.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
            this.pnlDinheiro.Size = new System.Drawing.Size(480, 82);
            this.pnlDinheiro.TabIndex = 4;
            //
            // lblValorRecebidoCaption
            //
            this.lblValorRecebidoCaption.AutoSize = true;
            this.lblValorRecebidoCaption.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRecebidoCaption.ForeColor = AppColors.TextDark;
            this.lblValorRecebidoCaption.Location = new System.Drawing.Point(24, 12);
            this.lblValorRecebidoCaption.Name = "lblValorRecebidoCaption";
            this.lblValorRecebidoCaption.Size = new System.Drawing.Size(120, 23);
            this.lblValorRecebidoCaption.TabIndex = 0;
            this.lblValorRecebidoCaption.Text = "Valor recebido R$:";
            //
            // txtValorRecebido
            //
            this.txtValorRecebido.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRecebido.Location = new System.Drawing.Point(190, 10);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(100, 27);
            this.txtValorRecebido.TabIndex = 1;
            this.txtValorRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorRecebido.Text = "0,00";
            this.txtValorRecebido.TextChanged += new System.EventHandler(this.txtValorRecebido_TextChanged);
            //
            // lblTrocoCaption
            //
            this.lblTrocoCaption.AutoSize = true;
            this.lblTrocoCaption.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocoCaption.ForeColor = AppColors.TextDark;
            this.lblTrocoCaption.Location = new System.Drawing.Point(320, 12);
            this.lblTrocoCaption.Name = "lblTrocoCaption";
            this.lblTrocoCaption.Size = new System.Drawing.Size(55, 24);
            this.lblTrocoCaption.TabIndex = 2;
            this.lblTrocoCaption.Text = "Troco:";
            //
            // lblTrocoValor
            //
            this.lblTrocoValor.AutoSize = true;
            this.lblTrocoValor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocoValor.ForeColor = AppColors.Success;
            this.lblTrocoValor.Location = new System.Drawing.Point(378, 8);
            this.lblTrocoValor.Name = "lblTrocoValor";
            this.lblTrocoValor.Size = new System.Drawing.Size(90, 30);
            this.lblTrocoValor.TabIndex = 3;
            this.lblTrocoValor.Text = "R$ 0,00";
            //
            // pnlRodape
            //
            this.pnlRodape.BackColor = AppColors.Background;
            this.pnlRodape.Controls.Add(this.btnConfirmar);
            this.pnlRodape.Controls.Add(this.btnCancelar);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 536);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.pnlRodape.Size = new System.Drawing.Size(480, 64);
            this.pnlRodape.TabIndex = 5;
            //
            // btnCancelar
            //
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = AppColors.Background;
            this.btnCancelar.CornerRadius = 10;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 1;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = AppColors.TextDark;
            this.btnCancelar.Location = new System.Drawing.Point(184, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 38);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnConfirmar
            //
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackColor = AppColors.Success;
            this.btnConfirmar.CornerRadius = 10;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(304, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 38);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar Fechamento";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            //
            // FrmFecharConta
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppColors.Background;
            this.ClientSize = new System.Drawing.Size(480, 600);
            this.Controls.Add(this.pnlDinheiro);
            this.Controls.Add(this.pnlPagamento);
            this.Controls.Add(this.pnlTotais);
            this.Controls.Add(this.pnlListaItens);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFecharConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fechar Conta";
            this.Load += new System.EventHandler(this.FrmFecharConta_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlListaItens.ResumeLayout(false);
            this.pnlTotais.ResumeLayout(false);
            this.pnlTotais.PerformLayout();
            this.pnlPagamento.ResumeLayout(false);
            this.pnlPagamento.PerformLayout();
            this.flpFormaPagamento.ResumeLayout(false);
            this.flpFormaPagamento.PerformLayout();
            this.pnlDinheiro.ResumeLayout(false);
            this.pnlDinheiro.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Lanchonete001.UI.RoundedPanel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMesaInfo;

        private System.Windows.Forms.Panel pnlListaItens;
        private System.Windows.Forms.ListView lvResumoItens;
        private System.Windows.Forms.ColumnHeader colProdutoR;
        private System.Windows.Forms.ColumnHeader colQtdR;
        private System.Windows.Forms.ColumnHeader colPrecoR;
        private System.Windows.Forms.ColumnHeader colSubtotalR;

        private System.Windows.Forms.Panel pnlTotais;
        private System.Windows.Forms.Label lblSubtotalCaption;
        private System.Windows.Forms.Label lblSubtotalValor;
        private System.Windows.Forms.Label lblDescontoCaption;
        private System.Windows.Forms.Label lblDescontoValor;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalValor;

        private System.Windows.Forms.Panel pnlPagamento;
        private System.Windows.Forms.Label lblFormaPagamentoCaption;
        private System.Windows.Forms.FlowLayoutPanel flpFormaPagamento;
        private System.Windows.Forms.RadioButton rbDinheiro;
        private System.Windows.Forms.RadioButton rbCartaoDebito;
        private System.Windows.Forms.RadioButton rbCartaoCredito;
        private System.Windows.Forms.RadioButton rbPix;

        private System.Windows.Forms.Panel pnlDinheiro;
        private System.Windows.Forms.Label lblValorRecebidoCaption;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.Label lblTrocoCaption;
        private System.Windows.Forms.Label lblTrocoValor;

        private System.Windows.Forms.Panel pnlRodape;
        private Lanchonete001.UI.RoundedButton btnConfirmar;
        private Lanchonete001.UI.RoundedButton btnCancelar;
    }
}