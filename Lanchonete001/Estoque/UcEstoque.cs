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
        private List<Insumo> listaInsumos;

        public UcEstoque()
        {
            InitializeComponent();
            CarregarDadosTeste();
            ConfigurarGrid();
            PopularGrid();
            AtualizarCardsResumo();
        }

        private void UcEstoque_Load(object sender, EventArgs e)
        {
            CarregarDadosTeste();
        }

       private void CarregarDadosTeste()
        {
            lblValorEstoque.Text = "R$ 9.000,00";
            


            listaInsumos = new List<Insumo>
            {
                new Insumo { Nome = "Bacon (fatia)",     Categoria = "Carnes",     QuantidadeAtual = 48,  Unidade = "un", QuantidadeMinima = 20 },
                new Insumo { Nome = "Pão brioche",        Categoria = "Pães",       QuantidadeAtual = 15,  Unidade = "un", QuantidadeMinima = 30 },
                new Insumo { Nome = "Hambúrguer 150g",    Categoria = "Carnes",     QuantidadeAtual = 60,  Unidade = "un", QuantidadeMinima = 25 },
                new Insumo { Nome = "Queijo prato (fatia)", Categoria = "Laticínios", QuantidadeAtual = 8,  Unidade = "un", QuantidadeMinima = 20 },
                new Insumo { Nome = "Alface",             Categoria = "Vegetais",   QuantidadeAtual = 2.5m, Unidade = "kg", QuantidadeMinima = 3 },
                new Insumo { Nome = "Refrigerante (ml)",  Categoria = "Bebidas/Insumos líquidos", QuantidadeAtual = 12, Unidade = "L", QuantidadeMinima = 10 },
                new Insumo { Nome = "Copo descartável 300ml", Categoria = "Embalagens", QuantidadeAtual = 200, Unidade = "un", QuantidadeMinima = 100 },
            };
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
                FillWeight = 25
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategoria",
                HeaderText = "Categoria",
                DataPropertyName = "Categoria",
                FillWeight = 15
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQtdAtual",
                HeaderText = "Qtd. Atual",
                DataPropertyName = "QuantidadeAtual",
                FillWeight = 12
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUnidade",
                HeaderText = "Unidade",
                DataPropertyName = "Unidade",
                FillWeight = 10
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQtdMinima",
                HeaderText = "Qtd. Mínima",
                DataPropertyName = "QuantidadeMinima",
                FillWeight = 12
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStatus",
                HeaderText = "Status",
                FillWeight = 13
                // essa coluna não tem DataPropertyName porque o texto
                // ("🟢 Normal" / "🔴 Baixo") é calculado, não vem direto do objeto
            });

            dataGridView1.CellFormatting += dgvEstoque_CellFormatting;
        }

        private void PopularGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaInsumos;

            // Preenche a coluna calculada de Status linha por linha
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var insumo = (Insumo)row.DataBoundItem;
                row.Cells["colStatus"].Value = insumo.EstoqueBaixo ? "🔴 Baixo" : "🟢 Normal";
            }
        }

        private void dgvEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var insumo = (Insumo)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            if (insumo != null && insumo.EstoqueBaixo)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F5D5D0");
            }
        }

        private void AtualizarCardsResumo()
        {
            int totalInsumos = listaInsumos.Count;
            int totalBaixo = listaInsumos.FindAll(i => i.EstoqueBaixo).Count;

            lblTotalInsumos.Text = totalInsumos.ToString();
            lblEstoqueBaixo.Text = totalBaixo.ToString();
        }

        private void btnNovoInsumo_Click(object sender, EventArgs e)
        {
            var frm = new FrmNovoInsumo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
               listaInsumos.Add(frm.InsumoCriado);
               PopularGrid();
              AtualizarCardsResumo();
            }
        }
    }
}

