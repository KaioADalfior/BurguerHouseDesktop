using Lanchonete001.UI;

namespace Lanchonete001.Cardapio
{
    partial class FrmNovoItemCardapio
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.pnlConteudo = new Lanchonete001.UI.RoundedPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.numPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();

            this.pnlReceita = new Lanchonete001.UI.RoundedPanel();
            this.lblReceita = new System.Windows.Forms.Label();
            this.cboInsumo = new System.Windows.Forms.ComboBox();
            this.numQuantidadeIngrediente = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionarIngrediente = new Lanchonete001.UI.RoundedButton();
            this.lstIngredientes = new System.Windows.Forms.ListBox();
            this.btnRemoverIngrediente = new Lanchonete001.UI.RoundedButton();
            this.lblCustoEstimado = new System.Windows.Forms.Label();
            this.lblMargemLucro = new System.Windows.Forms.Label();

            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnSalvar = new Lanchonete001.UI.RoundedButton();
            this.btnCancelar = new Lanchonete001.UI.RoundedButton();

            this.pnlHeader.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoVenda)).BeginInit();
            this.pnlReceita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeIngrediente)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(560, 90);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastrar Item";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(230)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(29, 58);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(320, 23);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Monte a receita a partir dos insumos do estoque";
            //
            // pnlConteudo
            //
            this.pnlConteudo.BackColor = AppColors.CardBackground;
            this.pnlConteudo.BorderColor = AppColors.Border;
            this.pnlConteudo.BorderThickness = 1;
            this.pnlConteudo.CornerRadius = 18;
            this.pnlConteudo.Controls.Add(this.lblNome);
            this.pnlConteudo.Controls.Add(this.txtNome);
            this.pnlConteudo.Controls.Add(this.lblCategoria);
            this.pnlConteudo.Controls.Add(this.cboCategoria);
            this.pnlConteudo.Controls.Add(this.lblPreco);
            this.pnlConteudo.Controls.Add(this.numPrecoVenda);
            this.pnlConteudo.Controls.Add(this.chkAtivo);
            this.pnlConteudo.Controls.Add(this.lblDescricao);
            this.pnlConteudo.Controls.Add(this.txtDescricao);
            this.pnlConteudo.Location = new System.Drawing.Point(24, 106);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(512, 190);
            this.pnlConteudo.TabIndex = 1;
            //
            // lblNome
            //
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = AppColors.TextMuted;
            this.lblNome.Location = new System.Drawing.Point(20, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 22);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            //
            // txtNome
            //
            this.txtNome.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(20, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(472, 24);
            this.txtNome.TabIndex = 1;
            //
            // lblCategoria
            //
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = AppColors.TextMuted;
            this.lblCategoria.Location = new System.Drawing.Point(20, 68);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 22);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            //
            // cboCategoria
            //
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(20, 90);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(220, 32);
            this.cboCategoria.TabIndex = 3;
            //
            // lblPreco
            //
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = AppColors.TextMuted;
            this.lblPreco.Location = new System.Drawing.Point(272, 68);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(120, 22);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço de venda:";
            //
            // numPrecoVenda
            //
            this.numPrecoVenda.DecimalPlaces = 2;
            this.numPrecoVenda.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecoVenda.Location = new System.Drawing.Point(272, 90);
            this.numPrecoVenda.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numPrecoVenda.Name = "numPrecoVenda";
            this.numPrecoVenda.Size = new System.Drawing.Size(120, 27);
            this.numPrecoVenda.TabIndex = 5;
            this.numPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecoVenda.ValueChanged += new System.EventHandler(this.numPrecoVenda_ValueChanged);
            //
            // chkAtivo
            //
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = AppColors.TextDark;
            this.chkAtivo.Location = new System.Drawing.Point(410, 92);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(60, 24);
            this.chkAtivo.TabIndex = 6;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            //
            // lblDescricao
            //
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = AppColors.TextMuted;
            this.lblDescricao.Location = new System.Drawing.Point(20, 126);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 22);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Descrição:";
            //
            // txtDescricao
            //
            this.txtDescricao.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(20, 148);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(472, 30);
            this.txtDescricao.TabIndex = 8;
            //
            // pnlReceita
            //
            this.pnlReceita.BackColor = AppColors.CardBackground;
            this.pnlReceita.BorderColor = AppColors.Border;
            this.pnlReceita.BorderThickness = 1;
            this.pnlReceita.CornerRadius = 18;
            this.pnlReceita.Controls.Add(this.lblReceita);
            this.pnlReceita.Controls.Add(this.cboInsumo);
            this.pnlReceita.Controls.Add(this.numQuantidadeIngrediente);
            this.pnlReceita.Controls.Add(this.btnAdicionarIngrediente);
            this.pnlReceita.Controls.Add(this.lstIngredientes);
            this.pnlReceita.Controls.Add(this.btnRemoverIngrediente);
            this.pnlReceita.Controls.Add(this.lblCustoEstimado);
            this.pnlReceita.Controls.Add(this.lblMargemLucro);
            this.pnlReceita.Location = new System.Drawing.Point(24, 306);
            this.pnlReceita.Name = "pnlReceita";
            this.pnlReceita.Size = new System.Drawing.Size(512, 176);
            this.pnlReceita.TabIndex = 2;
            //
            // lblReceita
            //
            this.lblReceita.AutoSize = true;
            this.lblReceita.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceita.ForeColor = AppColors.TextMuted;
            this.lblReceita.Location = new System.Drawing.Point(20, 12);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(280, 22);
            this.lblReceita.TabIndex = 0;
            this.lblReceita.Text = "Receita (insumos do estoque):";
            //
            // cboInsumo
            //
            this.cboInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInsumo.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInsumo.FormattingEnabled = true;
            this.cboInsumo.Location = new System.Drawing.Point(20, 36);
            this.cboInsumo.Name = "cboInsumo";
            this.cboInsumo.Size = new System.Drawing.Size(230, 32);
            this.cboInsumo.TabIndex = 1;
            //
            // numQuantidadeIngrediente
            //
            this.numQuantidadeIngrediente.DecimalPlaces = 3;
            this.numQuantidadeIngrediente.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidadeIngrediente.Location = new System.Drawing.Point(258, 36);
            this.numQuantidadeIngrediente.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numQuantidadeIngrediente.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            this.numQuantidadeIngrediente.Name = "numQuantidadeIngrediente";
            this.numQuantidadeIngrediente.Size = new System.Drawing.Size(90, 27);
            this.numQuantidadeIngrediente.TabIndex = 2;
            this.numQuantidadeIngrediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQuantidadeIngrediente.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // btnAdicionarIngrediente
            //
            this.btnAdicionarIngrediente.BackColor = AppColors.Primary;
            this.btnAdicionarIngrediente.CornerRadius = 8;
            this.btnAdicionarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnAdicionarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarIngrediente.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarIngrediente.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarIngrediente.Location = new System.Drawing.Point(356, 34);
            this.btnAdicionarIngrediente.Name = "btnAdicionarIngrediente";
            this.btnAdicionarIngrediente.Size = new System.Drawing.Size(136, 30);
            this.btnAdicionarIngrediente.TabIndex = 3;
            this.btnAdicionarIngrediente.Text = "+  Adicionar";
            this.btnAdicionarIngrediente.UseVisualStyleBackColor = false;
            this.btnAdicionarIngrediente.Click += new System.EventHandler(this.btnAdicionarIngrediente_Click);
            //
            // lstIngredientes
            //
            this.lstIngredientes.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIngredientes.FormattingEnabled = true;
            this.lstIngredientes.ItemHeight = 18;
            this.lstIngredientes.Location = new System.Drawing.Point(20, 70);
            this.lstIngredientes.Name = "lstIngredientes";
            this.lstIngredientes.Size = new System.Drawing.Size(360, 76);
            this.lstIngredientes.TabIndex = 4;
            //
            // btnRemoverIngrediente
            //
            this.btnRemoverIngrediente.BackColor = AppColors.Border;
            this.btnRemoverIngrediente.CornerRadius = 8;
            this.btnRemoverIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverIngrediente.FlatAppearance.BorderSize = 0;
            this.btnRemoverIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverIngrediente.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverIngrediente.ForeColor = AppColors.TextDark;
            this.btnRemoverIngrediente.Location = new System.Drawing.Point(388, 70);
            this.btnRemoverIngrediente.Name = "btnRemoverIngrediente";
            this.btnRemoverIngrediente.Size = new System.Drawing.Size(104, 30);
            this.btnRemoverIngrediente.TabIndex = 5;
            this.btnRemoverIngrediente.Text = "Remover";
            this.btnRemoverIngrediente.UseVisualStyleBackColor = false;
            this.btnRemoverIngrediente.Click += new System.EventHandler(this.btnRemoverIngrediente_Click);
            //
            // lblCustoEstimado
            //
            this.lblCustoEstimado.AutoSize = true;
            this.lblCustoEstimado.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoEstimado.ForeColor = AppColors.TextDark;
            this.lblCustoEstimado.Location = new System.Drawing.Point(388, 108);
            this.lblCustoEstimado.Name = "lblCustoEstimado";
            this.lblCustoEstimado.Size = new System.Drawing.Size(180, 22);
            this.lblCustoEstimado.TabIndex = 6;
            this.lblCustoEstimado.Text = "Custo estimado: R$ 0,00";
            //
            // lblMargemLucro
            //
            this.lblMargemLucro.AutoSize = true;
            this.lblMargemLucro.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMargemLucro.ForeColor = AppColors.Success;
            this.lblMargemLucro.Location = new System.Drawing.Point(388, 130);
            this.lblMargemLucro.Name = "lblMargemLucro";
            this.lblMargemLucro.Size = new System.Drawing.Size(140, 22);
            this.lblMargemLucro.TabIndex = 7;
            this.lblMargemLucro.Text = "Margem: R$ 0,00";
            //
            // pnlRodape
            //
            this.pnlRodape.BackColor = AppColors.Background;
            this.pnlRodape.Controls.Add(this.btnSalvar);
            this.pnlRodape.Controls.Add(this.btnCancelar);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 490);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(560, 70);
            this.pnlRodape.TabIndex = 3;
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
            this.btnCancelar.Location = new System.Drawing.Point(264, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 44);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnSalvar
            //
            this.btnSalvar.BackColor = AppColors.Primary;
            this.btnSalvar.CornerRadius = 10;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(396, 14);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 44);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            //
            // FrmNovoItemCardapio
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppColors.Background;
            this.ClientSize = new System.Drawing.Size(560, 560);
            this.Controls.Add(this.pnlReceita);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovoItemCardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Item";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoVenda)).EndInit();
            this.pnlReceita.ResumeLayout(false);
            this.pnlReceita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeIngrediente)).EndInit();
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;

        private Lanchonete001.UI.RoundedPanel pnlConteudo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.NumericUpDown numPrecoVenda;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;

        private Lanchonete001.UI.RoundedPanel pnlReceita;
        private System.Windows.Forms.Label lblReceita;
        private System.Windows.Forms.ComboBox cboInsumo;
        private System.Windows.Forms.NumericUpDown numQuantidadeIngrediente;
        private Lanchonete001.UI.RoundedButton btnAdicionarIngrediente;
        private System.Windows.Forms.ListBox lstIngredientes;
        private Lanchonete001.UI.RoundedButton btnRemoverIngrediente;
        private System.Windows.Forms.Label lblCustoEstimado;
        private System.Windows.Forms.Label lblMargemLucro;

        private System.Windows.Forms.Panel pnlRodape;
        private Lanchonete001.UI.RoundedButton btnSalvar;
        private Lanchonete001.UI.RoundedButton btnCancelar;
    }
}