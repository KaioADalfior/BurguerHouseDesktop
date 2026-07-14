using Lanchonete001.Impressao;
using Lanchonete001.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Lanchonete001.Mesas
{
    /// <summary>
    /// Checkout da mesa: mostra os itens, calcula o total e, se a forma
    /// de pagamento for Dinheiro, permite digitar o valor recebido e
    /// calcula o troco automaticamente. Só fecha (DialogResult.OK) se o
    /// pagamento em dinheiro cobrir o total. Ao confirmar, oferece a
    /// impressão da comanda completa (itens, desconto, total, forma de
    /// pagamento e troco).
    /// </summary>
    public partial class FrmFecharConta : Form
    {
        private readonly Mesa _mesa;

        public FrmFecharConta(Mesa mesa)
        {
            _mesa = mesa;
            InitializeComponent();
        }

        private void FrmFecharConta_Load(object sender, EventArgs e)
        {
            lblMesaInfo.Text = "Mesa " + _mesa.Numero.ToString("00");
            CarregarItens();
            CarregarTotais();

            rbDinheiro.Checked = true;
            AtualizarPainelDinheiro();
            RecalcularTroco();
        }

        private void CarregarItens()
        {
            lvResumoItens.Items.Clear();
            if (_mesa.Pedido == null) return;

            foreach (var item in _mesa.Pedido.Itens)
            {
                var linha = new ListViewItem(item.NomeProduto);
                linha.SubItems.Add(item.Quantidade.ToString());
                linha.SubItems.Add(item.PrecoUnitario.ToString("C2"));
                linha.SubItems.Add(item.Subtotal.ToString("C2"));
                lvResumoItens.Items.Add(linha);
            }
        }

        private void CarregarTotais()
        {
            var pedido = _mesa.Pedido;
            lblSubtotalValor.Text = (pedido?.Subtotal ?? 0).ToString("C2");
            lblDescontoValor.Text = (pedido?.Desconto ?? 0).ToString("C2");
            lblTotalValor.Text = (pedido?.Total ?? 0).ToString("C2");
        }

        private void rbFormaPagamento_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarPainelDinheiro();
            RecalcularTroco();
        }

        private void AtualizarPainelDinheiro()
        {
            pnlDinheiro.Visible = rbDinheiro.Checked;
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            RecalcularTroco();
        }

        private decimal ObterTotal() => _mesa.Pedido?.Total ?? 0;

        private void RecalcularTroco()
        {
            if (!rbDinheiro.Checked)
            {
                lblTrocoValor.Text = "R$ 0,00";
                lblTrocoValor.ForeColor = AppColors.Success;
                return;
            }

            decimal troco = ObterValorRecebido() - ObterTotal();
            lblTrocoValor.Text = troco.ToString("C2");
            lblTrocoValor.ForeColor = troco < 0 ? AppColors.Danger : AppColors.Success;
        }

        private decimal ObterValorRecebido()
        {
            if (decimal.TryParse(txtValorRecebido.Text, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal valor))
                return valor;

            if (decimal.TryParse(txtValorRecebido.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out valor))
                return valor;

            return 0;
        }

        private FormaPagamento ObterFormaSelecionada()
        {
            if (rbDinheiro.Checked) return FormaPagamento.Dinheiro;
            if (rbCartaoDebito.Checked) return FormaPagamento.CartaoDebito;
            if (rbCartaoCredito.Checked) return FormaPagamento.CartaoCredito;
            return FormaPagamento.Pix;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_mesa.Pedido == null)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            var forma = ObterFormaSelecionada();
            decimal valorRecebido = 0;
            decimal troco = 0;

            if (forma == FormaPagamento.Dinheiro)
            {
                valorRecebido = ObterValorRecebido();

                if (valorRecebido < ObterTotal())
                {
                    MessageBox.Show("O valor recebido é menor que o total da conta.",
                        "Valor insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                troco = valorRecebido - ObterTotal();
            }

            _mesa.Pedido.FormaPagamento = forma;

            // Congela os dados do pedido AGORA, antes de fechar o form,
            // pois MesaRepositorio.FecharConta (chamado por quem abriu
            // este diálogo) limpa mesa.Pedido logo em seguida.
            var dadosComanda = new DadosComanda
            {
                MesaNumero = _mesa.Numero,
                Itens = new List<ItemPedidoMesa>(_mesa.Pedido.Itens),
                Subtotal = _mesa.Pedido.Subtotal,
                Desconto = _mesa.Pedido.Desconto,
                Total = _mesa.Pedido.Total,
                FormaPagamento = forma,
                ValorRecebido = valorRecebido,
                Troco = troco,
                DataHora = DateTime.Now
            };

            var resposta = MessageBox.Show("Deseja imprimir a comanda?", "Imprimir comanda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
                ImpressoraComanda.Imprimir(dadosComanda);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}