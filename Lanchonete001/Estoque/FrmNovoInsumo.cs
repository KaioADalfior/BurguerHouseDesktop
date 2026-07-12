using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete001.Estoque
{
    public partial class FrmNovoInsumo : Form
    {
        public Insumo InsumoCriado { get; private set; }

        private Insumo insumoEmEdicao;

        public FrmNovoInsumo()
        {
            InitializeComponent();
            ConfigurarCombos();
        }

        public FrmNovoInsumo(Insumo insumoExistente)
        {
            InitializeComponent();
            ConfigurarCombos();

            insumoEmEdicao = insumoExistente;
            PreencherCamposComInsumo(insumoExistente);
        }

        private void ConfigurarCombos()
        {
            cboCategoriaInsumo.Items.AddRange(new object[]
            {
                "Carnes", "Pães", "Laticínios", "Vegetais",
                "Bebidas/Insumos líquidos", "Embalagens"
            });

            cboUnidadeInsumo.Items.AddRange(new object[] { "un", "kg", "g", "L", "ml" });

            numQuantidadeAtual.DecimalPlaces = 2;
            numQuantidadeAtual.Maximum = 100000;

            numQuantidadeMinima.DecimalPlaces = 2;
            numQuantidadeMinima.Maximum = 100000;

            numPrecoUnitario.DecimalPlaces = 2;
            numPrecoUnitario.Maximum = 100000;
        }

        private void PreencherCamposComInsumo(Insumo insumo)
        {
            txtNomeInsumo.Text = insumo.Nome;
            cboCategoriaInsumo.SelectedItem = insumo.Categoria;
            cboUnidadeInsumo.SelectedItem = insumo.Unidade;
            numQuantidadeAtual.Value = insumo.QuantidadeAtual;
            numQuantidadeMinima.Value = insumo.QuantidadeMinima;
            numPrecoUnitario.Value = insumo.PrecoUnitario;

            // Ajusta os textos do cabeçalho e do botão principal para o modo de edição
            lblTitulo.Text = "Editar Insumo";
            lblSubtitulo.Text = "Atualize os dados do insumo abaixo";
            btnSalvarInsumo.Text = "Atualizar";
            this.Text = "Editar Insumo";
        }

        private void SalvarInsumo()
        {
            if (!ValidarCampos()) return;

            // Se já existia (edição), reaproveita o mesmo objeto;
            // se é novo, cria um Insumo do zero
            var insumo = insumoEmEdicao ?? new Insumo();

            insumo.Nome = txtNomeInsumo.Text.Trim();
            insumo.Categoria = cboCategoriaInsumo.SelectedItem.ToString();
            insumo.Unidade = cboUnidadeInsumo.SelectedItem.ToString();
            insumo.QuantidadeAtual = numQuantidadeAtual.Value;
            insumo.QuantidadeMinima = numQuantidadeMinima.Value;
            insumo.PrecoUnitario = numPrecoUnitario.Value;

            InsumoCriado = insumo;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelar()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LimparCampos()
        {
            txtNomeInsumo.Clear();
            cboCategoriaInsumo.SelectedIndex = -1;
            cboUnidadeInsumo.SelectedIndex = -1;
            numQuantidadeAtual.Value = 0;
            numQuantidadeMinima.Value = 0;
            numPrecoUnitario.Value = 0;
            txtNomeInsumo.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomeInsumo.Text))
            {
                MessageBox.Show("Informe o nome do insumo.", "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeInsumo.Focus();
                return false;
            }

            if (cboCategoriaInsumo.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria.", "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoriaInsumo.Focus();
                return false;
            }

            if (cboUnidadeInsumo.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma unidade de medida.", "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboUnidadeInsumo.Focus();
                return false;
            }

            return true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarInsumo_Click(object sender, EventArgs e)
        {
            SalvarInsumo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
    }
}
