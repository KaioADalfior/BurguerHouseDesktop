using Lanchonete001.Mesas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lanchonete001.Produtos
{
    public partial class UcPedidos : UserControl
    {
        // ---------- Paleta de cores fixa (única fonte de cor do controle) ----------
        private static readonly Color PaletaCreme = ColorTranslator.FromHtml("#e8ddcb");
        private static readonly Color PaletaAreia = ColorTranslator.FromHtml("#cdb380");
        private static readonly Color PaletaVerdeAzulado = ColorTranslator.FromHtml("#036564");
        private static readonly Color PaletaAzulPetroleo = ColorTranslator.FromHtml("#033649");
        private static readonly Color PaletaAzulMarinho = ColorTranslator.FromHtml("#031634");

        // "Branco" e "texto claro" da paleta: tons bem claros derivados do creme,
        // em vez de usar Color.White puro (mantém tudo ancorado na mesma paleta).
        private static readonly Color SuperficieClara = ControlPaint.Light(PaletaCreme, 0.65f);
        private static readonly Color TextoClaro = ControlPaint.Light(PaletaCreme, 0.85f);

        // Cor de destaque (accent) de cada coluna do Kanban
        private static readonly Color CorAguardando = PaletaAreia;
        private static readonly Color CorEmPreparo = PaletaVerdeAzulado;
        private static readonly Color CorEntregue = PaletaAzulPetroleo;
        private static readonly Color CorFinalizado = PaletaAzulMarinho;

        public UcPedidos()
        {
            InitializeComponent();

            // Evita o flicker do redesenho do quadro a cada tick do timer.
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
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

            // IMPORTANTE: materializar em lista antes de descartar. Dispose()
            // remove o controle de pnlQuadro.Controls automaticamente, então
            // usar o próprio pnlQuadro.Controls no foreach quebra a enumeração
            // (InvalidOperationException) a cada atualização do timer.
            foreach (Control antigo in pnlQuadro.Controls.Cast<Control>().ToList())
                antigo.Dispose();
            pnlQuadro.Controls.Clear();

            var pedidosEnviados = MesaRepositorio.Mesas
                .Where(m => m.Pedido != null && m.Pedido.EnviadoParaCozinha)
                .OrderBy(m => m.Numero)
                .ToList();

            var grade = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                BackColor = PaletaCreme
            };
            for (int i = 0; i < 4; i++) grade.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            grade.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            grade.Controls.Add(CriarColuna("Aguardando Preparo", CorAguardando,
                pedidosEnviados.Where(m => m.Pedido.StatusPreparo == StatusPreparoPedido.AguardandoPreparo)), 0, 0);
            grade.Controls.Add(CriarColuna("Em Preparo", CorEmPreparo,
                pedidosEnviados.Where(m => m.Pedido.StatusPreparo == StatusPreparoPedido.EmPreparo)), 1, 0);
            grade.Controls.Add(CriarColuna("Entregue", CorEntregue,
                pedidosEnviados.Where(m => m.Pedido.StatusPreparo == StatusPreparoPedido.Entregue)), 2, 0);
            grade.Controls.Add(CriarColuna("Finalizado", CorFinalizado,
                pedidosEnviados.Where(m => m.Pedido.StatusPreparo == StatusPreparoPedido.Finalizado)), 3, 0);

            pnlQuadro.Controls.Add(grade);
            pnlQuadro.ResumeLayout();
        }

        /// <summary>
        /// Monta uma coluna do Kanban: cabeçalho quadrado (linha fixa) +
        /// lista rolável (linha fill), sem cantos arredondados.
        /// </summary>
        private Panel CriarColuna(string titulo, Color corAccent, IEnumerable<Mesa> mesas)
        {
            var coluna = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(6),
                ColumnCount = 1,
                RowCount = 2,
                BackColor = SuperficieClara
            };
            coluna.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
            coluna.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            bool textoEscuro = corAccent == PaletaAreia; // fundo claro precisa de texto escuro

            var header = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = corAccent,
                Margin = new Padding(0, 0, 0, 4)
            };
            header.Controls.Add(new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(12, 0, 0, 0),
                Font = new Font("Poppins", 10.5F, FontStyle.Bold),
                ForeColor = textoEscuro ? PaletaAzulMarinho : TextoClaro,
                BackColor = Color.Transparent,
                Text = titulo
            });

            var lista = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                BackColor = SuperficieClara,
                Padding = new Padding(8)
            };

            var mesasLista = mesas.ToList();
            if (mesasLista.Count == 0)
            {
                lista.Controls.Add(new Label
                {
                    AutoSize = true,
                    Font = new Font("Poppins", 9F, FontStyle.Italic),
                    ForeColor = PaletaAzulPetroleo,
                    BackColor = Color.Transparent,
                    Text = "Nenhum pedido"
                });
            }
            else
            {
                foreach (var mesa in mesasLista)
                    lista.Controls.Add(CriarCardPedido(mesa, corAccent));
            }

            coluna.Controls.Add(header, 0, 0);
            coluna.Controls.Add(lista, 0, 1);

            return coluna;
        }

        /// <summary>
        /// Card quadrado com borda reta desenhada manualmente (sem região
        /// arredondada), evitando os bugs visuais do componente antigo.
        /// </summary>
        private Panel CriarCardPedido(Mesa mesa, Color corAccent)
        {
            var pedido = mesa.Pedido;

            var card = new Panel
            {
                Width = 224,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Margin = new Padding(0, 0, 0, 10),
                Padding = new Padding(12, 10, 12, 10),
                BackColor = TextoClaro,
                Tag = mesa
            };
            card.Paint += (s, e) =>
            {
                using (var caneta = new Pen(corAccent, 2f))
                {
                    var rect = new Rectangle(0, 0, card.Width - 1, card.Height - 1);
                    e.Graphics.DrawRectangle(caneta, rect);
                }
            };

            var lblMesa = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 11F, FontStyle.Bold),
                ForeColor = PaletaAzulMarinho,
                BackColor = Color.Transparent,
                Location = new Point(0, 0),
                Text = "Mesa " + mesa.Numero.ToString("00")
            };

            var lblItens = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 8.75F),
                ForeColor = PaletaAzulPetroleo,
                BackColor = Color.Transparent,
                Location = new Point(0, 26),
                MaximumSize = new Size(196, 0),
                Text = string.Join("\n", pedido.Itens.Select(i => $"{i.Quantidade}x {i.NomeProduto}"))
            };

            var lblTotal = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 9F, FontStyle.Bold),
                ForeColor = PaletaAzulMarinho,
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
                    ForeColor = PaletaAzulPetroleo,
                    BackColor = Color.Transparent,
                    Location = new Point(0, proximaLinhaY),
                    MaximumSize = new Size(196, 0),
                    Text = "Aguardando fechamento na mesa"
                };
                card.Controls.Add(lblAviso);
            }
            else
            {
                var btnAcao = new Button
                {
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = corAccent,
                    ForeColor = TextoClaro,
                    Font = new Font("Poppins", 8.5F, FontStyle.Bold),
                    Padding = new Padding(10, 4, 10, 4),
                    Location = new Point(0, proximaLinhaY),
                    Text = TextoAcao(pedido.StatusPreparo),
                    UseVisualStyleBackColor = false
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