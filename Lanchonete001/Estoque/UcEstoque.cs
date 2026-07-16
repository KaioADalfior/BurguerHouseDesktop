using Lanchonete001.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lanchonete001.Estoque
{
    public partial class UcEstoque : UserControl
    {
        private const string PlaceholderBusca = "Buscar insumo...";

        private List<Insumo> listaInsumos = new List<Insumo>();
        private BindingSource bindingInsumos;

        public UcEstoque()
        {
            InitializeComponent();

            ConfigurarCombos();
            ConfigurarGrid();
            ConfigurarFiltros();
            CarregarDados();
        }

        /// <summary>Recarrega os insumos direto do banco de dados (BurguerHouse).</summary>
        private void CarregarDados()
        {
            try
            {
                listaInsumos = EstoqueRepositorio.Listar();

                PopularGrid();
                AtualizarCardsResumo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar o estoque do banco de dados.\n\n" +
                    "Verifique se o MySQL está rodando e se o banco 'burguerhouse' foi criado.\n\n" +
                    "Detalhes: " + ex.Message,
                    "Erro de conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarCombos()
        {
            cboFiltroCategoriaInsumo.Items.Clear();
            cboFiltroCategoriaInsumo.Items.Add("Todas as categorias");
            cboFiltroCategoriaInsumo.Items.AddRange(new object[]
            {
                "Carnes", "Pães", "Laticínios", "Vegetais",
                "Bebidas/Insumos líquidos", "Embalagens", "Molhos"
            });
            cboFiltroCategoriaInsumo.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colInsumo",
                HeaderText = "Insumo",
                DataPropertyName = "Nome",
                FillWeight = 22
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategoria",
                HeaderText = "Categoria",
                DataPropertyName = "Categoria",
                FillWeight = 18
            });

            var colQtdAtual = new DataGridViewTextBoxColumn
            {
                Name = "colQtdAtual",
                HeaderText = "Qtd. Atual",
                DataPropertyName = "QuantidadeAtual",
                FillWeight = 11
            };
            colQtdAtual.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colQtdAtual.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add(colQtdAtual);

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUnidade",
                HeaderText = "Unidade",
                DataPropertyName = "Unidade",
                FillWeight = 8
            });

            var colQtdMinima = new DataGridViewTextBoxColumn
            {
                Name = "colQtdMinima",
                HeaderText = "Qtd. Mínima",
                DataPropertyName = "QuantidadeMinima",
                FillWeight = 11
            };
            colQtdMinima.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colQtdMinima.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add(colQtdMinima);

            var colStatus = new DataGridViewTextBoxColumn
            {
                Name = "colStatus",
                HeaderText = "Status",
                FillWeight = 14,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            colStatus.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(colStatus);

            var colAcoes = new DataGridViewTextBoxColumn
            {
                Name = "colAcoes",
                HeaderText = "",
                FillWeight = 10,
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
            txtBuscaInsumo.TextChanged += (s, e) => AplicarFiltro();
            cboFiltroCategoriaInsumo.SelectedIndexChanged += (s, e) => AplicarFiltro();

            ConfigurarPlaceholderBusca();
        }

        private void ConfigurarPlaceholderBusca()
        {
            txtBuscaInsumo.Text = PlaceholderBusca;
            txtBuscaInsumo.ForeColor = AppColors.TextMuted;

            txtBuscaInsumo.Enter += (s, e) =>
            {
                if (txtBuscaInsumo.Text == PlaceholderBusca)
                {
                    txtBuscaInsumo.Text = string.Empty;
                    txtBuscaInsumo.ForeColor = AppColors.TextDark;
                }
            };

            txtBuscaInsumo.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscaInsumo.Text))
                {
                    txtBuscaInsumo.Text = PlaceholderBusca;
                    txtBuscaInsumo.ForeColor = AppColors.TextMuted;
                }
            };
        }

        private void PopularGrid()
        {
            bindingInsumos = new BindingSource { DataSource = listaInsumos };
            dataGridView1.DataSource = bindingInsumos;
        }

        private void AplicarFiltro()
        {
            if (bindingInsumos == null) return;

            string termoBusca = txtBuscaInsumo.Text == PlaceholderBusca
                ? string.Empty
                : txtBuscaInsumo.Text.Trim().ToLower();

            string categoriaSelecionada = cboFiltroCategoriaInsumo.SelectedItem?.ToString();

            var filtrados = listaInsumos.Where(i =>
                (string.IsNullOrEmpty(termoBusca) || i.Nome.ToLower().Contains(termoBusca)) &&
                (categoriaSelecionada == "Todas as categorias" || categoriaSelecionada == null || i.Categoria == categoriaSelecionada)
            ).ToList();

            bindingInsumos.DataSource = filtrados;
            dataGridView1.Invalidate();
        }

        /// <summary>Destaca sutilmente a linha inteira quando o insumo está com estoque baixo.</summary>
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var insumo = dataGridView1.Rows[e.RowIndex].DataBoundItem as Insumo;
            if (insumo != null && insumo.EstoqueBaixo)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 238, 235);
            }
        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var insumo = dataGridView1.Rows[e.RowIndex].DataBoundItem as Insumo;
            if (insumo == null) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "colStatus")
            {
                PintarBadgeStatus(e, insumo);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "colAcoes")
            {
                PintarLinkEditar(e);
            }
        }

        /// <summary>Desenha a coluna de Status como um "badge" (pílula colorida com ponto).</summary>
        private void PintarBadgeStatus(DataGridViewCellPaintingEventArgs e, Insumo insumo)
        {
            e.PaintBackground(e.CellBounds, true);

            bool baixo = insumo.EstoqueBaixo;
            string texto = baixo ? "Baixo" : "Normal";
            Color corFundo = baixo ? AppColors.DangerLight : AppColors.SuccessLight;
            Color corTexto = baixo ? AppColors.Danger : AppColors.Success;

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

            var insumo = dataGridView1.Rows[rowIndex].DataBoundItem as Insumo;
            if (insumo == null) return;

            var frm = new FrmNovoInsumo(insumo);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CarregarDados(); // recarrega já com a alteração salva no banco
            }
        }

        private void AtualizarCardsResumo()
        {
            int totalInsumos = listaInsumos.Count;
            int totalBaixo = listaInsumos.Count(i => i.EstoqueBaixo);
            decimal valorTotalEstoque = listaInsumos.Sum(i => i.ValorTotal);

            lblTotalInsumos.Text = totalInsumos.ToString();
            lblEstoqueBaixo.Text = totalBaixo.ToString();
            lblValorEstoque.Text = "R$ " + valorTotalEstoque.ToString("N2", new CultureInfo("pt-BR"));
        }

        private void btnNovoInsumo_Click(object sender, EventArgs e)
        {
            var frm = new FrmNovoInsumo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CarregarDados();
            }
        }
    }
}