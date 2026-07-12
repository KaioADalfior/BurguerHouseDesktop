using System.Drawing;
using System.Windows.Forms;
using Lanchonete001.UI;

namespace Lanchonete001.Login
{
    partial class FrmLogin
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
            this.pnlLeft = new Lanchonete001.UI.RoundedPanel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblRodape = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnEntrar = new Lanchonete001.UI.RoundedButton();
            this.lnkEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.chkLembrar = new System.Windows.Forms.CheckBox();
            this.pnlSenha = new Lanchonete001.UI.RoundedPanel();
            this.lblMostrarSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblIconSenha = new System.Windows.Forms.Label();
            this.lblCaptionSenha = new System.Windows.Forms.Label();
            this.pnlUsuario = new Lanchonete001.UI.RoundedPanel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblIconUsuario = new System.Windows.Forms.Label();
            this.lblCaptionUsuario = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDragArea = new System.Windows.Forms.Panel();
            this.lblFechar = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSenha.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlDragArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.pnlLeft.BorderColor = System.Drawing.Color.Transparent;
            this.pnlLeft.BorderThickness = 0;
            this.pnlLeft.Controls.Add(this.lblSlogan);
            this.pnlLeft.Controls.Add(this.lblMarca);
            this.pnlLeft.Controls.Add(this.picLogo);
            this.pnlLeft.CornerRadius = 0;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(380, 550);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblSlogan
            // 
            this.lblSlogan.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.lblSlogan.Location = new System.Drawing.Point(40, 344);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(300, 55);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Sabor que conquista, atendimento que encanta";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMarca
            // 
            this.lblMarca.Font = new System.Drawing.Font("Poppins", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(40, 290);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(300, 48);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "BURGUER HOUSE";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.pnlRight.Controls.Add(this.lblRodape);
            this.pnlRight.Controls.Add(this.lblMensagem);
            this.pnlRight.Controls.Add(this.btnEntrar);
            this.pnlRight.Controls.Add(this.lnkEsqueciSenha);
            this.pnlRight.Controls.Add(this.chkLembrar);
            this.pnlRight.Controls.Add(this.pnlSenha);
            this.pnlRight.Controls.Add(this.lblCaptionSenha);
            this.pnlRight.Controls.Add(this.pnlUsuario);
            this.pnlRight.Controls.Add(this.lblCaptionUsuario);
            this.pnlRight.Controls.Add(this.lblSubtitulo);
            this.pnlRight.Controls.Add(this.lblTitulo);
            this.pnlRight.Controls.Add(this.pnlDragArea);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(380, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(520, 550);
            this.pnlRight.TabIndex = 1;
            // 
            // lblRodape
            // 
            this.lblRodape.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblRodape.Location = new System.Drawing.Point(80, 505);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(360, 20);
            this.lblRodape.TabIndex = 11;
            this.lblRodape.Text = "© 2026 Kaio Andrião Dalfior - Todos os direitos reservados";
            this.lblRodape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Poppins", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(54)))));
            this.lblMensagem.Location = new System.Drawing.Point(80, 463);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(360, 20);
            this.lblMensagem.TabIndex = 10;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.btnEntrar.CornerRadius = 12;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(80, 410);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(360, 44);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lnkEsqueciSenha
            // 
            this.lnkEsqueciSenha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEsqueciSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEsqueciSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lnkEsqueciSenha.Location = new System.Drawing.Point(266, 367);
            this.lnkEsqueciSenha.Name = "lnkEsqueciSenha";
            this.lnkEsqueciSenha.Size = new System.Drawing.Size(174, 20);
            this.lnkEsqueciSenha.TabIndex = 5;
            this.lnkEsqueciSenha.TabStop = true;
            this.lnkEsqueciSenha.Text = "Esqueceu a senha?";
            this.lnkEsqueciSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkEsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEsqueciSenha_LinkClicked);
            // 
            // chkLembrar
            // 
            this.chkLembrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLembrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLembrar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLembrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.chkLembrar.Location = new System.Drawing.Point(80, 366);
            this.chkLembrar.Name = "chkLembrar";
            this.chkLembrar.Size = new System.Drawing.Size(150, 24);
            this.chkLembrar.TabIndex = 4;
            this.chkLembrar.Text = "Lembrar-me";
            this.chkLembrar.UseVisualStyleBackColor = true;
            // 
            // pnlSenha
            // 
            this.pnlSenha.BackColor = System.Drawing.Color.White;
            this.pnlSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlSenha.BorderThickness = 1;
            this.pnlSenha.Controls.Add(this.lblMostrarSenha);
            this.pnlSenha.Controls.Add(this.txtSenha);
            this.pnlSenha.Controls.Add(this.lblIconSenha);
            this.pnlSenha.CornerRadius = 12;
            this.pnlSenha.Location = new System.Drawing.Point(80, 303);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(360, 48);
            this.pnlSenha.TabIndex = 3;
            // 
            // lblMostrarSenha
            // 
            this.lblMostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMostrarSenha.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblMostrarSenha.Location = new System.Drawing.Point(320, 12);
            this.lblMostrarSenha.Name = "lblMostrarSenha";
            this.lblMostrarSenha.Size = new System.Drawing.Size(28, 24);
            this.lblMostrarSenha.TabIndex = 2;
            this.lblMostrarSenha.Text = "👁";
            this.lblMostrarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMostrarSenha.Click += new System.EventHandler(this.lblMostrarSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.txtSenha.Location = new System.Drawing.Point(50, 15);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(262, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // lblIconSenha
            // 
            this.lblIconSenha.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblIconSenha.Location = new System.Drawing.Point(14, 12);
            this.lblIconSenha.Name = "lblIconSenha";
            this.lblIconSenha.Size = new System.Drawing.Size(28, 24);
            this.lblIconSenha.TabIndex = 0;
            this.lblIconSenha.Text = "🔒";
            this.lblIconSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionSenha
            // 
            this.lblCaptionSenha.AutoSize = true;
            this.lblCaptionSenha.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.lblCaptionSenha.Location = new System.Drawing.Point(80, 278);
            this.lblCaptionSenha.Name = "lblCaptionSenha";
            this.lblCaptionSenha.Size = new System.Drawing.Size(53, 23);
            this.lblCaptionSenha.TabIndex = 2;
            this.lblCaptionSenha.Text = "Senha";
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.White;
            this.pnlUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlUsuario.BorderThickness = 1;
            this.pnlUsuario.Controls.Add(this.txtUsuario);
            this.pnlUsuario.Controls.Add(this.lblIconUsuario);
            this.pnlUsuario.CornerRadius = 12;
            this.pnlUsuario.Location = new System.Drawing.Point(80, 215);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(360, 48);
            this.pnlUsuario.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.txtUsuario.Location = new System.Drawing.Point(50, 15);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(295, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // lblIconUsuario
            // 
            this.lblIconUsuario.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblIconUsuario.Location = new System.Drawing.Point(14, 12);
            this.lblIconUsuario.Name = "lblIconUsuario";
            this.lblIconUsuario.Size = new System.Drawing.Size(28, 24);
            this.lblIconUsuario.TabIndex = 0;
            this.lblIconUsuario.Text = "👤";
            this.lblIconUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionUsuario
            // 
            this.lblCaptionUsuario.AutoSize = true;
            this.lblCaptionUsuario.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.lblCaptionUsuario.Location = new System.Drawing.Point(80, 190);
            this.lblCaptionUsuario.Name = "lblCaptionUsuario";
            this.lblCaptionUsuario.Size = new System.Drawing.Size(62, 23);
            this.lblCaptionUsuario.TabIndex = 0;
            this.lblCaptionUsuario.Text = "Usuário";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(81, 133);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(225, 23);
            this.lblSubtitulo.TabIndex = 9;
            this.lblSubtitulo.Text = "Acesse sua conta para continuar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.lblTitulo.Location = new System.Drawing.Point(78, 84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 53);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Bem-vindo de volta!";
            // 
            // pnlDragArea
            // 
            this.pnlDragArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.pnlDragArea.Controls.Add(this.lblFechar);
            this.pnlDragArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragArea.Location = new System.Drawing.Point(0, 0);
            this.pnlDragArea.Name = "pnlDragArea";
            this.pnlDragArea.Size = new System.Drawing.Size(520, 48);
            this.pnlDragArea.TabIndex = 7;
            this.pnlDragArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragArea_MouseDown);
            // 
            // lblFechar
            // 
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblFechar.Location = new System.Drawing.Point(480, 12);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(24, 24);
            this.lblFechar.TabIndex = 0;
            this.lblFechar.Text = "×";
            this.lblFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_burguer_100__1_;
            this.picLogo.Location = new System.Drawing.Point(145, 163);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlSenha.ResumeLayout(false);
            this.pnlSenha.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlDragArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Lanchonete001.UI.RoundedPanel pnlLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblSlogan;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlDragArea;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Label lblCaptionUsuario;
        private Lanchonete001.UI.RoundedPanel pnlUsuario;
        private System.Windows.Forms.Label lblIconUsuario;
        private System.Windows.Forms.TextBox txtUsuario;

        private System.Windows.Forms.Label lblCaptionSenha;
        private Lanchonete001.UI.RoundedPanel pnlSenha;
        private System.Windows.Forms.Label lblIconSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblMostrarSenha;

        private System.Windows.Forms.CheckBox chkLembrar;
        private System.Windows.Forms.LinkLabel lnkEsqueciSenha;

        private Lanchonete001.UI.RoundedButton btnEntrar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblRodape;
    }
}