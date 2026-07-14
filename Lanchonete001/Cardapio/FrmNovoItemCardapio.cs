using Lanchonete001.Estoque;
using Lanchonete001.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lanchonete001.Cardapio
{
    /// <summary>
    /// Formulário único usado tanto para "Novo/Editar Lanche" quanto para
    /// "Novo/Editar Bebida" — o comportamento muda de acordo com o
    /// TipoItemCardapio passado no construtor (título, subtítulo e lista de
    /// categorias sugeridas). O layout fica em FrmNovoItemCardapio.Designer.cs.
    /// </summary>
    public partial class FrmNovoItemCardapio : Form
    {
        private static readonly string[] CategoriasLanche = { "Hambúrgueres", "Sanduíches", "Porções", "Combos" };
        private static readonly string[] CategoriasBebida = { "Refrigerantes", "Sucos", "Águas", "Milk-shakes" };
        private static readonly CultureInfo CulturaMoeda = CultureInfo.GetCultureInfo("pt-BR");

        public ItemCardapio ItemCriado { get; private set; }

        private readonly TipoItemCardapio tipo;
        private readonly ItemCardapio itemEmEdicao;
        private readonly List<IngredienteReceita> ingredientesAtuais = new List<IngredienteReceita>();

        public FrmNovoItemCardapio(TipoItemCardapio tipo) : this(tipo, null) { }

        public FrmNovoItemCardapio(TipoItemCardapio tipo, ItemCardapio itemExistente)
        {
            this.tipo = tipo;
            this.itemEmEdicao = itemExistente;

            InitializeComponent();

            ConfigurarTextosDinamicos();
            ConfigurarCombos();

            if (itemExistente != null)
            {
                PreencherCampos(itemExistente);
            }

            AtualizarResumoCusto();
        }

        private string TituloTela => tipo == TipoItemCardapio.Lanche
            ? (itemEmEdicao == null ? "Cadastrar Lanche" : "Editar Lanche")
            : (itemEmEdicao == null ? "Cadastrar Bebida" : "Editar Bebida");

        private string[] CategoriasDisponiveis => tipo == TipoItemCardapio.Lanche ? CategoriasLanche : CategoriasBebida;

        private void ConfigurarTextosDinamicos()
        {
            this.Text = TituloTela;
            lblTitulo.Text = TituloTela;
            lblSubtitulo.Text = tipo == TipoItemCardapio.Lanche
                ? "Monte a receita a partir dos insumos do estoque"
                : "Monte a bebida a partir dos insumos do estoque";
        }

        private void ConfigurarCombos()
        {
            cboCategoria.Items.Clear();
            cboCategoria.Items.AddRange(CategoriasDisponiveis);

            cboInsumo.Items.Clear();
            cboInsumo.Items.AddRange(EstoqueRepositorio.ListarNomes().ToArray());
            if (cboInsumo.Items.Count > 0) cboInsumo.SelectedIndex = 0;
        }

        private void PreencherCampos(ItemCardapio item)
        {
            txtNome.Text = item.Nome;
            txtDescricao.Text = item.Descricao;
            cboCategoria.SelectedItem = item.Categoria;
            numPrecoVenda.Value = item.PrecoVenda;
            chkAtivo.Checked = item.Ativo;

            ingredientesAtuais.Clear();
            ingredientesAtuais.AddRange(item.Ingredientes.Select(i => new IngredienteReceita
            {
                NomeInsumo = i.NomeInsumo,
                Quantidade = i.Quantidade,
                Unidade = i.Unidade
            }));
            AtualizarListaIngredientes();

            btnSalvar.Text = "Atualizar";
        }

        private void AdicionarIngrediente()
        {
            if (cboInsumo.SelectedItem == null) return;

            string nomeInsumo = cboInsumo.SelectedItem.ToString();
            var insumo = EstoqueRepositorio.BuscarPorNome(nomeInsumo);
            if (insumo == null) return;

            var existente = ingredientesAtuais.FirstOrDefault(i => i.NomeInsumo == nomeInsumo);
            if (existente != null)
            {
                existente.Quantidade += numQuantidadeIngrediente.Value;
            }
            else
            {
                ingredientesAtuais.Add(new IngredienteReceita
                {
                    NomeInsumo = nomeInsumo,
                    Quantidade = numQuantidadeIngrediente.Value,
                    Unidade = insumo.Unidade
                });
            }

            AtualizarListaIngredientes();
        }

        private void RemoverIngredienteSelecionado()
        {
            if (lstIngredientes.SelectedIndex < 0) return;

            ingredientesAtuais.RemoveAt(lstIngredientes.SelectedIndex);
            AtualizarListaIngredientes();
        }

        private void AtualizarListaIngredientes()
        {
            lstIngredientes.Items.Clear();
            foreach (var ing in ingredientesAtuais)
            {
                string custoTexto = ing.CustoItem.ToString("C2", CulturaMoeda);
                lstIngredientes.Items.Add($"{ing.NomeInsumo}  —  {ing.Quantidade} {ing.Unidade}  ({custoTexto})");
            }

            AtualizarResumoCusto();
        }

        private void AtualizarResumoCusto()
        {
            decimal custo = ingredientesAtuais.Sum(i => i.CustoItem);
            decimal margem = numPrecoVenda.Value - custo;

            lblCustoEstimado.Text = $"Custo estimado: {custo.ToString("C2", CulturaMoeda)}";
            lblMargemLucro.Text = $"Margem: {margem.ToString("C2", CulturaMoeda)}";
            lblMargemLucro.ForeColor = margem >= 0 ? AppColors.Success : AppColors.Danger;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do item.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (cboCategoria.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoria.Focus();
                return false;
            }

            if (numPrecoVenda.Value <= 0)
            {
                MessageBox.Show("Informe um preço de venda maior que zero.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPrecoVenda.Focus();
                return false;
            }

            if (ingredientesAtuais.Count == 0)
            {
                var resultado = MessageBox.Show(
                    "Nenhum insumo foi adicionado à receita. Deseja salvar mesmo assim?",
                    "Receita vazia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No) return false;
            }

            return true;
        }

        private void Salvar()
        {
            if (!ValidarCampos()) return;

            var item = itemEmEdicao ?? new ItemCardapio { Tipo = tipo };

            item.Nome = txtNome.Text.Trim();
            item.Categoria = cboCategoria.SelectedItem.ToString();
            item.Descricao = txtDescricao.Text.Trim();
            item.PrecoVenda = numPrecoVenda.Value;
            item.Ativo = chkAtivo.Checked;
            item.Ingredientes = new List<IngredienteReceita>(ingredientesAtuais);

            ItemCriado = item;
            DialogResult = DialogResult.OK;
            Close();
        }

        // ---------------------------------------------------------------
        // Manipuladores de evento (referenciados pelo Designer)
        // ---------------------------------------------------------------
        private void numPrecoVenda_ValueChanged(object sender, EventArgs e)
        {
            AtualizarResumoCusto();
        }

        private void btnAdicionarIngrediente_Click(object sender, EventArgs e)
        {
            AdicionarIngrediente();
        }

        private void btnRemoverIngrediente_Click(object sender, EventArgs e)
        {
            RemoverIngredienteSelecionado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}