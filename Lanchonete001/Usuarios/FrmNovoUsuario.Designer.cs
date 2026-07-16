using Lanchonete001.UI;

namespace Lanchonete001.Usuarios
{
    partial class FrmNovoUsuario
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
            this.txtNome = new System.Windows.Forms.TextBox();

            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlCampoUsuario = new Lanchonete001.UI.RoundedPanel();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();

            this.lblCargo = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();

            this.lblSenha = new System.Windows.Forms.Label();
            this.pnlCampoSenha = new Lanchonete001.UI.RoundedPanel();
            this.lblMostrarSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblIconSenha = new System.Windows.Forms.Label();

            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.pnlCampoConfirmarSenha = new Lanchonete001.UI.RoundedPanel();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblIconConfirmarSenha = new System.Windows.Forms.Label();

            this.chkAtivo = new System.Windows.Forms.CheckBox();

            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnSalvarUsuario = new Lanchonete001.UI.RoundedButton();
            this.btnCancelar = new Lanchonete001.UI.RoundedButton();

            this.pnlHeader.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            this.pnlCampoNome.SuspendLayout();
            this.pnlCampoUsuario.SuspendLayout();
            this.pnlCampoSenha.SuspendLayout();
            this.pnlCampoConfirmarSenha.SuspendLayout();
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
            this.lblTitulo.Text = "Cadastrar Usuário";
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
            this.lblSubtitulo.Text = "Preencha os dados do usuário abaixo";
            //
            // pnlConteudo
            //
            this.pnlConteudo.BackColor = AppColors.CardBackground;
            this.pnlConteudo.BorderColor = AppColors.Border;
            this.pnlConteudo.BorderThickness = 1;
            this.pnlConteudo.CornerRadius = 18;
            this.pnlConteudo.Controls.Add(this.chkAtivo);
            this.pnlConteudo.Controls.Add(this.pnlCampoConfirmarSenha);
            this.pnlConteudo.Controls.Add(this.lblConfirmarSenha);
            this.pnlConteudo.Controls.Add(this.pnlCampoSenha);
            this.pnlConteudo.Controls.Add(this.lblSenha);
            this.pnlConteudo.Controls.Add(this.cboCargo);
            this.pnlConteudo.Controls.Add(this.lblCargo);
            this.pnlConteudo.Controls.Add(this.pnlCampoUsuario);
            this.pnlConteudo.Controls.Add(this.lblUsuario);
            this.pnlConteudo.Controls.Add(this.pnlCampoNome);
            this.pnlConteudo.Controls.Add(this.lblNome);
            this.pnlConteudo.Location = new System.Drawing.Point(24, 112);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(472, 428);
            this.pnlConteudo.TabIndex = 1;
            //
            // lblNome
            //
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = AppColors.TextMuted;
            this.lblNome.Location = new System.Drawing.Point(24, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 22);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo:";
            //
            // pnlCampoNome
            //
            this.pnlCampoNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.pnlCampoNome.BorderColor = AppColors.Border;
            this.pnlCampoNome.BorderThickness = 1;
            this.pnlCampoNome.CornerRadius = 10;
            this.pnlCampoNome.Controls.Add(this.txtNome);
            this.pnlCampoNome.Location = new System.Drawing.Point(24, 42);
            this.pnlCampoNome.Name = "pnlCampoNome";
            this.pnlCampoNome.Size = new System.Drawing.Size(424, 40);
            this.pnlCampoNome.TabIndex = 1;
            //
            // txtNome
            //
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = AppColors.TextDark;
            this.txtNome.Location = new System.Drawing.Point(16, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(392, 20);
            this.txtNome.TabIndex = 0;
            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = AppColors.TextMuted;
            this.lblUsuario.Location = new System.Drawing.Point(24, 94);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(130, 22);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário (login):";
            //
            // pnlCampoUsuario
            //
            this.pnlCampoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.pnlCampoUsuario.BorderColor = AppColors.Border;
            this.pnlCampoUsuario.BorderThickness = 1;
            this.pnlCampoUsuario.CornerRadius = 10;
            this.pnlCampoUsuario.Controls.Add(this.txtNomeUsuario);
            this.pnlCampoUsuario.Location = new System.Drawing.Point(24, 116);
            this.pnlCampoUsuario.Name = "pnlCampoUsuario";
            this.pnlCampoUsuario.Size = new System.Drawing.Size(424, 40);
            this.pnlCampoUsuario.TabIndex = 3;
            //
            // txtNomeUsuario
            //
            this.txtNomeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.ForeColor = AppColors.TextDark;
            this.txtNomeUsuario.Location = new System.Drawing.Point(16, 10);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(392, 20);
            this.txtNomeUsuario.TabIndex = 0;
            //
            // lblCargo
            //
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = AppColors.TextMuted;
            this.lblCargo.Location = new System.Drawing.Point(24, 168);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 22);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo:";
            //
            // cboCargo
            //
            this.cboCargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCargo.BackColor = System.Drawing.Color.White;
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCargo.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.ForeColor = AppColors.TextDark;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(24, 190);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(424, 31);
            this.cboCargo.TabIndex = 5;
            //
            // lblSenha
            //
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = AppColors.TextMuted;
            this.lblSenha.Location = new System.Drawing.Point(24, 234);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(58, 22);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            //
            // pnlCampoSenha
            //
            this.pnlCampoSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.pnlCampoSenha.BorderColor = AppColors.Border;
            this.pnlCampoSenha.BorderThickness = 1;
            this.pnlCampoSenha.CornerRadius = 10;
            this.pnlCampoSenha.Controls.Add(this.lblMostrarSenha);
            this.pnlCampoSenha.Controls.Add(this.txtSenha);
            this.pnlCampoSenha.Controls.Add(this.lblIconSenha);
            this.pnlCampoSenha.Location = new System.Drawing.Point(24, 256);
            this.pnlCampoSenha.Name = "pnlCampoSenha";
            this.pnlCampoSenha.Size = new System.Drawing.Size(424, 40);
            this.pnlCampoSenha.TabIndex = 7;
            //
            // lblIconSenha
            //
            this.lblIconSenha.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconSenha.ForeColor = AppColors.Primary;
            this.lblIconSenha.Location = new System.Drawing.Point(10, 8);
            this.lblIconSenha.Name = "lblIconSenha";
            this.lblIconSenha.Size = new System.Drawing.Size(26, 24);
            this.lblIconSenha.TabIndex = 0;
            this.lblIconSenha.Text = "🔒";
            this.lblIconSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // txtSenha
            //
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = AppColors.TextDark;
            this.txtSenha.Location = new System.Drawing.Point(42, 10);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(330, 20);
            this.txtSenha.TabIndex = 1;
            //
            // lblMostrarSenha
            //
            this.lblMostrarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMostrarSenha.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarSenha.ForeColor = AppColors.TextMuted;
            this.lblMostrarSenha.Location = new System.Drawing.Point(388, 8);
            this.lblMostrarSenha.Name = "lblMostrarSenha";
            this.lblMostrarSenha.Size = new System.Drawing.Size(28, 24);
            this.lblMostrarSenha.TabIndex = 2;
            this.lblMostrarSenha.Text = "👁";
            this.lblMostrarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMostrarSenha.Click += new System.EventHandler(this.lblMostrarSenha_Click);
            //
            // lblConfirmarSenha
            //
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.ForeColor = AppColors.TextMuted;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(24, 308);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(130, 22);
            this.lblConfirmarSenha.TabIndex = 8;
            this.lblConfirmarSenha.Text = "Confirmar Senha:";
            //
            // pnlCampoConfirmarSenha
            //
            this.pnlCampoConfirmarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.pnlCampoConfirmarSenha.BorderColor = AppColors.Border;
            this.pnlCampoConfirmarSenha.BorderThickness = 1;
            this.pnlCampoConfirmarSenha.CornerRadius = 10;
            this.pnlCampoConfirmarSenha.Controls.Add(this.txtConfirmarSenha);
            this.pnlCampoConfirmarSenha.Controls.Add(this.lblIconConfirmarSenha);
            this.pnlCampoConfirmarSenha.Location = new System.Drawing.Point(24, 330);
            this.pnlCampoConfirmarSenha.Name = "pnlCampoConfirmarSenha";
            this.pnlCampoConfirmarSenha.Size = new System.Drawing.Size(424, 40);
            this.pnlCampoConfirmarSenha.TabIndex = 9;
            //
            // lblIconConfirmarSenha
            //
            this.lblIconConfirmarSenha.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconConfirmarSenha.ForeColor = AppColors.Primary;
            this.lblIconConfirmarSenha.Location = new System.Drawing.Point(10, 8);
            this.lblIconConfirmarSenha.Name = "lblIconConfirmarSenha";
            this.lblIconConfirmarSenha.Size = new System.Drawing.Size(26, 24);
            this.lblIconConfirmarSenha.TabIndex = 0;
            this.lblIconConfirmarSenha.Text = "🔒";
            this.lblIconConfirmarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // txtConfirmarSenha
            //
            this.txtConfirmarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.ForeColor = AppColors.TextDark;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(42, 10);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '●';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(370, 20);
            this.txtConfirmarSenha.TabIndex = 1;
            //
            // chkAtivo
            //
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAtivo.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = AppColors.TextDark;
            this.chkAtivo.Location = new System.Drawing.Point(24, 382);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(140, 24);
            this.chkAtivo.TabIndex = 10;
            this.chkAtivo.Text = "Usuário ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            //
            // pnlRodape
            //
            this.pnlRodape.BackColor = AppColors.Background;
            this.pnlRodape.Controls.Add(this.btnSalvarUsuario);
            this.pnlRodape.Controls.Add(this.btnCancelar);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 556);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(520, 84);
            this.pnlRodape.TabIndex = 2;
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
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnSalvarUsuario
            //
            this.btnSalvarUsuario.BackColor = AppColors.Primary;
            this.btnSalvarUsuario.CornerRadius = 10;
            this.btnSalvarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarUsuario.FlatAppearance.BorderSize = 0;
            this.btnSalvarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarUsuario.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnSalvarUsuario.Location = new System.Drawing.Point(356, 20);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(140, 44);
            this.btnSalvarUsuario.TabIndex = 1;
            this.btnSalvarUsuario.Text = "Salvar";
            this.btnSalvarUsuario.UseVisualStyleBackColor = false;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            //
            // FrmNovoUsuario
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppColors.Background;
            this.ClientSize = new System.Drawing.Size(520, 640);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Novo Usuário";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            this.pnlCampoNome.ResumeLayout(false);
            this.pnlCampoNome.PerformLayout();
            this.pnlCampoUsuario.ResumeLayout(false);
            this.pnlCampoUsuario.PerformLayout();
            this.pnlCampoSenha.ResumeLayout(false);
            this.pnlCampoSenha.PerformLayout();
            this.pnlCampoConfirmarSenha.ResumeLayout(false);
            this.pnlCampoConfirmarSenha.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNome;

        private System.Windows.Forms.Label lblUsuario;
        private Lanchonete001.UI.RoundedPanel pnlCampoUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;

        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cboCargo;

        private System.Windows.Forms.Label lblSenha;
        private Lanchonete001.UI.RoundedPanel pnlCampoSenha;
        private System.Windows.Forms.Label lblIconSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblMostrarSenha;

        private System.Windows.Forms.Label lblConfirmarSenha;
        private Lanchonete001.UI.RoundedPanel pnlCampoConfirmarSenha;
        private System.Windows.Forms.Label lblIconConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;

        private System.Windows.Forms.CheckBox chkAtivo;

        private System.Windows.Forms.Panel pnlRodape;
        private Lanchonete001.UI.RoundedButton btnSalvarUsuario;
        private Lanchonete001.UI.RoundedButton btnCancelar;
    }
}