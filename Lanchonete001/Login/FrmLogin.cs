using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lanchonete001.Login
{
    public partial class FrmLogin : Form
    {
        // ---- Credenciais fixas (conforme solicitado) ----
        private const string USUARIO_VALIDO = "user";
        private const string SENHA_VALIDA = "user";

        private bool _senhaVisivel = false;

        #region Drag da janela sem borda (Win32)

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #endregion

        public FrmLogin()
        {
            InitializeComponent();

            // Cantos arredondados da janela
            this.Load += (s, e) => AplicarCantosArredondados();
            this.Resize += (s, e) => AplicarCantosArredondados();

            // Enter para logar a partir de qualquer campo
            this.AcceptButton = this.btnEntrar;

            txtUsuario.Focus();
        }

        private void AplicarCantosArredondados()
        {
            int raio = 20;
            GraphicsPath caminho = new GraphicsPath();
            Rectangle area = new Rectangle(0, 0, this.Width, this.Height);

            caminho.AddArc(area.X, area.Y, raio, raio, 180, 90);
            caminho.AddArc(area.Right - raio, area.Y, raio, raio, 270, 90);
            caminho.AddArc(area.Right - raio, area.Bottom - raio, raio, raio, 0, 90);
            caminho.AddArc(area.X, area.Bottom - raio, raio, raio, 90, 90);
            caminho.CloseFigure();

            this.Region = new Region(caminho);
        }

        #region Arraste da janela (arrastar pela área superior / painel esquerdo)

        private void pnlDragArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblMostrarSenha_Click(object sender, EventArgs e)
        {
            _senhaVisivel = !_senhaVisivel;
            txtSenha.PasswordChar = _senhaVisivel ? '\0' : '●';
            lblMostrarSenha.Text = _senhaVisivel ? "🙈" : "👁";
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ValidarLogin();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ValidarLogin();
        }

        private void lnkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Entre em contato com o administrador do sistema para redefinir sua senha.",
                "Recuperar senha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ValidarLogin()
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MostrarErro("Preencha usuário e senha.");
                return;
            }

            if (usuario == USUARIO_VALIDO && senha == SENHA_VALIDA)
            {
                // "Lembrar-me" fica disponível em chkLembrar.Checked para,
                // se desejado, persistir o usuário (ex.: Properties.Settings) aqui.

                lblMensagem.ForeColor = Color.FromArgb(46, 139, 87);
                lblMensagem.Text = "Login realizado com sucesso!";

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MostrarErro("Usuário ou senha inválidos.");
                AnimarErro();
            }
        }

        private void MostrarErro(string mensagem)
        {
            lblMensagem.ForeColor = Color.FromArgb(196, 69, 54);
            lblMensagem.Text = mensagem;
        }

        /// <summary>
        /// Pequena animação de "tremida" na janela para reforçar o erro de login.
        /// </summary>
        private void AnimarErro()
        {
            Point posicaoOriginal = this.Location;
            int deslocamento = 8;
            int passos = 0;
            Timer timer = new Timer { Interval = 25 };

            timer.Tick += (s, e) =>
            {
                passos++;
                int offset = (passos % 2 == 0) ? deslocamento : -deslocamento;
                this.Location = new Point(posicaoOriginal.X + offset, posicaoOriginal.Y);

                if (passos >= 6)
                {
                    timer.Stop();
                    timer.Dispose();
                    this.Location = posicaoOriginal;
                }
            };

            timer.Start();
        }
    }
}