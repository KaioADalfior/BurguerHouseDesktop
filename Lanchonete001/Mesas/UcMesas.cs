using Lanchonete001.UI;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lanchonete001.Mesas
{
    public partial class UcMesas : UserControl
    {
        // "Fechando" não existe em AppColors (só Success/Danger), então
        // definimos aqui um tom laranja próprio para esse status, seguindo
        // a mesma ideia de accent color usada no Dashboard (Form1).
        private static readonly Color CorFechando = Color.FromArgb(230, 126, 34);
        private static readonly Color CorFechandoClara = Color.FromArgb(253, 235, 220);

        // Texto de placeholder da pesquisa (a caixa não tem suporte nativo
        // a placeholder no WinForms, então simulamos com Enter/Leave).
        private const string TextoPesquisaPlaceholder = "Nº da mesa...";

        private const int EspacamentoCards = 16;
        private const int AlturaCard = 118;
        private const int LarguraMinimaCard = 150;

        public UcMesas()
        {
            InitializeComponent();

            txtPesquisarMesa.Text = TextoPesquisaPlaceholder;
            txtPesquisarMesa.ForeColor = AppColors.TextMuted;

            // Se já existirem mesas cadastradas (ex.: voltando para esta tela),
            // mantém a quantidade atual; senão começa com uma sugestão de 8.
            numQuantidadeMesas.Value = MesaRepositorio.Mesas.Count > 0 ? MesaRepositorio.Mesas.Count : 8;

            AplicarQuantidade();
        }

        private void AplicarQuantidade()
        {
            int quantidade = (int)numQuantidadeMesas.Value;
            MesaRepositorio.DefinirQuantidade(quantidade);
            RenderizarMesas();
        }

        /// <summary>
        /// Calcula quantas colunas cabem na área disponível (sempre 4 ou 5,
        /// conforme pedido) e qual a largura de cada card para que a grade
        /// ocupe toda a largura da tela, sem sobrar uma faixa vazia.
        /// </summary>
        private (int colunas, int larguraCard) CalcularGradeMesas()
        {
            int larguraDisponivel = pnlAreaMesas.ClientSize.Width
                - pnlAreaMesas.Padding.Left - pnlAreaMesas.Padding.Right
                - SystemInformation.VerticalScrollBarWidth;

            if (larguraDisponivel < 1) larguraDisponivel = 1;

            int colunas = 5;
            int largura = CalcularLarguraCard(larguraDisponivel, colunas);

            if (largura < LarguraMinimaCard)
            {
                colunas = 4;
                largura = CalcularLarguraCard(larguraDisponivel, colunas);
            }

            return (colunas, Math.Max(largura, 90));
        }

        private static int CalcularLarguraCard(int larguraDisponivel, int colunas)
        {
            int totalEspacamento = EspacamentoCards * colunas;
            return (larguraDisponivel - totalEspacamento) / colunas;
        }

        private void RenderizarMesas()
        {
            var (_, larguraCard) = CalcularGradeMesas();

            string filtro = ObterTextoPesquisa();

            var mesasFiltradas = MesaRepositorio.Mesas
                .OrderBy(m => m.Numero)
                .Where(m => string.IsNullOrEmpty(filtro)
                    || m.Numero.ToString().Contains(filtro)
                    || m.Numero.ToString("00").Contains(filtro))
                .ToList();

            pnlGradeMesas.SuspendLayout();

            // Libera os controles antigos explicitamente (Clear() sozinho
            // não chama Dispose, e isso acumula memória a cada atualização).
            foreach (Control antigo in pnlGradeMesas.Controls)
            {
                antigo.Dispose();
            }
            pnlGradeMesas.Controls.Clear();

            if (mesasFiltradas.Count == 0)
            {
                pnlGradeMesas.Controls.Add(CriarAvisoSemResultado(filtro));
            }
            else
            {
                foreach (var mesa in mesasFiltradas)
                {
                    pnlGradeMesas.Controls.Add(CriarCardMesa(mesa, larguraCard));
                }
            }

            pnlGradeMesas.ResumeLayout();
        }

        private string ObterTextoPesquisa()
        {
            if (txtPesquisarMesa.Text == TextoPesquisaPlaceholder) return string.Empty;
            return txtPesquisarMesa.Text.Trim();
        }

        private Label CriarAvisoSemResultado(string filtro)
        {
            return new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 10.5F),
                ForeColor = AppColors.TextMuted,
                BackColor = Color.Transparent,
                Margin = new Padding(0, 24, 0, 0),
                Text = string.IsNullOrEmpty(filtro)
                    ? "Nenhuma mesa cadastrada."
                    : $"Nenhuma mesa encontrada para \"{filtro}\"."
            };
        }

        /// <summary>
        /// Monta um card clicável para a mesa, com cor de acordo com o
        /// status (Livre = verde, Ocupada = vermelho, Fechando = laranja).
        /// </summary>
        private RoundedPanel CriarCardMesa(Mesa mesa, int largura)
        {
            Color corTexto = CorTextoStatus(mesa.Status);
            Color corFundo = CorFundoStatus(mesa.Status);

            var card = new RoundedPanel
            {
                Size = new Size(largura, AlturaCard),
                Margin = new Padding(0, 0, EspacamentoCards, EspacamentoCards),
                BackColor = corFundo,
                BorderColor = corTexto,
                BorderThickness = 1,
                CornerRadius = 14,
                Cursor = Cursors.Hand,
                Tag = mesa
            };

            var lblDot = new Label
            {
                AutoSize = true,
                Text = "●",
                Font = new Font("Segoe UI", 9F),
                ForeColor = corTexto,
                BackColor = Color.Transparent,
                Location = new Point(16, 14)
            };

            var lblNumero = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 15F, FontStyle.Bold),
                ForeColor = AppColors.TextDark,
                BackColor = Color.Transparent,
                Text = "Mesa " + mesa.Numero.ToString("00"),
                Location = new Point(16, 38)
            };

            var lblStatus = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 9F),
                ForeColor = corTexto,
                BackColor = Color.Transparent,
                Text = TextoStatus(mesa.Status),
                Location = new Point(16, 70)
            };

            var lblTotal = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 8.5F, FontStyle.Bold),
                ForeColor = AppColors.TextMuted,
                BackColor = Color.Transparent,
                Text = mesa.TemItens ? mesa.Pedido.Total.ToString("C2") : string.Empty,
                Location = new Point(16, 90)
            };

            card.Controls.Add(lblDot);
            card.Controls.Add(lblNumero);
            card.Controls.Add(lblStatus);
            card.Controls.Add(lblTotal);

            EventHandler aoClicar = (s, e) => AbrirMesa(mesa);
            card.Click += aoClicar;
            foreach (Control filho in card.Controls)
            {
                filho.Cursor = Cursors.Hand;
                filho.Click += aoClicar;
            }

            return card;
        }

        private void AbrirMesa(Mesa mesa)
        {
            using (var frm = new FrmPedidoMesa(mesa))
            {
                frm.ShowDialog(this);
            }

            // O status/pedido pode ter mudado (item lançado, conta fechada,
            // transferência etc.), então redesenha os cards.
            RenderizarMesas();
        }

        private static Color CorFundoStatus(StatusMesa status)
        {
            switch (status)
            {
                case StatusMesa.Ocupada: return AppColors.DangerLight;
                case StatusMesa.Fechando: return CorFechandoClara;
                default: return AppColors.SuccessLight;
            }
        }

        private static Color CorTextoStatus(StatusMesa status)
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

        private void btnAplicarQuantidade_Click(object sender, EventArgs e)
        {
            AplicarQuantidade();
        }

        /// <summary>Recalcula colunas/largura dos cards sempre que a área disponível muda de tamanho.</summary>
        private void pnlAreaMesas_Resize(object sender, EventArgs e)
        {
            RenderizarMesas();
        }

        private void UcMesas_Load(object sender, EventArgs e)
        {
            // No construtor o controle ainda pode não ter o tamanho final
            // definido pelo Form pai; ao carregar, recalculamos a grade
            // com a largura real disponível na tela.
            RenderizarMesas();
        }

        private void txtPesquisarMesa_TextChanged(object sender, EventArgs e)
        {
            RenderizarMesas();
        }

        private void txtPesquisarMesa_Enter(object sender, EventArgs e)
        {
            if (txtPesquisarMesa.Text == TextoPesquisaPlaceholder)
            {
                txtPesquisarMesa.Text = string.Empty;
                txtPesquisarMesa.ForeColor = AppColors.TextDark;
            }
        }

        private void txtPesquisarMesa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisarMesa.Text))
            {
                txtPesquisarMesa.Text = TextoPesquisaPlaceholder;
                txtPesquisarMesa.ForeColor = AppColors.TextMuted;
            }
        }
    }
}