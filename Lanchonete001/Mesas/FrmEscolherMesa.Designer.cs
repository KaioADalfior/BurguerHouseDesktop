using Lanchonete001.UI;

namespace Lanchonete001.Mesas
{
    partial class FrmEscolherMesa
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
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.pnlLista = new System.Windows.Forms.Panel();
            this.flpMesas = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnCancelar = new Lanchonete001.UI.RoundedButton();

            this.pnlHeader.SuspendLayout();
            this.pnlLista.SuspendLayout();
            this.pnlRodape.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(460, 66);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = AppColors.TextDark;
            this.lblTitulo.Location = new System.Drawing.Point(24, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Transferir para qual mesa?";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = AppColors.TextMuted;
            this.lblSubtitulo.Location = new System.Drawing.Point(25, 38);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(220, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Somente mesas livres são exibidas";
            //
            // pnlLista
            //
            this.pnlLista.AutoScroll = true;
            this.pnlLista.BackColor = AppColors.Background;
            this.pnlLista.Controls.Add(this.flpMesas);
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLista.Location = new System.Drawing.Point(0, 66);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.pnlLista.Size = new System.Drawing.Size(460, 274);
            this.pnlLista.TabIndex = 1;
            //
            // flpMesas
            //
            this.flpMesas.AutoSize = true;
            this.flpMesas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpMesas.Name = "flpMesas";
            this.flpMesas.TabIndex = 0;
            this.flpMesas.WrapContents = true;
            //
            // pnlRodape
            //
            this.pnlRodape.BackColor = AppColors.Background;
            this.pnlRodape.Controls.Add(this.btnCancelar);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 340);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
            this.pnlRodape.Size = new System.Drawing.Size(460, 56);
            this.pnlRodape.TabIndex = 2;
            //
            // btnCancelar
            //
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = AppColors.Background;
            this.btnCancelar.CornerRadius = 10;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 1;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = AppColors.TextDark;
            this.btnCancelar.Location = new System.Drawing.Point(324, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 36);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // FrmEscolherMesa
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppColors.Background;
            this.ClientSize = new System.Drawing.Size(460, 396);
            this.Controls.Add(this.pnlLista);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEscolherMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transferir Mesa";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLista.ResumeLayout(false);
            this.pnlLista.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Lanchonete001.UI.RoundedPanel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.FlowLayoutPanel flpMesas;

        private System.Windows.Forms.Panel pnlRodape;
        private Lanchonete001.UI.RoundedButton btnCancelar;
    }
}