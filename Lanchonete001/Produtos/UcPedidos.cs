using Lanchonete001.Mesas;
using Lanchonete001.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lanchonete001.Produtos
{
    public partial class UcPedidos : UserControl
    {
        private static readonly Color CorAguardando = Color.FromArgb(230, 126, 34);
        private static readonly Color CorAguardandoClara = Color.FromArgb(253, 235, 220);
        private static readonly Color CorEmPreparo = Color.FromArgb(52, 152, 219);
        private static readonly Color CorEmPreparoClara = Color.FromArgb(214, 234, 248);
        private static readonly Color CorEntregue = Color.FromArgb(142, 68, 173);
        private static readonly Color CorEntregueClara = Color.FromArgb(233, 217, 243);
        private static readonly Color CorFinalizado = AppColors.Success;
        private static readonly Color CorFinalizadoClara = AppColors.SuccessLight;

        public UcPedidos()
        {
            InitializeComponent();
        }

        private void UcPedidos_Load(object sender, EventArgs e)
        {
            MontarColunas();
            tmrAtualizarQuadro.Start();
        }

        private void tmrAtualizarQuadro_Tick(object sender, EventArgs e)
        {
            MontarColunas();
        }

        private void MontarColunas()
        {
            pnlQuadro.SuspendLayout();
            foreach (Control antigo in pnlQuadro.Controls) antigo.Dispose();
            pnlQuadro.Controls.Clear();

            var pedidosEnviados = MesaRepositorio.Mesas
                .Where(m => m.Pedido != null && m.Pedido.EnviadoParaCozinha)
                .OrderBy(m => m.Numero)
                .ToList();

            var grade = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 4, RowCount = 1, BackColor = AppColors.Background };
            for (int i = 0; i < 4; i++) grade.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            grade.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            grade.Controls.Add(CriarColuna("Aguardando Preparo", CorAguardando, CorAguardandoClara,
                pedidosEnviados.Where(m => m.Pedido.StatusPreparo == StatusPreparoPedido.AguardandoPreparo)), 0, 0);
            grade.Controls.Add(CriarColuna("Em Preparo", CorEmPreparo, CorEmPreparoClara,
                pedidosEnviados.Where(m => m.Pedido.StatusPreparo == StatusPreparoPedido.EmPreparo)), 1, 0);
            grade.Controls.Add(CriarColuna("Entregue", CorEntregue, CorEntregueClara,
                pedidosEnviados.Where(m => m.Pedido.StatusPreparo == StatusPreparoPedido.Entregue)), 2, 0);
            grade.Controls.Add(CriarColuna("Finalizado", CorFinalizado, CorFinalizadoClara,
                pedidosEnviados.Where(m => m.Pedido.StatusPreparo == StatusPreparoPedido.Finalizado)), 3, 0);

            pnlQuadro.Controls.Add(grade);
            pnlQuadro.ResumeLayout();
        }

        private Panel CriarColuna(string titulo, Color corTitulo, Color corHeader, IEnumerable<Mesa> mesas)
        {
            var coluna = new Panel { Dock = DockStyle.Fill, Margin = new Padding(8), BackColor = Color.White };

            var header = new RoundedPanel { Dock = DockStyle.Top, Height = 44, BackColor = corHeader, CornerRadius = 10, BorderThickness = 0 };
            header.Controls.Add(new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 10.5F, FontStyle.Bold),
                ForeColor = corTitulo,
                BackColor = Color.Transparent,
                Location = new Point(12, 10),
                Text = titulo
            });

            var lista = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(0, 8, 0, 0)
            };

            var mesasLista = mesas.ToList();
            if (mesasLista.Count == 0)
            {
                lista.Controls.Add(new Label
                {
                    AutoSize = true,
                    Font = new Font("Poppins", 9F),
                    ForeColor = AppColors.TextMuted,
                    Text = "Nenhum pedido"
                });
            }
            else
            {
                foreach (var mesa in mesasLista)
                    lista.Controls.Add(CriarCardPedido(mesa, corTitulo, corHeader));
            }

            coluna.Controls.Add(lista);
            coluna.Controls.Add(header);
            return coluna;
        }

        private RoundedPanel CriarCardPedido(Mesa mesa, Color corDestaque, Color corFundo)
        {
            var pedido = mesa.Pedido;

            var card = new RoundedPanel
            {
                Width = 240,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Margin = new Padding(8),
                Padding = new Padding(12, 10, 12, 10),
                BackColor = corFundo,
                BorderColor = corDestaque,
                BorderThickness = 1,
                CornerRadius = 12,
                Tag = mesa
            };

            var lblMesa = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 11F, FontStyle.Bold),
                ForeColor = AppColors.TextDark,
                BackColor = Color.Transparent,
                Location = new Point(0, 0),
                Text = "Mesa " + mesa.Numero.ToString("00")
            };

            var lblItens = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 8.75F),
                ForeColor = AppColors.TextMuted,
                BackColor = Color.Transparent,
                Location = new Point(0, 26),
                MaximumSize = new Size(216, 0),
                Text = string.Join("\n", pedido.Itens.Select(i => $"{i.Quantidade}x {i.NomeProduto}"))
            };

            var lblTotal = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 9F, FontStyle.Bold),
                ForeColor = AppColors.TextDark,
                BackColor = Color.Transparent,
                Location = new Point(0, lblItens.Location.Y + lblItens.PreferredHeight + 6),
                Text = pedido.Total.ToString("C2")
            };

            card.Controls.Add(lblMesa);
            card.Controls.Add(lblItens);
            card.Controls.Add(lblTotal);

            int proximaLinhaY = lblTotal.Location.Y + lblTotal.PreferredHeight + 8;

            if (pedido.StatusPreparo == StatusPreparoPedido.Finalizado)
            {
                // Pedido pronto: só o caixa/mesa pode fechar a conta a partir daqui.
                var lblAviso = new Label
                {
                    AutoSize = true,
                    Font = new Font("Poppins", 8F, FontStyle.Italic),
                    ForeColor = AppColors.TextMuted,
                    BackColor = Color.Transparent,
                    Location = new Point(0, proximaLinhaY),
                    MaximumSize = new Size(216, 0),
                    Text = "Aguardando fechamento na mesa"
                };
                card.Controls.Add(lblAviso);
            }
            else
            {
                var btnAcao = new RoundedButton
                {
                    AutoSize = true,
                    CornerRadius = 8,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = corDestaque,
                    ForeColor = Color.White,
                    Font = new Font("Poppins", 8.5F, FontStyle.Bold),
                    Location = new Point(0, proximaLinhaY),
                    Text = TextoAcao(pedido.StatusPreparo)
                };
                btnAcao.FlatAppearance.BorderSize = 0;
                btnAcao.Click += (s, e) => AvancarPedido(mesa);
                card.Controls.Add(btnAcao);
            }

            return card;
        }

        private static string TextoAcao(StatusPreparoPedido status)
        {
            switch (status)
            {
                case StatusPreparoPedido.AguardandoPreparo: return "Iniciar Preparo";
                case StatusPreparoPedido.EmPreparo: return "Marcar Entregue";
                default: return "Finalizar"; // Entregue -> Finalizado
            }
        }

        private void AvancarPedido(Mesa mesa)
        {
            // A cozinha só avança até Finalizado; fechar a conta é ação exclusiva
            // da tela da mesa (FrmPedidoMesa -> FrmFecharConta).
            MesaRepositorio.AvancarStatusPreparo(mesa.Pedido);
            MontarColunas();
        }
    }
}