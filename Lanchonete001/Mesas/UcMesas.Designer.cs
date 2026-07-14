using Lanchonete001.UI;

namespace Lanchonete001.Mesas
{
    partial class UcMesas
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblQuantidadeMesas = new System.Windows.Forms.Label();
            this.numQuantidadeMesas = new System.Windows.Forms.NumericUpDown();
            this.btnAplicarQuantidade = new Lanchonete001.UI.RoundedButton();
            this.lblIconePesquisa = new System.Windows.Forms.Label();
            this.txtPesquisarMesa = new System.Windows.Forms.TextBox();

            this.pnlAreaMesas = new System.Windows.Forms.Panel();
            this.pnlGradeMesas = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeMesas)).BeginInit();
            this.pnlAreaMesas.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = AppColors.Background;
            this.pnlHeader.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderThickness = 0;
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.CornerRadius = 0;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 70);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = AppColors.TextDark;
            this.lblTitulo.Location = new System.Drawing.Point(32, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 48);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Mesas";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = AppColors.TextMuted;
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(420, 23);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Acompanhe e gerencie os pedidos de cada mesa em tempo real";
            //
            // pnlToolbar
            //
            this.pnlToolbar.BackColor = AppColors.Background;
            this.pnlToolbar.Controls.Add(this.txtPesquisarMesa);
            this.pnlToolbar.Controls.Add(this.lblIconePesquisa);
            this.pnlToolbar.Controls.Add(this.btnAplicarQuantidade);
            this.pnlToolbar.Controls.Add(this.numQuantidadeMesas);
            this.pnlToolbar.Controls.Add(this.lblQuantidadeMesas);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 70);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(32, 12, 32, 12);
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 64);
            this.pnlToolbar.TabIndex = 1;
            //
            // lblQuantidadeMesas
            //
            this.lblQuantidadeMesas.AutoSize = true;
            this.lblQuantidadeMesas.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeMesas.ForeColor = AppColors.TextDark;
            this.lblQuantidadeMesas.Location = new System.Drawing.Point(32, 20);
            this.lblQuantidadeMesas.Name = "lblQuantidadeMesas";
            this.lblQuantidadeMesas.Size = new System.Drawing.Size(160, 23);
            this.lblQuantidadeMesas.TabIndex = 0;
            this.lblQuantidadeMesas.Text = "Quantidade de mesas:";
            //
            // numQuantidadeMesas
            //
            this.numQuantidadeMesas.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidadeMesas.Location = new System.Drawing.Point(200, 18);
            this.numQuantidadeMesas.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            this.numQuantidadeMesas.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numQuantidadeMesas.Name = "numQuantidadeMesas";
            this.numQuantidadeMesas.Size = new System.Drawing.Size(80, 27);
            this.numQuantidadeMesas.TabIndex = 1;
            this.numQuantidadeMesas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // btnAplicarQuantidade
            //
            this.btnAplicarQuantidade.BackColor = AppColors.Primary;
            this.btnAplicarQuantidade.CornerRadius = 10;
            this.btnAplicarQuantidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicarQuantidade.FlatAppearance.BorderSize = 0;
            this.btnAplicarQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarQuantidade.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarQuantidade.ForeColor = System.Drawing.Color.White;
            this.btnAplicarQuantidade.Location = new System.Drawing.Point(292, 16);
            this.btnAplicarQuantidade.Name = "btnAplicarQuantidade";
            this.btnAplicarQuantidade.Size = new System.Drawing.Size(110, 32);
            this.btnAplicarQuantidade.TabIndex = 2;
            this.btnAplicarQuantidade.Text = "Aplicar";
            this.btnAplicarQuantidade.UseVisualStyleBackColor = false;
            this.btnAplicarQuantidade.Click += new System.EventHandler(this.btnAplicarQuantidade_Click);
            //
            // lblIconePesquisa
            //
            this.lblIconePesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconePesquisa.AutoSize = true;
            this.lblIconePesquisa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIconePesquisa.ForeColor = AppColors.TextMuted;
            this.lblIconePesquisa.Location = new System.Drawing.Point(788, 20);
            this.lblIconePesquisa.Name = "lblIconePesquisa";
            this.lblIconePesquisa.Size = new System.Drawing.Size(20, 25);
            this.lblIconePesquisa.TabIndex = 3;
            this.lblIconePesquisa.Text = "🔍";
            //
            // txtPesquisarMesa
            //
            this.txtPesquisarMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarMesa.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarMesa.Location = new System.Drawing.Point(816, 17);
            this.txtPesquisarMesa.Name = "txtPesquisarMesa";
            this.txtPesquisarMesa.Size = new System.Drawing.Size(252, 27);
            this.txtPesquisarMesa.TabIndex = 4;
            this.txtPesquisarMesa.TextChanged += new System.EventHandler(this.txtPesquisarMesa_TextChanged);
            this.txtPesquisarMesa.Enter += new System.EventHandler(this.txtPesquisarMesa_Enter);
            this.txtPesquisarMesa.Leave += new System.EventHandler(this.txtPesquisarMesa_Leave);
            //
            // pnlAreaMesas
            //
            this.pnlAreaMesas.AutoScroll = true;
            this.pnlAreaMesas.BackColor = AppColors.Background;
            this.pnlAreaMesas.Controls.Add(this.pnlGradeMesas);
            this.pnlAreaMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAreaMesas.Location = new System.Drawing.Point(0, 134);
            this.pnlAreaMesas.Name = "pnlAreaMesas";
            this.pnlAreaMesas.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.pnlAreaMesas.Size = new System.Drawing.Size(1100, 796);
            this.pnlAreaMesas.TabIndex = 2;
            this.pnlAreaMesas.Resize += new System.EventHandler(this.pnlAreaMesas_Resize);
            //
            // pnlGradeMesas
            //
            // Dock=Top (em vez de Location/Size fixos) é o que faz o
            // FlowLayoutPanel herdar a LARGURA do painel pai — sem isso,
            // AutoSize não tem contra o que quebrar linha e todos os
            // cards ficam lado a lado, num único "trilho" horizontal.
            this.pnlGradeMesas.AutoSize = true;
            this.pnlGradeMesas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGradeMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGradeMesas.WrapContents = true;
            this.pnlGradeMesas.Name = "pnlGradeMesas";
            this.pnlGradeMesas.TabIndex = 0;
            //
            // UcMesas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppColors.Background;
            this.Controls.Add(this.pnlAreaMesas);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UcMesas";
            this.Size = new System.Drawing.Size(1100, 900);
            this.Load += new System.EventHandler(this.UcMesas_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeMesas)).EndInit();
            this.pnlAreaMesas.ResumeLayout(false);
            this.pnlAreaMesas.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Lanchonete001.UI.RoundedPanel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblQuantidadeMesas;
        private System.Windows.Forms.NumericUpDown numQuantidadeMesas;
        private Lanchonete001.UI.RoundedButton btnAplicarQuantidade;
        private System.Windows.Forms.Label lblIconePesquisa;
        private System.Windows.Forms.TextBox txtPesquisarMesa;

        private System.Windows.Forms.Panel pnlAreaMesas;
        private System.Windows.Forms.FlowLayoutPanel pnlGradeMesas;
    }
}