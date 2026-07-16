using Lanchonete001.Cardapio;
using Lanchonete001.Estoque;
using Lanchonete001.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lanchonete001.Mesas
{
    public partial class FrmPedidoMesa : Form
    {
        private static readonly Color CorLivre = AppColors.Success;
        private static readonly Color CorOcupada = AppColors.Danger;
        private static readonly Color CorFechando = Color.FromArgb(230, 126, 34);

        private readonly Mesa _mesa;

        public FrmPedidoMesa(Mesa mesa)
        {
            _mesa = mesa;
            InitializeComponent();
        }

        private void FrmPedidoMesa_Load(object sender, EventArgs e)
        {
            CarregarCardapio();
            AtualizarTudo();
        }

        // -----------------------------------------------------------------
        // Carregamento / atualização de tela
        // -----------------------------------------------------------------

        private void CarregarCardapio()
        {
            var disponiveis = CardapioRepositorio.ObterLanches()
                .Concat(CardapioRepositorio.ObterBebidas())
                .Where(i => i.Ativo)
                .OrderBy(i => i.Tipo)
                .ThenBy(i => i.Nome)
                .ToList();

            cboProdutos.DisplayMember = "Nome";
            cboProdutos.DataSource = disponiveis;
            btnAdicionarItem.Enabled = disponiveis.Count > 0;
        }

        /// <summary>
        /// Mostra um MessageBox de aviso (não bloqueia o pedido) sempre que o
        /// item lançado zerar ou faltar algum insumo da receita. O atendente
        /// decide com o cliente se troca o insumo ou segue mesmo assim.
        /// </summary>
        private void MostrarAlertasEstoque(List<AlertaEstoqueInsumo> alertas)
        {
            if (alertas == null || alertas.Count == 0) return;

            var linhas = alertas.Select(a => "• " + a.NomeInsumo + " — " + a.Descricao);

            string mensagem =
                "Atenção: este item deixou o estoque no limite (ou negativo):\n\n" +
                string.Join("\n", linhas) +
                "\n\nConsidere avisar o cliente sobre uma possível troca de insumo.";

            MessageBox.Show(mensagem, "Estoque insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AtualizarTudo()
        {
            AtualizarHeader();
            AtualizarLista();
            AtualizarTotais();
        }

        private void AtualizarHeader()
        {
            lblTituloMesa.Text = "Mesa " + _mesa.Numero.ToString("00");

            Color cor;
            string texto;
            switch (_mesa.Status)
            {
                case StatusMesa.Ocupada: cor = CorOcupada; texto = "Ocupada"; break;
                case StatusMesa.Fechando: cor = CorFechando; texto = "Fechando"; break;
                default: cor = CorLivre; texto = "Livre"; break;
            }

            lblStatusDot.ForeColor = cor;
            lblStatusTexto.ForeColor = cor;
            lblStatusTexto.Text = texto;
        }

        private void AtualizarLista()
        {
            lvItens.Items.Clear();

            if (_mesa.Pedido == null) return;

            foreach (var item in _mesa.Pedido.Itens)
            {
                var linha = new ListViewItem(item.NomeProduto);
                linha.SubItems.Add(item.Quantidade.ToString());
                linha.SubItems.Add(item.PrecoUnitario.ToString("C2"));
                linha.SubItems.Add(item.Subtotal.ToString("C2"));
                linha.Tag = item;
                lvItens.Items.Add(linha);
            }
        }

        private void AtualizarTotais()
        {
            var pedido = _mesa.Pedido;

            lblSubtotalValor.Text = (pedido?.Subtotal ?? 0).ToString("C2");
            lblDescontoValor.Text = (pedido?.Desconto ?? 0).ToString("C2");
            lblTotalValor.Text = (pedido?.Total ?? 0).ToString("C2");

            if (pedido != null)
                txtDesconto.Text = pedido.Desconto.ToString("N2", new CultureInfo("pt-BR"));
        }

        private ItemPedidoMesa ObterItemSelecionado()
        {
            if (lvItens.SelectedItems.Count == 0) return null;
            return lvItens.SelectedItems[0].Tag as ItemPedidoMesa;
        }

        // -----------------------------------------------------------------
        // Itens do pedido
        // -----------------------------------------------------------------

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            var item = cboProdutos.SelectedItem as ItemCardapio;
            if (item == null) return;

            MesaRepositorio.GarantirPedidoAberto(_mesa);
            var alertas = MesaRepositorio.AdicionarItem(_mesa.Pedido, item);

            AtualizarTudo();
            MostrarAlertasEstoque(alertas);
        }

        private void btnAumentarQtd_Click(object sender, EventArgs e)
        {
            var item = ObterItemSelecionado();
            if (item == null) return;

            var alertas = MesaRepositorio.AumentarQuantidade(_mesa.Pedido, item);

            AtualizarTudo();
            MostrarAlertasEstoque(alertas);
        }

        private void btnDiminuirQtd_Click(object sender, EventArgs e)
        {
            var item = ObterItemSelecionado();
            if (item == null) return;

            MesaRepositorio.DiminuirQuantidade(_mesa.Pedido, item);
            AtualizarTudo();
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            var item = ObterItemSelecionado();
            if (item == null) return;

            MesaRepositorio.RemoverItem(_mesa.Pedido, item);
            AtualizarTudo();
        }

        // -----------------------------------------------------------------
        // Desconto
        // -----------------------------------------------------------------

        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            if (_mesa.Pedido == null) return;

            if (!decimal.TryParse(txtDesconto.Text, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal valor)
                && !decimal.TryParse(txtDesconto.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out valor))
            {
                MessageBox.Show("Valor de desconto inválido.", "Desconto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (valor < 0) valor = 0;

            MesaRepositorio.AtualizarDesconto(_mesa.Pedido, valor);
            AtualizarTotais();
        }

        // -----------------------------------------------------------------
        // Ações principais
        // -----------------------------------------------------------------

        private void btnEnviarCozinha_Click(object sender, EventArgs e)
        {
            if (_mesa.Pedido == null || _mesa.Pedido.Itens.Count == 0)
            {
                MessageBox.Show("Adicione ao menos um item antes de enviar para a cozinha.",
                    "Pedido vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MesaRepositorio.EnviarParaCozinha(_mesa);
            MessageBox.Show("Pedido enviado para a cozinha!", "Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFecharConta_Click(object sender, EventArgs e)
        {
            if (_mesa.Pedido == null || _mesa.Pedido.Itens.Count == 0)
            {
                MessageBox.Show("Esta mesa não tem pedido em aberto.",
                    "Nada a fechar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new FrmFecharConta(_mesa))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    MesaRepositorio.FecharConta(_mesa);
                    Close();
                }
            }
        }

        private void btnTransferirMesa_Click(object sender, EventArgs e)
        {
            if (_mesa.Pedido == null || _mesa.Pedido.Itens.Count == 0)
            {
                MessageBox.Show("Não há pedido para transferir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var mesasLivres = MesaRepositorio.ObterMesas()
                .Where(m => m.Status == StatusMesa.Livre && m.Numero != _mesa.Numero)
                .OrderBy(m => m.Numero)
                .ToList();

            if (mesasLivres.Count == 0)
            {
                MessageBox.Show("Não há mesas livres para transferir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new FrmEscolherMesa(mesasLivres))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                var destino = dlg.MesaEscolhida;
                MesaRepositorio.TransferirPedido(_mesa, destino);

                MessageBox.Show($"Pedido transferido para a Mesa {destino.Numero:00}.",
                    "Transferido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnDividirConta_Click(object sender, EventArgs e)
        {
            if (_mesa.Pedido == null || _mesa.Pedido.Itens.Count == 0)
            {
                MessageBox.Show("Não há conta para dividir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new FrmDividirConta(_mesa.Pedido.Total))
            {
                dlg.ShowDialog(this);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}