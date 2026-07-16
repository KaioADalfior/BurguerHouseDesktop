using Lanchonete001.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lanchonete001.Usuarios
{
    public partial class UcUsuarios : UserControl
    {
        private const string PlaceholderBusca = "Buscar usuário...";

        private List<Usuario> listaUsuarios = new List<Usuario>();
        private List<Cargo> listaCargos = new List<Cargo>();
        private BindingSource bindingUsuarios;

        /// <summary>Usuário autenticado que está usando o sistema, usado para
        /// aplicar as regras de permissão (ex.: só Admin cadastra Admin).</summary>
        private readonly Usuario usuarioLogado;

        public UcUsuarios() : this(null)
        {
        }

        public UcUsuarios(Usuario usuarioLogado)
        {
            InitializeComponent();

            this.usuarioLogado = usuarioLogado;

            ConfigurarGrid();
            ConfigurarFiltros();
            CarregarDados();
        }

        /// <summary>Recarrega cargos e usuários direto do banco de dados (BurguerHouse).</summary>
        private void CarregarDados()
        {
            try
            {
                listaCargos = UsuarioRepositorio.ListarCargos();
                listaUsuarios = UsuarioRepositorio.Listar();

                ConfigurarComboCargos();
                PopularGrid();
                AtualizarCardsResumo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar os usuários do banco de dados.\n\n" +
                    "Verifique se o MySQL está rodando e se o banco 'burguerhouse' foi criado.\n\n" +
                    "Detalhes: " + ex.Message,
                    "Erro de conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarComboCargos()
        {
            cboFiltroCargo.Items.Clear();
            cboFiltroCargo.Items.Add("Todos os cargos");

            foreach (var cargo in listaCargos)
                cboFiltroCargo.Items.Add(cargo.Nome);

            cboFiltroCargo.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNome",
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                FillWeight = 26
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsuario",
                HeaderText = "Usuário",
                DataPropertyName = "NomeUsuario",
                FillWeight = 20
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCargo",
                HeaderText = "Cargo",
                DataPropertyName = "CargoNome",
                FillWeight = 18
            });

            var colStatus = new DataGridViewTextBoxColumn
            {
                Name = "colStatus",
                HeaderText = "Status",
                FillWeight = 16,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            colStatus.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(colStatus);

            var colAcoes = new DataGridViewTextBoxColumn
            {
                Name = "colAcoes",
                HeaderText = "",
                FillWeight = 12,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                ReadOnly = true
            };
            colAcoes.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(colAcoes);

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;
        }

        private void ConfigurarFiltros()
        {
            txtBuscaUsuario.TextChanged += (s, e) => AplicarFiltro();
            cboFiltroCargo.SelectedIndexChanged += (s, e) => AplicarFiltro();

            ConfigurarPlaceholderBusca();
        }

        private void ConfigurarPlaceholderBusca()
        {
            txtBuscaUsuario.Text = PlaceholderBusca;
            txtBuscaUsuario.ForeColor = AppColors.TextMuted;

            txtBuscaUsuario.Enter += (s, e) =>
            {
                if (txtBuscaUsuario.Text == PlaceholderBusca)
                {
                    txtBuscaUsuario.Text = string.Empty;
                    txtBuscaUsuario.ForeColor = AppColors.TextDark;
                }
            };

            txtBuscaUsuario.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscaUsuario.Text))
                {
                    txtBuscaUsuario.Text = PlaceholderBusca;
                    txtBuscaUsuario.ForeColor = AppColors.TextMuted;
                }
            };
        }

        private void PopularGrid()
        {
            bindingUsuarios = new BindingSource { DataSource = listaUsuarios };
            dataGridView1.DataSource = bindingUsuarios;
        }

        private void AplicarFiltro()
        {
            if (bindingUsuarios == null) return;

            string termoBusca = txtBuscaUsuario.Text == PlaceholderBusca
                ? string.Empty
                : txtBuscaUsuario.Text.Trim().ToLower();

            string cargoSelecionado = cboFiltroCargo.SelectedItem?.ToString();

            var filtrados = listaUsuarios.Where(u =>
                (string.IsNullOrEmpty(termoBusca) ||
                    u.Nome.ToLower().Contains(termoBusca) ||
                    u.NomeUsuario.ToLower().Contains(termoBusca)) &&
                (cargoSelecionado == "Todos os cargos" || cargoSelecionado == null || u.CargoNome == cargoSelecionado)
            ).ToList();

            bindingUsuarios.DataSource = filtrados;
            dataGridView1.Invalidate();
        }

        /// <summary>Destaca sutilmente a linha inteira quando o usuário está inativo.</summary>
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var usuario = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
            if (usuario != null && !usuario.Ativo)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 238, 235);
            }
        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var usuario = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
            if (usuario == null) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "colStatus")
            {
                PintarBadgeStatus(e, usuario);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "colAcoes")
            {
                PintarLinkEditar(e);
            }
        }

        /// <summary>Desenha a coluna de Status como um "badge" (pílula colorida com ponto).</summary>
        private void PintarBadgeStatus(DataGridViewCellPaintingEventArgs e, Usuario usuario)
        {
            e.PaintBackground(e.CellBounds, true);

            bool ativo = usuario.Ativo;
            string texto = ativo ? "Ativo" : "Inativo";
            Color corFundo = ativo ? AppColors.SuccessLight : AppColors.DangerLight;
            Color corTexto = ativo ? AppColors.Success : AppColors.Danger;

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Size tamanhoTexto = TextRenderer.MeasureText(texto, e.CellStyle.Font);
            int larguraBadge = tamanhoTexto.Width + 30;
            int alturaBadge = 26;
            int x = e.CellBounds.X + (e.CellBounds.Width - larguraBadge) / 2;
            int y = e.CellBounds.Y + (e.CellBounds.Height - alturaBadge) / 2;
            var badgeRect = new Rectangle(x, y, larguraBadge, alturaBadge);

            using (var path = RoundedPanel.GetRoundedPath(badgeRect, alturaBadge / 2))
            using (var brush = new SolidBrush(corFundo))
            {
                g.FillPath(brush, path);
            }

            int dotSize = 8;
            var dotRect = new Rectangle(x + 12, y + (alturaBadge - dotSize) / 2, dotSize, dotSize);
            using (var dotBrush = new SolidBrush(corTexto))
            {
                g.FillEllipse(dotBrush, dotRect);
            }

            var textRect = new Rectangle(x + 24, y, larguraBadge - 24, alturaBadge);
            TextRenderer.DrawText(g, texto, e.CellStyle.Font, textRect, corTexto,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding);

            e.Handled = true;
        }

        /// <summary>Desenha um link de texto "Editar" na última coluna da grid.</summary>
        private void PintarLinkEditar(DataGridViewCellPaintingEventArgs e)
        {
            e.PaintBackground(e.CellBounds, true);

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            TextRenderer.DrawText(g, "Editar", e.CellStyle.Font, e.CellBounds, AppColors.Primary,
                TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter | TextFormatFlags.NoPadding);

            e.Handled = true;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirEdicao(e.RowIndex);
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "colAcoes")
            {
                AbrirEdicao(e.RowIndex);
            }
        }

        private void AbrirEdicao(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dataGridView1.Rows.Count) return;

            var usuario = dataGridView1.Rows[rowIndex].DataBoundItem as Usuario;
            if (usuario == null) return;

            var frm = new FrmNovoUsuario(usuario, listaCargos, usuarioLogado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CarregarDados(); // recarrega já com a alteração salva no banco
            }
        }

        private void AtualizarCardsResumo()
        {
            int total = listaUsuarios.Count;
            int ativos = listaUsuarios.Count(u => u.Ativo);
            int inativos = total - ativos;

            lblTotalUsuarios.Text = total.ToString();
            lblUsuariosAtivos.Text = ativos.ToString();
            lblUsuariosInativos.Text = inativos.ToString();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            if (listaCargos.Count == 0)
            {
                MessageBox.Show(
                    "Cadastre pelo menos um cargo na tabela 'cargos' antes de criar um usuário.",
                    "Nenhum cargo encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var frm = new FrmNovoUsuario(listaCargos, usuarioLogado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CarregarDados();
            }
        }
    }
}