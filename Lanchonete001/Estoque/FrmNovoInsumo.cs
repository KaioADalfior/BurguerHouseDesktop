using System;
using System.Windows.Forms;

namespace Lanchonete001.Estoque
{
    public partial class FrmNovoInsumo : Form
    {
        private Insumo insumoEmEdicao;

        /// <summary>Modo cadastro.</summary>
        public FrmNovoInsumo()
        {
            InitializeComponent();
            ConfigurarCombos();
        }

        /// <summary>Modo edição.</summary>
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
                "Bebidas/Insumos líquidos", "Embalagens", "Molhos"
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

            lblTitulo.Text = "Editar Insumo";
            lblSubtitulo.Text = "Atualize os dados do insumo abaixo";
            btnSalvarInsumo.Text = "Atualizar";
            this.Text = "Editar Insumo";
        }

        private void SalvarInsumo()
        {
            if (!ValidarCampos()) return;

            try
            {
                bool ehEdicao = insumoEmEdicao != null;
                var insumo = insumoEmEdicao ?? new Insumo();

                insumo.Nome = txtNomeInsumo.Text.Trim();
                insumo.Categoria = cboCategoriaInsumo.SelectedItem.ToString();
                insumo.Unidade = cboUnidadeInsumo.SelectedItem.ToString();
                insumo.QuantidadeAtual = numQuantidadeAtual.Value;
                insumo.QuantidadeMinima = numQuantidadeMinima.Value;
                insumo.PrecoUnitario = numPrecoUnitario.Value;

                if (ehEdicao)
                {
                    EstoqueRepositorio.Atualizar(insumo);
                }
                else
                {
                    insumo.Id = EstoqueRepositorio.Inserir(insumo);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível salvar o insumo no banco de dados.\n\nDetalhes: " + ex.Message,
                    "Erro ao salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

            string nomeDigitado = txtNomeInsumo.Text.Trim();
            int? idAtual = insumoEmEdicao?.Id;

            if (EstoqueRepositorio.ExisteNome(nomeDigitado, idAtual))
            {
                MessageBox.Show(
                    "Já existe um insumo cadastrado com esse nome.",
                    "Nome duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNomeInsumo.Focus();
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}