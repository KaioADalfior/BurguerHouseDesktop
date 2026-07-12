using Lanchonete001.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete001.Estoque
{
    public partial class UcEstoque : UserControl
    {
        private const string PlaceholderBusca = "Buscar insumo...";

        private List<Insumo> listaInsumos;
        private BindingSource bindingInsumos;

        public UcEstoque()
        {
            InitializeComponent();

            CarregarDadosTeste();
            ConfigurarCombos();
            ConfigurarGrid();
            PopularGrid();
            ConfigurarFiltros();
            AtualizarCardsResumo();
        }

        private void CarregarDadosTeste()
        {
            listaInsumos = new List<Insumo>
            {
                new Insumo { Nome = "Bacon (fatia)",         Categoria = "Carnes",                   QuantidadeAtual = 48,   Unidade = "un", QuantidadeMinima = 20 },
                new Insumo { Nome = "Pão brioche",           Categoria = "Pães",                     QuantidadeAtual = 15,   Unidade = "un", QuantidadeMinima = 30 },
                new Insumo { Nome = "Hambúrguer 150g",       Categoria = "Carnes",                   QuantidadeAtual = 60,   Unidade = "un", QuantidadeMinima = 25 },
                new Insumo { Nome = "Queijo prato (fatia)",  Categoria = "Laticínios",                QuantidadeAtual = 8,    Unidade = "un", QuantidadeMinima = 20 },
                new Insumo { Nome = "Alface",                Categoria = "Vegetais",                 QuantidadeAtual = 2.5m, Unidade = "kg", QuantidadeMinima = 3  },
                new Insumo { Nome = "Refrigerante (ml)",     Categoria = "Bebidas/Insumos líquidos",  QuantidadeAtual = 12,   Unidade = "L",  QuantidadeMinima = 10 },
                new Insumo { Nome = "Copo descartável 300ml", Categoria = "Embalagens",               QuantidadeAtual = 200,  Unidade = "un", QuantidadeMinima = 100 },
            };
        }

        private void ConfigurarCombos()
        {
            cboFiltroCategoriaInsumo.Items.Clear();
            cboFiltroCategoriaInsumo.Items.Add("Todas as categorias");
            cboFiltroCategoriaInsumo.Items.AddRange(new object[]
            {
                "Carnes", "Pães", "Laticínios", "Vegetais",
                "Bebidas/Insumos líquidos", "Embalagens"
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
                FillWeight = 24
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategoria",
                HeaderText = "Categoria",
                DataPropertyName = "Categoria",
                FillWeight = 20
            });

            var colQtdAtual = new DataGridViewTextBoxColumn
            {
                Name = "colQtdAtual",
                HeaderText = "Qtd. Atual",
                DataPropertyName = "QuantidadeAtual",
                FillWeight = 12
            };
            colQtdAtual.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colQtdAtual.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add(colQtdAtual);

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUnidade",
                HeaderText = "Unidade",
                DataPropertyName = "Unidade",
                FillWeight = 9
            });

            var colQtdMinima = new DataGridViewTextBoxColumn
            {
                Name = "colQtdMinima",
                HeaderText = "Qtd. Mínima",
                DataPropertyName = "QuantidadeMinima",
                FillWeight = 12
            };
            colQtdMinima.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colQtdMinima.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add(colQtdMinima);

            var colStatus = new DataGridViewTextBoxColumn
            {
                Name = "colStatus",
                HeaderText = "Status",
                FillWeight = 15,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            colStatus.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(colStatus);

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            dataGridView1.CellPainting += DataGridView1_CellPainting;
        }

        private void ConfigurarFiltros()
        {
            // Conecta busca e filtro de categoria à mesma lógica de filtragem
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

        /// <summary>
        /// Destaca sutilmente a linha inteira quando o insumo está com estoque baixo.
        /// </summary>
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var insumo = dataGridView1.Rows[e.RowIndex].DataBoundItem as Insumo;
            if (insumo != null && insumo.EstoqueBaixo)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 238, 235);
            }
        }

        /// <summary>
        /// Desenha a coluna de Status como um "badge" (pílula colorida com ponto),
        /// muito mais moderno do que texto com emoji.
        /// </summary>
        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex].Name != "colStatus")
                return;

            var insumo = dataGridView1.Rows[e.RowIndex].DataBoundItem as Insumo;
            if (insumo == null) return;

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

        private void AtualizarCardsResumo()
        {
            int totalInsumos = listaInsumos.Count;
            int totalBaixo = listaInsumos.Count(i => i.EstoqueBaixo);

            lblTotalInsumos.Text = totalInsumos.ToString();
            lblEstoqueBaixo.Text = totalBaixo.ToString();

            // Estimativa simples de valor (sem PrecoUnitario ainda, mantém texto informativo)
            lblValorEstoque.Text = $"{totalInsumos} itens";
        }


        private void btnNovoInsumo_Click(object sender, EventArgs e)
        {
            var frm = new FrmNovoInsumo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                listaInsumos.Add(frm.InsumoCriado);
                AplicarFiltro(); // já reaplica o filtro atual, se houver
                AtualizarCardsResumo();
            }
        }
    }
}


