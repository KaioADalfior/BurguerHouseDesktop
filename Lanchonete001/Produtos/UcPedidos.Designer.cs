using Lanchonete001.UI;

namespace Lanchonete001.Produtos
{
    partial class UcPedidos
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

            this.pnlHeader = new Lanchonete001.UI.RoundedPanel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.pnlQuadro = new System.Windows.Forms.Panel();

            this.tmrAtualizarQuadro = new System.Windows.Forms.Timer(this.components);

            this.pnlHeader.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(120, 48);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Pedidos";
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
            this.lblSubtitulo.Text = "Acompanhe o preparo dos pedidos em tempo real";
            //
            // pnlQuadro
            //
            // As 4 colunas do Kanban (Aguardando Preparo, Em Preparo,
            // Entregue, Finalizado) são montadas dinamicamente em
            // UcPedidos.cs (MontarColunas), dentro deste painel.
            this.pnlQuadro.BackColor = AppColors.Background;
            this.pnlQuadro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuadro.Location = new System.Drawing.Point(0, 70);
            this.pnlQuadro.Name = "pnlQuadro";
            this.pnlQuadro.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.pnlQuadro.Size = new System.Drawing.Size(1100, 830);
            this.pnlQuadro.TabIndex = 1;
            //
            // tmrAtualizarQuadro
            //
            // Atualiza o quadro periodicamente para refletir pedidos
            // enviados de outras mesas/telas enquanto este UserControl
            // já está aberto.
            this.tmrAtualizarQuadro.Interval = 3000;
            this.tmrAtualizarQuadro.Tick += new System.EventHandler(this.tmrAtualizarQuadro_Tick);
            //
            // UcPedidos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppColors.Background;
            this.Controls.Add(this.pnlQuadro);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UcPedidos";
            this.Size = new System.Drawing.Size(1100, 900);
            this.Load += new System.EventHandler(this.UcPedidos_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Lanchonete001.UI.RoundedPanel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel pnlQuadro;
        private System.Windows.Forms.Timer tmrAtualizarQuadro;
    }
}