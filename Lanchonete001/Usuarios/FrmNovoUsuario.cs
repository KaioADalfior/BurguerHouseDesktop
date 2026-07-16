using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lanchonete001.Usuarios
{
    public partial class FrmNovoUsuario : Form
    {
        private const string CARGO_ADMIN = "Admin";
        private const string CARGO_DONO = "Dono";
        private const string CARGO_GERENTE = "Gerente";

        private readonly List<Cargo> listaCargos;
        private readonly Usuario usuarioLogado;
        private Usuario usuarioEmEdicao;

        /// <summary>Modo cadastro.</summary>
        public FrmNovoUsuario(List<Cargo> cargos, Usuario usuarioLogado)
        {
            InitializeComponent();

            this.usuarioLogado = usuarioLogado;
            listaCargos = cargos;
            ConfigurarCombos();
        }

        /// <summary>Modo edição.</summary>
        public FrmNovoUsuario(Usuario usuarioExistente, List<Cargo> cargos, Usuario usuarioLogado)
        {
            InitializeComponent();

            this.usuarioLogado = usuarioLogado;
            listaCargos = cargos;
            ConfigurarCombos();

            usuarioEmEdicao = usuarioExistente;
            PreencherCamposComUsuario(usuarioExistente);
        }

        /// <summary>
        /// Regra de hierarquia de cadastro:
        /// - Admin: pode atribuir qualquer cargo, inclusive Admin.
        /// - Dono: pode atribuir qualquer cargo, exceto Admin.
        /// - Gerente (e demais cargos): podem atribuir qualquer cargo,
        ///   exceto Admin e Dono.
        /// </summary>
        private IEnumerable<string> CargosOcultosParaLogado()
        {
            string cargoLogado = usuarioLogado?.CargoNome;

            if (string.Equals(cargoLogado, CARGO_ADMIN, StringComparison.OrdinalIgnoreCase))
            {
                return Enumerable.Empty<string>();
            }

            if (string.Equals(cargoLogado, CARGO_DONO, StringComparison.OrdinalIgnoreCase))
            {
                return new[] { CARGO_ADMIN };
            }

            // Gerente e qualquer outro cargo (ou nulo): mais restrito
            return new[] { CARGO_ADMIN, CARGO_DONO };
        }

        private void ConfigurarCombos()
        {
            var cargosOcultos = CargosOcultosParaLogado();

            var cargosPermitidos = listaCargos
                .Where(c => !cargosOcultos.Contains(c.Nome, StringComparer.OrdinalIgnoreCase))
                .ToList();

            cboCargo.DisplayMember = "Nome";
            cboCargo.ValueMember = "Id";
            cboCargo.DataSource = cargosPermitidos;
            cboCargo.SelectedIndex = -1;
        }

        private void PreencherCamposComUsuario(Usuario usuario)
        {
            txtNome.Text = usuario.Nome;
            txtNomeUsuario.Text = usuario.NomeUsuario;
            cboCargo.SelectedValue = usuario.CargoId;
            chkAtivo.Checked = usuario.Ativo;

            // Na edição a senha fica em branco: só é alterada se o usuário digitar algo novo.
            txtSenha.Text = string.Empty;
            txtConfirmarSenha.Text = string.Empty;
            lblSenha.Text = "Nova Senha (opcional):";

            lblTitulo.Text = "Editar Usuário";
            lblSubtitulo.Text = "Atualize os dados do usuário abaixo";
            btnSalvarUsuario.Text = "Atualizar";
            this.Text = "Editar Usuário";
        }

        private void SalvarUsuario()
        {
            if (!ValidarCampos()) return;

            try
            {
                bool ehEdicao = usuarioEmEdicao != null;
                var usuario = usuarioEmEdicao ?? new Usuario();

                usuario.Nome = txtNome.Text.Trim();
                usuario.NomeUsuario = txtNomeUsuario.Text.Trim();
                usuario.CargoId = (int)cboCargo.SelectedValue;
                usuario.Ativo = chkAtivo.Checked;

                if (ehEdicao)
                {
                    UsuarioRepositorio.Atualizar(usuario, txtSenha.Text);
                }
                else
                {
                    UsuarioRepositorio.Inserir(usuario, txtSenha.Text);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível salvar o usuário no banco de dados.\n\nDetalhes: " + ex.Message,
                    "Erro ao salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                AvisarCampoObrigatorio("Informe o nome completo do usuário.", txtNome);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text))
            {
                AvisarCampoObrigatorio("Informe o usuário (login).", txtNomeUsuario);
                return false;
            }

            if (cboCargo.SelectedValue == null)
            {
                AvisarCampoObrigatorio("Selecione um cargo.", cboCargo);
                return false;
            }

            // Trava de segurança: mesmo que, por algum motivo, um cargo
            // restrito apareça selecionado, o salvamento é bloqueado se
            // quem está logado não tiver permissão para atribuí-lo.
            var cargoSelecionado = (Cargo)cboCargo.SelectedItem;
            var cargosOcultos = CargosOcultosParaLogado();

            if (cargosOcultos.Contains(cargoSelecionado?.Nome, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Você não tem permissão para atribuir o cargo \"" + cargoSelecionado?.Nome + "\" a um usuário.",
                    "Permissão negada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cboCargo.Focus();
                return false;
            }

            bool ehCadastroNovo = usuarioEmEdicao == null;

            // Senha obrigatória só no cadastro; na edição é opcional (mantém a atual se vazio)
            if (ehCadastroNovo && string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                AvisarCampoObrigatorio("Informe uma senha para o novo usuário.", txtSenha);
                return false;
            }

            if (!string.IsNullOrEmpty(txtSenha.Text) && txtSenha.Text != txtConfirmarSenha.Text)
            {
                AvisarCampoObrigatorio("As senhas não coincidem.", txtConfirmarSenha);
                return false;
            }

            int? idAtual = usuarioEmEdicao?.Id;
            string nomeUsuarioDigitado = txtNomeUsuario.Text.Trim();

            if (UsuarioRepositorio.ExisteNomeUsuario(nomeUsuarioDigitado, idAtual))
            {
                AvisarCampoObrigatorio("Já existe um usuário cadastrado com esse login.", txtNomeUsuario);
                return false;
            }

            return true;
        }

        private void AvisarCampoObrigatorio(string mensagem, Control campo)
        {
            MessageBox.Show(mensagem, "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            campo.Focus();
        }

        private void Cancelar()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            SalvarUsuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void lblMostrarSenha_Click(object sender, EventArgs e)
        {
            bool visivel = txtSenha.PasswordChar == '\0';
            char novoChar = visivel ? '●' : '\0';

            txtSenha.PasswordChar = novoChar;
            txtConfirmarSenha.PasswordChar = novoChar;
            lblMostrarSenha.Text = visivel ? "👁" : "🙈";
        }
    }
}