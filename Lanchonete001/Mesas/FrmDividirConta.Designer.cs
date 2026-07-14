using Lanchonete001.UI;

namespace Lanchonete001.Mesas
{
    partial class FrmDividirConta
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

            this.pnlCorpo = new System.Windows.Forms.Panel();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.lblPessoasCaption = new System.Windows.Forms.Label();
            this.numPessoas = new System.Windows.Forms.NumericUpDown();
            this.lblGorjetaCaption = new System.Windows.Forms.Label();
            this.numGorjeta = new System.Windows.Forms.NumericUpDown();

            this.pnlResultado = new Lanchonete001.UI.RoundedPanel();
            this.lblResultadoCaption = new System.Windows.Forms.Label();
            this.lblResultadoValor = new System.Windows.Forms.Label();

            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnFechar = new Lanchonete001.UI.RoundedButton();

            this.pnlCorpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGorjeta)).BeginInit();
            this.pnlResultado.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = AppColors.Background;
            this.pnlHeader.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderThickness = 0;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.CornerRadius = 0;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(400, 56);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = AppColors.TextDark;
            this.lblTitulo.Location = new System.Drawing.Point(24, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Dividir Conta";
            //
            // pnlCorpo
            //
            this.pnlCorpo.BackColor = AppColors.Background;
            this.pnlCorpo.Controls.Add(this.numGorjeta);
            this.pnlCorpo.Controls.Add(this.lblGorjetaCaption);
            this.pnlCorpo.Controls.Add(this.numPessoas);
            this.pnlCorpo.Controls.Add(this.lblPessoasCaption);
            this.pnlCorpo.Controls.Add(this.lblTotalValor);
            this.pnlCorpo.Controls.Add(this.lblTotalCaption);
            this.pnlCorpo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCorpo.Location = new System.Drawing.Point(0, 56);
            this.pnlCorpo.Name = "pnlCorpo";
            this.pnlCorpo.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.pnlCorpo.Size = new System.Drawing.Size(400, 168);
            this.pnlCorpo.TabIndex = 1;
            //
            // lblTotalCaption
            //
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCaption.ForeColor = AppColors.TextDark;
            this.lblTotalCaption.Location = new System.Drawing.Point(24, 14);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(90, 23);
            this.lblTotalCaption.TabIndex = 0;
            this.lblTotalCaption.Text = "Total da conta:";
            //
            // lblTotalValor
            //
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.ForeColor = AppColors.Success;
            this.lblTotalValor.Location = new System.Drawing.Point(210, 10);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(110, 30);
            this.lblTotalValor.TabIndex = 1;
            this.lblTotalValor.Text = "R$ 0,00";
            //
            // lblPessoasCaption
            //
            this.lblPessoasCaption.AutoSize = true;
            this.lblPessoasCaption.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoasCaption.ForeColor = AppColors.TextDark;
            this.lblPessoasCaption.Location = new System.Drawing.Point(24, 60);
            this.lblPessoasCaption.Name = "lblPessoasCaption";
            this.lblPessoasCaption.Size = new System.Drawing.Size(150, 23);
            this.lblPessoasCaption.TabIndex = 2;
            this.lblPessoasCaption.Text = "Dividir entre quantas pessoas:";
            //
            // numPessoas
            //
            this.numPessoas.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPessoas.Location = new System.Drawing.Point(280, 58);
            this.numPessoas.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numPessoas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPessoas.Name = "numPessoas";
            this.numPessoas.Size = new System.Drawing.Size(70, 27);
            this.numPessoas.TabIndex = 3;
            this.numPessoas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPessoas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPessoas.ValueChanged += new System.EventHandler(this.AoMudarValores);
            //
            // lblGorjetaCaption
            //
            this.lblGorjetaCaption.AutoSize = true;
            this.lblGorjetaCaption.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGorjetaCaption.ForeColor = AppColors.TextDark;
            this.lblGorjetaCaption.Location = new System.Drawing.Point(24, 104);
            this.lblGorjetaCaption.Name = "lblGorjetaCaption";
            this.lblGorjetaCaption.Size = new System.Drawing.Size(140, 23);
            this.lblGorjetaCaption.TabIndex = 4;
            this.lblGorjetaCaption.Text = "Gorjeta (%):";
            //
            // numGorjeta
            //
            this.numGorjeta.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGorjeta.Location = new System.Drawing.Point(280, 102);
            this.numGorjeta.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numGorjeta.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numGorjeta.Name = "numGorjeta";
            this.numGorjeta.Size = new System.Drawing.Size(70, 27);
            this.numGorjeta.TabIndex = 5;
            this.numGorjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numGorjeta.Value = new decimal(new int[] { 10, 0, 0, 0 });
            this.numGorjeta.ValueChanged += new System.EventHandler(this.AoMudarValores);
            //
            // pnlResultado
            //
            this.pnlResultado.BackColor = AppColors.SuccessLight;
            this.pnlResultado.BorderColor = AppColors.Success;
            this.pnlResultado.BorderThickness = 1;
            this.pnlResultado.Controls.Add(this.lblResultadoValor);
            this.pnlResultado.Controls.Add(this.lblResultadoCaption);
            this.pnlResultado.CornerRadius = 12;
            this.pnlResultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResultado.Location = new System.Drawing.Point(0, 224);
            this.pnlResultado.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(400, 78);
            this.pnlResultado.TabIndex = 2;
            //
            // lblResultadoCaption
            //
            this.lblResultadoCaption.AutoSize = true;
            this.lblResultadoCaption.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCaption.ForeColor = AppColors.Success;
            this.lblResultadoCaption.Location = new System.Drawing.Point(24, 12);
            this.lblResultadoCaption.Name = "lblResultadoCaption";
            this.lblResultadoCaption.Size = new System.Drawing.Size(220, 23);
            this.lblResultadoCaption.TabIndex = 0;
            this.lblResultadoCaption.Text = "Valor por pessoa (com gorjeta):";
            //
            // lblResultadoValor
            //
            this.lblResultadoValor.AutoSize = true;
            this.lblResultadoValor.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoValor.ForeColor = AppColors.Success;
            this.lblResultadoValor.Location = new System.Drawing.Point(24, 36);
            this.lblResultadoValor.Name = "lblResultadoValor";
            this.lblResultadoValor.Size = new System.Drawing.Size(150, 36);
            this.lblResultadoValor.TabIndex = 1;
            this.lblResultadoValor.Text = "R$ 0,00";
            //
            // pnlRodape
            //
            this.pnlRodape.BackColor = AppColors.Background;
            this.pnlRodape.Controls.Add(this.btnFechar);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 302);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
            this.pnlRodape.Size = new System.Drawing.Size(400, 56);
            this.pnlRodape.TabIndex = 3;
            //
            // btnFechar
            //
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = AppColors.Primary;
            this.btnFechar.CornerRadius = 10;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(264, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 36);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            //
            // FrmDividirConta
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppColors.Background;
            this.ClientSize = new System.Drawing.Size(400, 358);
            this.Controls.Add(this.pnlResultado);
            this.Controls.Add(this.pnlCorpo);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDividirConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dividir Conta";
            this.pnlCorpo.ResumeLayout(false);
            this.pnlCorpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGorjeta)).EndInit();
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Lanchonete001.UI.RoundedPanel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.Panel pnlCorpo;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Label lblPessoasCaption;
        private System.Windows.Forms.NumericUpDown numPessoas;
        private System.Windows.Forms.Label lblGorjetaCaption;
        private System.Windows.Forms.NumericUpDown numGorjeta;

        private Lanchonete001.UI.RoundedPanel pnlResultado;
        private System.Windows.Forms.Label lblResultadoCaption;
        private System.Windows.Forms.Label lblResultadoValor;

        private System.Windows.Forms.Panel pnlRodape;
        private Lanchonete001.UI.RoundedButton btnFechar;
    }
}