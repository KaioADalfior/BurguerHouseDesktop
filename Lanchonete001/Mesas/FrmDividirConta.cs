using System;
using System.Windows.Forms;

namespace Lanchonete001.Mesas
{
    /// <summary>
    /// Diálogo simples de divisão de conta: recebe o total já fechado do
    /// pedido (com desconto aplicado) e calcula quanto cada pessoa paga,
    /// com uma gorjeta percentual opcional. Não altera o PedidoMesa —
    /// é só uma calculadora de apoio para o garçom/caixa.
    /// </summary>
    public partial class FrmDividirConta : Form
    {
        private readonly decimal _totalConta;

        public FrmDividirConta(decimal totalConta)
        {
            _totalConta = totalConta;
            InitializeComponent();
        }

        private void FrmDividirConta_Load(object sender, EventArgs e)
        {
            lblTotalValor.Text = _totalConta.ToString("C2");
            Recalcular();
        }

        private void AoMudarValores(object sender, EventArgs e)
        {
            Recalcular();
        }

        private void Recalcular()
        {
            int pessoas = (int)numPessoas.Value;
            decimal percentualGorjeta = numGorjeta.Value;

            decimal totalComGorjeta = _totalConta * (1 + percentualGorjeta / 100m);
            decimal porPessoa = pessoas > 0 ? totalComGorjeta / pessoas : totalComGorjeta;

            lblResultadoValor.Text = porPessoa.ToString("C2");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}