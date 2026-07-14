using Lanchonete001.Produtos;
using Lanchonete001.UI;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lanchonete001.Mesas
{
    public partial class FrmPedidoMesa : Form
    {
        // Mesma cor "Fechando" usada em UcMesas (não existe em AppColors).
        private static readonly Color CorFechando = Color.FromArgb(230, 126, 34);

        private readonly Mesa _mesa;

        public FrmPedidoMesa(Mesa mesa)
        {
            InitializeComponent();

            _mesa = mesa ?? throw new ArgumentNullException(nameof(mesa));

            // Garante que a mesa tenha um objeto de pedido para trabalharmos
            // em cima (mas só marcamos a mesa como "Ocupada" quando o
            // primeiro item for realmente lançado, dentro de AdicionarItem).
            if (_mesa.Pedido == null)
            {
                _mesa.Pedido = new PedidoMesa();
            }

            CarregarProdutos();
            AtualizarCabecalho();
            AtualizarTextoDesconto();
            AtualizarListaItens();
        }

        // ---------------------------------------------------------------
        // Carregamento de dados
        // ---------------------------------------------------------------

        private void CarregarProdutos()
        {
            cboProdutos.DisplayMember = "Nome";
            cboProdutos.Items.Clear();

            foreach (var produto in ProdutoRepositorio.ObterAtivos())
            {
                cboProdutos.Items.Add(produto);
            }

            if (cboProdutos.Items.Count > 0)
            {
                cboProdutos.SelectedIndex = 0;
            }
        }

        // ---------------------------------------------------------------
        // Cabeçalho / status
        // ---------------------------------------------------------------

        private void AtualizarCabecalho()
        {
            lblTituloMesa.Text = "Mesa " + _mesa.Numero.ToString("00");
            lblStatusTexto.Text = TextoStatus(_mesa.Status);

            Color cor = CorStatus(_mesa.Status);
            lblStatusDot.ForeColor = cor;
            lblStatusTexto.ForeColor = cor;
        }

        private static Color CorStatus(StatusMesa status)
        {
            switch (status)
            {
                case StatusMesa.Ocupada: return AppColors.Danger;
                case StatusMesa.Fechando: return CorFechando;
                default: return AppColors.Success;
            }
        }

        private static string TextoStatus(StatusMesa status)
        {
            switch (status)
            {
                case StatusMesa.Ocupada: return "Ocupada";
                case StatusMesa.Fechando: return "Fechando";
                default: return "Livre";
            }
        }

        // ---------------------------------------------------------------
        // Itens do pedido
        // ---------------------------------------------------------------

        private void AtualizarListaItens()
        {
            lvItens.Items.Clear();

            foreach (var item in _mesa.Pedido.Itens)
            {
                var linha = new ListViewItem(item.NomeProduto);
                linha.SubItems.Add(item.Quantidade.ToString());
                linha.SubItems.Add(item.PrecoUnitario.ToString("C2"));
                linha.SubItems.Add(item.Subtotal.ToString("C2"));
                linha.Tag = item;
                lvItens.Items.Add(linha);
            }

            AtualizarTotais();
        }

        private void AtualizarTotais()
        {
            lblSubtotalValor.Text = _mesa.Pedido.Subtotal.ToString("C2");
            lblDescontoValor.Text = _mesa.Pedido.Desconto.ToString("C2");
            lblTotalValor.Text = _mesa.Pedido.Total.ToString("C2");
        }

        private ItemPedidoMesa ObterItemSelecionado()
        {
            if (lvItens.SelectedItems.Count == 0) return null;
            return lvItens.SelectedItems[0].Tag as ItemPedidoMesa;
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (!(cboProdutos.SelectedItem is Produto produtoSelecionado))
            {
                MessageBox.Show(this, "Selecione um lanche para adicionar.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = produtoSelecionado.Nome;
            decimal preco = produtoSelecionado.Preco;

            MesaRepositorio.GarantirPedidoAberto(_mesa);

            var itemExistente = _mesa.Pedido.Itens
                .FirstOrDefault(i => i.NomeProduto == nome && i.PrecoUnitario == preco);

            if (itemExistente != null)
            {
                itemExistente.Quantidade++;
            }
            else
            {
                _mesa.Pedido.Itens.Add(new ItemPedidoMesa
                {
                    NomeProduto = nome,
                    PrecoUnitario = preco,
                    Quantidade = 1
                });
            }

            // Um novo item foi lançado após um envio anterior: reabilita o
            // botão de "Enviar para Cozinha" para essa rodada extra.
            _mesa.Pedido.EnviadoParaCozinha = false;

            AtualizarCabecalho();
            AtualizarListaItens();
        }

        private void btnAumentarQtd_Click(object sender, EventArgs e)
        {
            var item = ObterItemSelecionado();
            if (item == null)
            {
                MessageBox.Show(this, "Selecione um item da lista.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            item.Quantidade++;
            AtualizarListaItens();
        }

        private void btnDiminuirQtd_Click(object sender, EventArgs e)
        {
            var item = ObterItemSelecionado();
            if (item == null)
            {
                MessageBox.Show(this, "Selecione um item da lista.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            item.Quantidade--;
            if (item.Quantidade <= 0)
            {
                _mesa.Pedido.Itens.Remove(item);
            }

            AtualizarListaItens();
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            var item = ObterItemSelecionado();
            if (item == null)
            {
                MessageBox.Show(this, "Selecione um item da lista para remover.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(this,
                $"Remover \"{item.NomeProduto}\" do pedido?",
                "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                _mesa.Pedido.Itens.Remove(item);
                AtualizarListaItens();
            }
        }

        // ---------------------------------------------------------------
        // Desconto
        // ---------------------------------------------------------------

        private void AtualizarTextoDesconto()
        {
            txtDesconto.Text = _mesa.Pedido.Desconto.ToString("N2", CultureInfo.CurrentCulture);
        }

        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDesconto.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal desconto)
                && !decimal.TryParse(txtDesconto.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out desconto))
            {
                MessageBox.Show(this, "Informe um valor de desconto válido.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (desconto < 0)
            {
                MessageBox.Show(this, "O desconto não pode ser negativo.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _mesa.Pedido.Desconto = desconto;
            AtualizarTextoDesconto();
            AtualizarTotais();
        }

        // ---------------------------------------------------------------
        // Ações principais
        // ---------------------------------------------------------------

        private void btnEnviarCozinha_Click(object sender, EventArgs e)
        {
            if (_mesa.Pedido.Itens.Count == 0)
            {
                MessageBox.Show(this, "Adicione ao menos um item antes de enviar para a cozinha.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _mesa.Pedido.EnviadoParaCozinha = true;
            MessageBox.Show(this, "Pedido enviado para a cozinha!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFecharConta_Click(object sender, EventArgs e)
        {
            if (_mesa.Pedido.Itens.Count == 0)
            {
                MessageBox.Show(this, "Não há itens lançados nesta mesa.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _mesa.Status = StatusMesa.Fechando;
            AtualizarCabecalho();

            var confirmar = MessageBox.Show(this,
                $"Confirma o fechamento da conta no valor total de {_mesa.Pedido.Total:C2}?",
                "Fechar conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                MesaRepositorio.FecharConta(_mesa);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                _mesa.Status = StatusMesa.Ocupada;
                AtualizarCabecalho();
            }
        }

        private void btnTransferirMesa_Click(object sender, EventArgs e)
        {
            var mesasDisponiveis = MesaRepositorio.Mesas
                .Where(m => m.Numero != _mesa.Numero && m.Status == StatusMesa.Livre)
                .OrderBy(m => m.Numero)
                .ToList();

            if (mesasDisponiveis.Count == 0)
            {
                MessageBox.Show(this, "Não há mesas livres para transferência.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mesaDestino = SolicitarEscolhaMesa(mesasDisponiveis);
            if (mesaDestino == null) return;

            mesaDestino.Pedido = _mesa.Pedido;
            mesaDestino.Status = StatusMesa.Ocupada;

            _mesa.Pedido = new PedidoMesa();
            _mesa.Status = StatusMesa.Livre;

            MessageBox.Show(this,
                $"Pedido transferido da Mesa {_mesa.Numero:00} para a Mesa {mesaDestino.Numero:00}.",
                "Transferência concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDividirConta_Click(object sender, EventArgs e)
        {
            if (_mesa.Pedido.Itens.Count == 0)
            {
                MessageBox.Show(this, "Não há itens lançados nesta mesa.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? pessoas = SolicitarQuantidadePessoas();
            if (pessoas == null || pessoas <= 0) return;

            decimal valorPorPessoa = _mesa.Pedido.Total / pessoas.Value;

            MessageBox.Show(this,
                $"Total: {_mesa.Pedido.Total:C2}\r\n" +
                $"Dividido por {pessoas.Value} pessoa(s): {valorPorPessoa:C2} cada.",
                "Divisão de conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImprimirComanda_Click(object sender, EventArgs e)
        {
            if (_mesa.Pedido.Itens.Count == 0)
            {
                MessageBox.Show(this, "Não há itens lançados nesta mesa.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var documento = new PrintDocument();
                documento.PrintPage += (s, args) => ImprimirComanda(args);
                documento.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    "Não foi possível imprimir a comanda. Verifique se há uma impressora " +
                    "instalada e configurada.\r\n\r\nDetalhes: " + ex.Message,
                    "Erro ao imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirComanda(PrintPageEventArgs args)
        {
            var g = args.Graphics;
            var fonteTitulo = new Font("Arial", 14, FontStyle.Bold);
            var fonteNormal = new Font("Arial", 10);
            var fonteNegrito = new Font("Arial", 10, FontStyle.Bold);

            float x = args.MarginBounds.Left;
            float y = args.MarginBounds.Top;

            g.DrawString("Comanda - Mesa " + _mesa.Numero.ToString("00"), fonteTitulo, Brushes.Black, x, y);
            y += 30;
            g.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fonteNormal, Brushes.Black, x, y);
            y += 30;

            foreach (var item in _mesa.Pedido.Itens)
            {
                string linha = $"{item.Quantidade}x {item.NomeProduto}";
                g.DrawString(linha, fonteNormal, Brushes.Black, x, y);
                g.DrawString(item.Subtotal.ToString("C2"), fonteNormal, Brushes.Black, args.MarginBounds.Right - 80, y);
                y += 22;
            }

            y += 10;
            g.DrawString("Subtotal: " + _mesa.Pedido.Subtotal.ToString("C2"), fonteNormal, Brushes.Black, x, y);
            y += 22;
            g.DrawString("Desconto: " + _mesa.Pedido.Desconto.ToString("C2"), fonteNormal, Brushes.Black, x, y);
            y += 22;
            g.DrawString("Total: " + _mesa.Pedido.Total.ToString("C2"), fonteNegrito, Brushes.Black, x, y);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ---------------------------------------------------------------
        // Pequenos diálogos auxiliares (sem precisar de mais nenhum Form)
        // ---------------------------------------------------------------

        private Mesa SolicitarEscolhaMesa(System.Collections.Generic.List<Mesa> mesasDisponiveis)
        {
            using (var dlg = new Form())
            {
                dlg.Text = "Transferir para qual mesa?";
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.MaximizeBox = false;
                dlg.MinimizeBox = false;
                dlg.ClientSize = new Size(280, 130);
                dlg.BackColor = AppColors.Background;

                var lbl = new Label
                {
                    Text = "Mesa de destino:",
                    Font = new Font("Poppins", 9.5F, FontStyle.Bold),
                    ForeColor = AppColors.TextDark,
                    AutoSize = true,
                    Location = new Point(20, 16)
                };

                var combo = new ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Location = new Point(20, 44),
                    Width = 240,
                    Font = new Font("Poppins", 9.5F)
                };
                foreach (var mesa in mesasDisponiveis)
                {
                    combo.Items.Add("Mesa " + mesa.Numero.ToString("00"));
                }
                combo.SelectedIndex = 0;

                var btnOk = new RoundedButton
                {
                    Text = "Transferir",
                    BackColor = AppColors.Primary,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    CornerRadius = 10,
                    Location = new Point(20, 84),
                    Size = new Size(110, 34),
                    DialogResult = DialogResult.OK
                };
                btnOk.FlatAppearance.BorderSize = 0;

                var btnCancelar = new RoundedButton
                {
                    Text = "Cancelar",
                    BackColor = AppColors.Background,
                    ForeColor = AppColors.TextDark,
                    FlatStyle = FlatStyle.Flat,
                    CornerRadius = 10,
                    Location = new Point(150, 84),
                    Size = new Size(110, 34),
                    DialogResult = DialogResult.Cancel
                };
                btnCancelar.FlatAppearance.BorderSize = 1;

                dlg.Controls.Add(lbl);
                dlg.Controls.Add(combo);
                dlg.Controls.Add(btnOk);
                dlg.Controls.Add(btnCancelar);
                dlg.AcceptButton = btnOk;
                dlg.CancelButton = btnCancelar;

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    return mesasDisponiveis[combo.SelectedIndex];
                }
                return null;
            }
        }

        private int? SolicitarQuantidadePessoas()
        {
            using (var dlg = new Form())
            {
                dlg.Text = "Dividir conta";
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.MaximizeBox = false;
                dlg.MinimizeBox = false;
                dlg.ClientSize = new Size(280, 130);
                dlg.BackColor = AppColors.Background;

                var lbl = new Label
                {
                    Text = "Dividir entre quantas pessoas?",
                    Font = new Font("Poppins", 9.5F, FontStyle.Bold),
                    ForeColor = AppColors.TextDark,
                    AutoSize = true,
                    Location = new Point(20, 16)
                };

                var numPessoas = new NumericUpDown
                {
                    Minimum = 1,
                    Maximum = 50,
                    Value = 2,
                    Location = new Point(20, 44),
                    Width = 240,
                    Font = new Font("Poppins", 9.5F),
                    TextAlign = HorizontalAlignment.Center
                };

                var btnOk = new RoundedButton
                {
                    Text = "Calcular",
                    BackColor = AppColors.Primary,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    CornerRadius = 10,
                    Location = new Point(20, 84),
                    Size = new Size(110, 34),
                    DialogResult = DialogResult.OK
                };
                btnOk.FlatAppearance.BorderSize = 0;

                var btnCancelar = new RoundedButton
                {
                    Text = "Cancelar",
                    BackColor = AppColors.Background,
                    ForeColor = AppColors.TextDark,
                    FlatStyle = FlatStyle.Flat,
                    CornerRadius = 10,
                    Location = new Point(150, 84),
                    Size = new Size(110, 34),
                    DialogResult = DialogResult.Cancel
                };
                btnCancelar.FlatAppearance.BorderSize = 1;

                dlg.Controls.Add(lbl);
                dlg.Controls.Add(numPessoas);
                dlg.Controls.Add(btnOk);
                dlg.Controls.Add(btnCancelar);
                dlg.AcceptButton = btnOk;
                dlg.CancelButton = btnCancelar;

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    return (int)numPessoas.Value;
                }
                return null;
            }
        }
    }
}