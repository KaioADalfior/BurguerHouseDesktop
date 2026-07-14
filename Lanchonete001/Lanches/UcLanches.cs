using Lanchonete001.Cardapio;
using Lanchonete001.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lanchonete001.Lanches
{
    public partial class UcLanches : UserControl
    {
        private const string PlaceholderBusca = "Buscar lanche...";
        private static readonly string[] Categorias = { "Hambúrgueres", "Sanduíches", "Porções", "Combos" };

        private List<ItemCardapio> listaLanches;
        private BindingSource bindingLanches;

        public UcLanches()
        {
            InitializeComponent();

            ConfigurarCombos();
            ConfigurarGrid();
            CarregarDados();
            ConfigurarFiltros();
        }

        private void CarregarDados()
        {
            listaLanches = CardapioRepositorio.ObterLanches();

            if (bindingLanches == null)
            {
                bindingLanches = new BindingSource { DataSource = listaLanches };
                dataGridView1.DataSource = bindingLanches;
            }

            AplicarFiltro();
            AtualizarCardsResumo();
        }

        private void ConfigurarCombos()
        {
            cboFiltroCategoria.Items.Clear();
            cboFiltroCategoria.Items.Add("Todas as categorias");
            cboFiltroCategoria.Items.AddRange(Categorias);
            cboFiltroCategoria.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNome",
                HeaderText = "Lanche",
                DataPropertyName = "Nome",
                FillWeight = 22
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategoria",
                HeaderText = "Categoria",
                DataPropertyName = "Categoria",
                FillWeight = 16
            });

            var colPreco = new DataGridViewTextBoxColumn
            {
                Name = "colPreco",
                HeaderText = "Preço",
                FillWeight = 11
            };
            colPreco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPreco.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add(colPreco);

            var colCusto = new DataGridViewTextBoxColumn
            {
                Name = "colCusto",
                HeaderText = "Custo Est.",
                FillWeight = 11
            };
            colCusto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCusto.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add(colCusto);

            var colMargem = new DataGridViewTextBoxColumn
            {
                Name = "colMargem",
                HeaderText = "Margem",
                FillWeight = 11
            };
            colMargem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colMargem.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add(colMargem);

            var colStatus = new DataGridViewTextBoxColumn
            {
                Name = "colStatus",
                HeaderText = "Status",
                FillWeight = 13,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            colStatus.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(colStatus);

            var colEditar = new DataGridViewButtonColumn
            {
                Name = "colEditar",
                HeaderText = "",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                FillWeight = 8,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dataGridView1.Columns.Add(colEditar);

            var colExcluir = new DataGridViewButtonColumn
            {
                Name = "colExcluir",
                HeaderText = "",
                Text = "Excluir",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                FillWeight = 8,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dataGridView1.Columns.Add(colExcluir);

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void ConfigurarFiltros()
        {
            txtBusca.TextChanged += (s, e) => AplicarFiltro();
            cboFiltroCategoria.SelectedIndexChanged += (s, e) => AplicarFiltro();

            ConfigurarPlaceholderBusca();
        }

        private void ConfigurarPlaceholderBusca()
        {
            txtBusca.Text = PlaceholderBusca;
            txtBusca.ForeColor = AppColors.TextMuted;

            txtBusca.Enter += (s, e) =>
            {
                if (txtBusca.Text == PlaceholderBusca)
                {
                    txtBusca.Text = string.Empty;
                    txtBusca.ForeColor = AppColors.TextDark;
                }
            };

            txtBusca.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBusca.Text))
                {
                    txtBusca.Text = PlaceholderBusca;
                    txtBusca.ForeColor = AppColors.TextMuted;
                }
            };
        }

        private void AplicarFiltro()
        {
            if (bindingLanches == null) return;

            string termoBusca = txtBusca.Text == PlaceholderBusca
                ? string.Empty
                : txtBusca.Text.Trim().ToLower();

            string categoriaSelecionada = cboFiltroCategoria.SelectedItem?.ToString();

            var filtrados = listaLanches.Where(i =>
                (string.IsNullOrEmpty(termoBusca) || i.Nome.ToLower().Contains(termoBusca)) &&
                (categoriaSelecionada == "Todas as categorias" || categoriaSelecionada == null || i.Categoria == categoriaSelecionada)
            ).ToList();

            bindingLanches.DataSource = filtrados;
            dataGridView1.Invalidate();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count) return;

            var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as ItemCardapio;
            if (item == null) return;

            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "colPreco":
                    e.Value = item.PrecoVenda.ToString("C2");
                    e.FormattingApplied = true;
                    break;
                case "colCusto":
                    e.Value = item.CustoEstimado.ToString("C2");
                    e.FormattingApplied = true;
                    break;
                case "colMargem":
                    e.Value = item.MargemLucro.ToString("C2");
                    e.FormattingApplied = true;
                    e.CellStyle.ForeColor = item.MargemLucro >= 0 ? AppColors.Success : AppColors.Danger;
                    break;
            }

            if (!item.DisponivelParaVenda)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 238, 235);
            }
        }

        /// <summary>
        /// Desenha a coluna de Status como um "badge" (pílula colorida com ponto).
        /// </summary>
        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex].Name != "colStatus")
                return;

            var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as ItemCardapio;
            if (item == null) return;

            e.PaintBackground(e.CellBounds, true);

            string texto;
            Color corFundo, corTexto;

            if (!item.Ativo)
            {
                texto = "Inativo";
                corFundo = AppColors.Border;
                corTexto = AppColors.TextMuted;
            }
            else if (item.DisponivelParaVenda)
            {
                texto = "Disponível";
                corFundo = AppColors.SuccessLight;
                corTexto = AppColors.Success;
            }
            else
            {
                texto = "Sem estoque";
                corFundo = AppColors.DangerLight;
                corTexto = AppColors.Danger;
            }

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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as ItemCardapio;
            if (item == null) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "colEditar")
            {
                // Editar troca de tela via ShowDialog (modal), então é seguro chamar direto.
                EditarItem(item);
            }
            else if (colName == "colExcluir")
            {
                // Adia a remoção da linha para depois que o DataGridView terminar de
                // processar o clique atual. Remover/trocar o DataSource dentro do próprio
                // CellContentClick faz o grid tentar acessar a linha antiga depois que ela
                // já não existe mais, gerando IndexOutOfRangeException.
                BeginInvoke(new Action(() => ExcluirItem(item)));
            }
        }

        private void EditarItem(ItemCardapio item)
        {
            var frm = new FrmNovoItemCardapio(TipoItemCardapio.Lanche, item);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                AplicarFiltro();
                AtualizarCardsResumo();
            }
        }

        private void ExcluirItem(ItemCardapio item)
        {
            var resultado = MessageBox.Show(
                $"Deseja realmente excluir \"{item.Nome}\" do cardápio?",
                "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            // Limpa a célula/posição atual do grid ANTES de mexer na lista.
            // Sem isso, ao remover a última linha o DataGridView tenta
            // validar/commitar a célula que estava selecionada apontando
            // para um índice que já não existe na nova lista filtrada,
            // gerando IndexOutOfRangeException dentro do CurrencyManager.
            dataGridView1.CurrentCell = null;

            CardapioRepositorio.Remover(item);
            listaLanches.Remove(item);
            AplicarFiltro();
            AtualizarCardsResumo();
        }

        private void AtualizarCardsResumo()
        {
            int total = listaLanches.Count;
            int indisponiveis = listaLanches.Count(i => !i.DisponivelParaVenda);
            decimal margemMedia = total > 0 ? listaLanches.Average(i => i.PercentualMargem) : 0;

            lblTotalItens.Text = total.ToString();
            lblIndisponiveis.Text = indisponiveis.ToString();
            lblMargemMedia.Text = $"{margemMedia:0.0}%";
        }

        private void btnNovoLanche_Click(object sender, EventArgs e)
        {
            var frm = new FrmNovoItemCardapio(TipoItemCardapio.Lanche);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CardapioRepositorio.Adicionar(frm.ItemCriado);
                listaLanches.Add(frm.ItemCriado);
                AplicarFiltro();
                AtualizarCardsResumo();
            }
        }
    }
}