using Lanchonete001.UI;

namespace Lanchonete001.Estoque
{
    partial class FrmNovoInsumo
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.pnlConteudo = new Lanchonete001.UI.RoundedPanel();

            this.lblNome = new System.Windows.Forms.Label();
            this.pnlCampoNome = new Lanchonete001.UI.RoundedPanel();
            this.txtNomeInsumo = new System.Windows.Forms.TextBox();

            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoriaInsumo = new System.Windows.Forms.ComboBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.cboUnidadeInsumo = new System.Windows.Forms.ComboBox();

            this.lblQtdAtual = new System.Windows.Forms.Label();
            this.numQuantidadeAtual = new System.Windows.Forms.NumericUpDown();
            this.lblQtdMinima = new System.Windows.Forms.Label();
            this.numQuantidadeMinima = new System.Windows.Forms.NumericUpDown();
            this.lblPreco = new System.Windows.Forms.Label();
            this.numPrecoUnitario = new System.Windows.Forms.NumericUpDown();

            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnSalvarInsumo = new Lanchonete001.UI.RoundedButton();
            this.btnCancelar = new Lanchonete001.UI.RoundedButton();
            this.btnLimpar = new Lanchonete001.UI.RoundedButton();

            this.pnlHeader.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            this.pnlCampoNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoUnitario)).BeginInit();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = AppColors.Primary;
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(520, 96);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(28, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastrar Insumo";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(230)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(29, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(252, 23);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Preencha os dados do insumo abaixo";
            //
            // pnlConteudo
            //
            this.pnlConteudo.BackColor = AppColors.CardBackground;
            this.pnlConteudo.BorderColor = AppColors.Border;
            this.pnlConteudo.BorderThickness = 1;
            this.pnlConteudo.CornerRadius = 18;
            this.pnlConteudo.Controls.Add(this.numPrecoUnitario);
            this.pnlConteudo.Controls.Add(this.lblPreco);
            this.pnlConteudo.Controls.Add(this.numQuantidadeMinima);
            this.pnlConteudo.Controls.Add(this.lblQtdMinima);
            this.pnlConteudo.Controls.Add(this.numQuantidadeAtual);
            this.pnlConteudo.Controls.Add(this.lblQtdAtual);
            this.pnlConteudo.Controls.Add(this.cboUnidadeInsumo);
            this.pnlConteudo.Controls.Add(this.lblUnidade);
            this.pnlConteudo.Controls.Add(this.cboCategoriaInsumo);
            this.pnlConteudo.Controls.Add(this.lblCategoria);
            this.pnlConteudo.Controls.Add(this.pnlCampoNome);
            this.pnlConteudo.Controls.Add(this.lblNome);
            this.pnlConteudo.Location = new System.Drawing.Point(24, 112);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(472, 250);
            this.pnlConteudo.TabIndex = 1;
            //
            // lblNome
            //
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = AppColors.TextMuted;
            this.lblNome.Location = new System.Drawing.Point(24, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(115, 22);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Insumo:";
            //
            // pnlCampoNome
            //
            this.pnlCampoNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.pnlCampoNome.BorderColor = AppColors.Border;
            this.pnlCampoNome.BorderThickness = 1;
            this.pnlCampoNome.CornerRadius = 10;
            this.pnlCampoNome.Controls.Add(this.txtNomeInsumo);
            this.pnlCampoNome.Location = new System.Drawing.Point(24, 42);
            this.pnlCampoNome.Name = "pnlCampoNome";
            this.pnlCampoNome.Size = new System.Drawing.Size(424, 40);
            this.pnlCampoNome.TabIndex = 1;
            //
            // txtNomeInsumo
            //
            this.txtNomeInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.txtNomeInsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeInsumo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeInsumo.ForeColor = AppColors.TextDark;
            this.txtNomeInsumo.Location = new System.Drawing.Point(16, 10);
            this.txtNomeInsumo.Name = "txtNomeInsumo";
            this.txtNomeInsumo.Size = new System.Drawing.Size(392, 20);
            this.txtNomeInsumo.TabIndex = 0;
            //
            // lblCategoria
            //
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = AppColors.TextMuted;
            this.lblCategoria.Location = new System.Drawing.Point(24, 100);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 22);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            //
            // cboCategoriaInsumo
            //
            this.cboCategoriaInsumo.BackColor = AppColors.CardBackground;
            this.cboCategoriaInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoriaInsumo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoriaInsumo.ForeColor = AppColors.TextDark;
            this.cboCategoriaInsumo.FormattingEnabled = true;
            this.cboCategoriaInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaInsumo.Location = new System.Drawing.Point(24, 124);
            this.cboCategoriaInsumo.Name = "cboCategoriaInsumo";
            this.cboCategoriaInsumo.Size = new System.Drawing.Size(204, 32);
            this.cboCategoriaInsumo.TabIndex = 3;
            //
            // lblUnidade
            //
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.ForeColor = AppColors.TextMuted;
            this.lblUnidade.Location = new System.Drawing.Point(244, 100);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(128, 22);
            this.lblUnidade.TabIndex = 4;
            this.lblUnidade.Text = "Unidade de Medida:";
            //
            // cboUnidadeInsumo
            //
            this.cboUnidadeInsumo.BackColor = AppColors.CardBackground;
            this.cboUnidadeInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnidadeInsumo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadeInsumo.ForeColor = AppColors.TextDark;
            this.cboUnidadeInsumo.FormattingEnabled = true;
            this.cboUnidadeInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadeInsumo.Location = new System.Drawing.Point(244, 124);
            this.cboUnidadeInsumo.Name = "cboUnidadeInsumo";
            this.cboUnidadeInsumo.Size = new System.Drawing.Size(204, 32);
            this.cboUnidadeInsumo.TabIndex = 5;
            //
            // lblQtdAtual
            //
            this.lblQtdAtual.AutoSize = true;
            this.lblQtdAtual.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdAtual.ForeColor = AppColors.TextMuted;
            this.lblQtdAtual.Location = new System.Drawing.Point(24, 174);
            this.lblQtdAtual.Name = "lblQtdAtual";
            this.lblQtdAtual.Size = new System.Drawing.Size(71, 22);
            this.lblQtdAtual.TabIndex = 6;
            this.lblQtdAtual.Text = "Qtd. Atual:";
            //
            // numQuantidadeAtual
            //
            this.numQuantidadeAtual.BackColor = AppColors.CardBackground;
            this.numQuantidadeAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numQuantidadeAtual.DecimalPlaces = 2;
            this.numQuantidadeAtual.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidadeAtual.ForeColor = AppColors.TextDark;
            this.numQuantidadeAtual.Location = new System.Drawing.Point(24, 198);
            this.numQuantidadeAtual.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuantidadeAtual.Name = "numQuantidadeAtual";
            this.numQuantidadeAtual.Size = new System.Drawing.Size(130, 27);
            this.numQuantidadeAtual.TabIndex = 7;
            this.numQuantidadeAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblQtdMinima
            //
            this.lblQtdMinima.AutoSize = true;
            this.lblQtdMinima.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdMinima.ForeColor = AppColors.TextMuted;
            this.lblQtdMinima.Location = new System.Drawing.Point(171, 174);
            this.lblQtdMinima.Name = "lblQtdMinima";
            this.lblQtdMinima.Size = new System.Drawing.Size(64, 22);
            this.lblQtdMinima.TabIndex = 8;
            this.lblQtdMinima.Text = "Qtd. Mín.:";
            //
            // numQuantidadeMinima
            //
            this.numQuantidadeMinima.BackColor = AppColors.CardBackground;
            this.numQuantidadeMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numQuantidadeMinima.DecimalPlaces = 2;
            this.numQuantidadeMinima.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidadeMinima.ForeColor = AppColors.TextDark;
            this.numQuantidadeMinima.Location = new System.Drawing.Point(171, 198);
            this.numQuantidadeMinima.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuantidadeMinima.Name = "numQuantidadeMinima";
            this.numQuantidadeMinima.Size = new System.Drawing.Size(130, 27);
            this.numQuantidadeMinima.TabIndex = 9;
            this.numQuantidadeMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblPreco
            //
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = AppColors.TextMuted;
            this.lblPreco.Location = new System.Drawing.Point(318, 174);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(75, 22);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "Preço Unit.:";
            //
            // numPrecoUnitario
            //
            this.numPrecoUnitario.BackColor = AppColors.CardBackground;
            this.numPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPrecoUnitario.DecimalPlaces = 2;
            this.numPrecoUnitario.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecoUnitario.ForeColor = AppColors.TextDark;
            this.numPrecoUnitario.Location = new System.Drawing.Point(318, 198);
            this.numPrecoUnitario.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrecoUnitario.Name = "numPrecoUnitario";
            this.numPrecoUnitario.Size = new System.Drawing.Size(130, 27);
            this.numPrecoUnitario.TabIndex = 11;
            this.numPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // pnlRodape
            //
            this.pnlRodape.BackColor = AppColors.Background;
            this.pnlRodape.Controls.Add(this.btnSalvarInsumo);
            this.pnlRodape.Controls.Add(this.btnCancelar);
            this.pnlRodape.Controls.Add(this.btnLimpar);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 396);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(520, 84);
            this.pnlRodape.TabIndex = 2;
            //
            // btnLimpar
            //
            this.btnLimpar.BackColor = AppColors.Border;
            this.btnLimpar.CornerRadius = 10;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = AppColors.TextDark;
            this.btnLimpar.Location = new System.Drawing.Point(24, 20);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 44);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = AppColors.CardBackground;
            this.btnCancelar.CornerRadius = 10;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = AppColors.TextMuted;
            this.btnCancelar.Location = new System.Drawing.Point(224, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 44);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnSalvarInsumo
            //
            this.btnSalvarInsumo.BackColor = AppColors.Primary;
            this.btnSalvarInsumo.CornerRadius = 10;
            this.btnSalvarInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarInsumo.FlatAppearance.BorderSize = 0;
            this.btnSalvarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarInsumo.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarInsumo.ForeColor = System.Drawing.Color.White;
            this.btnSalvarInsumo.Location = new System.Drawing.Point(356, 20);
            this.btnSalvarInsumo.Name = "btnSalvarInsumo";
            this.btnSalvarInsumo.Size = new System.Drawing.Size(140, 44);
            this.btnSalvarInsumo.TabIndex = 2;
            this.btnSalvarInsumo.Text = "Salvar";
            this.btnSalvarInsumo.UseVisualStyleBackColor = false;
            this.btnSalvarInsumo.Click += new System.EventHandler(this.btnSalvarInsumo_Click);
            //
            // FrmNovoInsumo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppColors.Background;
            this.ClientSize = new System.Drawing.Size(520, 480);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovoInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Novo Insumo";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            this.pnlCampoNome.ResumeLayout(false);
            this.pnlCampoNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoUnitario)).EndInit();
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;

        private Lanchonete001.UI.RoundedPanel pnlConteudo;

        private System.Windows.Forms.Label lblNome;
        private Lanchonete001.UI.RoundedPanel pnlCampoNome;
        private System.Windows.Forms.TextBox txtNomeInsumo;

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoriaInsumo;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.ComboBox cboUnidadeInsumo;

        private System.Windows.Forms.Label lblQtdAtual;
        private System.Windows.Forms.NumericUpDown numQuantidadeAtual;
        private System.Windows.Forms.Label lblQtdMinima;
        private System.Windows.Forms.NumericUpDown numQuantidadeMinima;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.NumericUpDown numPrecoUnitario;

        private System.Windows.Forms.Panel pnlRodape;
        private Lanchonete001.UI.RoundedButton btnSalvarInsumo;
        private Lanchonete001.UI.RoundedButton btnCancelar;
        private Lanchonete001.UI.RoundedButton btnLimpar;
    }
}