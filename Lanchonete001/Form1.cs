using Lanchonete001.Cardapio;
using Lanchonete001.Lanches;
using Lanchonete001.Bebidas;
using Lanchonete001.Configuracoes;
using Lanchonete001.Estoque;
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
using Lanchonete001.Mesas;

namespace Lanchonete001
{
    public partial class Form1 : Form
    {
        // Paleta do menu lateral
        private static readonly Color CorMenuNormal = Color.FromArgb(3, 22, 52);
        private static readonly Color CorMenuHover = Color.FromArgb(14, 44, 82);

        // Paleta "app de lanchonete" para os cards do dashboard.
        // Pedidos deixou de usar o mesmo azul-marinho do menu lateral
        // (ficava sem contraste) e passou a usar um laranja, cor clássica
        // de comida rápida, reforçando a identidade visual do app.
        private static readonly Color CorAccentVendas = Color.FromArgb(46, 139, 87);   // verde (dinheiro)
        private static readonly Color CorAccentPedidos = Color.FromArgb(230, 126, 34);  // laranja (lanchonete)
        private static readonly Color CorAccentMesas = Color.FromArgb(205, 179, 128); // dourado/madeira
        private static readonly Color CorAccentEstoque = Color.FromArgb(198, 40, 40);   // vermelho (alerta)

        private Panel itemMenuAtivo;

        public Form1()
        {
            InitializeComponent();

            // Obs.: o clique do btnSair (painel, ícone e label) já é vinculado
            // diretamente no Designer (btnSair, picMenuSair, lblMenuSair),
            // então não é necessário religar aqui.

            CarregarDadosTeste();
            AtualizarDataHora();
            AplicarEstiloModerno();
        }

        private void CarregarDadosTeste()
        {
            lblCargo.Text = "Cargo: Gerente";
            lblUsuario.Text = "Usuário: Kaio Andrião Dalfior";
            lblUsuarioConectado.Text = "Usuário: Kaio Andrião Dalfior";

            lblValorCardVendas.Text = "R$ 1.000,00";
            lblValorCardPedidos.Text = "38";
            lblValorCardMesas.Text = "12/32";
            lblValorCardEstoque.Text = "5 Itens";

            lblDescricaoCardVendas.Text = "Hoje!";
            lblDescricaoCardMesas.Text = "50% Ocupação";
            lblDescricaoCardEstoque.Text = "Baixo Estoque";
            lblDescricaoCardPedidos.Text = "+12% vs Ontem";

            lblStatusBanco.Text = "Banco de Dados: Conectado";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarDataHora();
        }

        private void AtualizarDataHora()
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void CarregarTela(UserControl tela)
        {
            pnlConteudo.Controls.Clear();
            tela.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(tela);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MarcarItemMenuAtivo(btnDashboard);
            CarregarDashboard();
        }

        /// <summary>
        /// Restaura o conteúdo original do dashboard (rodapé + cards) dentro
        /// de pnlConteudo, já que CarregarTela() limpa todos os controles
        /// ao abrir uma outra tela (Estoque, Configurações etc.).
        /// </summary>
        private void CarregarDashboard()
        {
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(pnlRodape);
            pnlConteudo.Controls.Add(pnlAreaConteudo);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            MarcarItemMenuAtivo(btnEstoque);
            CarregarTela(new UcEstoque());
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            MarcarItemMenuAtivo(btnConfiguracoes);
            CarregarTela(new UcConfiguracoes());
        }

        private void AplicarEstiloModerno()
        {
            // Barra de busca em formato de pílula
            ArredondarControle(pnlBusca, 15);

            // Cabeçalho de boas-vindas acima dos cards, dando contexto
            // imediato de "onde estou" dentro do app
            AdicionarCabecalhoBoasVindas();

            // Cards do dashboard com visual moderno: cantos arredondados,
            // ícones em badges coloridos, indicador em formato de "chip"
            // e leve destaque ao passar o mouse
            ConfigurarCardModerno(pnlCardVendas, pnlIconVendas, pnlAccentVendas, lblDescricaoCardVendas, CorAccentVendas);
            ConfigurarCardModerno(pnlCardPedidos, pnlIconPedidos, pnlAccentPedidos, lblDescricaoCardPedidos, CorAccentPedidos);
            ConfigurarCardModerno(pnlCardMesas, pnlIconMesas, pnlAccentMesas, lblDescricaoCardMesas, CorAccentMesas);
            ConfigurarCardModerno(pnlCardEstoque, pnlIconEstoque, pnlAccentEstoque, lblDescricaoCardEstoque, CorAccentEstoque);

            // Navegação intuitiva: o card de Estoque já leva direto para a
            // tela de Estoque com um clique (as demais telas ainda não têm
            // UserControl implementado, por isso só este card é clicável)
            AtribuirCliqueRecursivo(pnlCardEstoque, btnEstoque_Click);

            // Hover nos itens do menu lateral
            var itensMenu = new[]
            {
                btnDashboard, btnLanches, btnBebidas, btnEstoque, btnPedidos, btnMesas,
                btnDelivery, btnClientes, btnFinanceiro, btnRelatorios, btnConfiguracoes, btnSair
            };

            foreach (var item in itensMenu)
            {
                ConfigurarHoverMenu(item);
            }

            // Estado inicial: "Dashboard" começa selecionado, pois é a tela carregada por padrão
            MarcarItemMenuAtivo(btnDashboard);
        }

        /// <summary>
        /// Adiciona um título e um subtítulo acima dos cards do dashboard,
        /// dando uma sensação de "página inicial" mais acolhedora, e
        /// reposiciona a lista de cards para abrir espaço para eles.
        /// </summary>
        private void AdicionarCabecalhoBoasVindas()
        {
            var lblTitulo = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins ExtraBold", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(3, 22, 52),
                Location = new Point(6, 0),
                Text = "Dashboard"
            };

            var lblSubtitulo = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 10F),
                ForeColor = Color.FromArgb(120, 120, 120),
                Location = new Point(6, 32),
                Text = "Confira o resumo do seu negócio hoje"
            };

            pnlAreaConteudo.Controls.Add(lblSubtitulo);
            pnlAreaConteudo.Controls.Add(lblTitulo);

            // Empurra os cards para baixo, abrindo espaço para o cabeçalho
            flowLayoutPanel1.Location = new Point(6, 74);
        }

        /// <summary>
        /// Aplica o visual moderno de um card do dashboard: cantos
        /// arredondados no card e no badge do ícone, cor de destaque
        /// (accent) igual à identidade do indicador, um "chip" colorido
        /// para a descrição e um efeito sutil de hover.
        /// </summary>
        private void ConfigurarCardModerno(Panel card, Panel iconBadge, Panel accent, Label chip, Color corAccent)
        {
            // Cantos arredondados no card e no badge do ícone
            ArredondarControle(card, 16);
            ArredondarControle(iconBadge, 14);

            // Cores do card seguindo a paleta de cada indicador
            accent.BackColor = corAccent;
            iconBadge.BackColor = corAccent;

            // "Chip" colorido para a descrição (ex.: "Hoje!", "+12% vs Ontem")
            chip.BackColor = TomPastel(corAccent);
            chip.ForeColor = corAccent;
            chip.Padding = new Padding(8, 3, 8, 3);
            ArredondarControle(chip, 9);

            // Efeito hover: leve realce de cor ao passar o mouse sobre o card
            Color corOriginal = card.BackColor;
            Color corHover = TomPastel(corAccent);

            EventHandler aoEntrar = (s, e) => card.BackColor = corHover;
            EventHandler aoSair = (s, e) => card.BackColor = corOriginal;

            card.MouseEnter += aoEntrar;
            card.MouseLeave += aoSair;
        }

        /// <summary>
        /// Gera um tom pastel (mistura com branco) de uma cor de destaque,
        /// usado nos chips e no hover dos cards.
        /// </summary>
        private static Color TomPastel(Color cor)
        {
            int r = (cor.R + 255 * 4) / 5;
            int g = (cor.G + 255 * 4) / 5;
            int b = (cor.B + 255 * 4) / 5;
            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Vincula o mesmo evento de clique a um controle e a todos os
        /// seus filhos (recursivamente), além de trocar o cursor para
        /// "mãozinha", indicando visualmente que o elemento é clicável.
        /// </summary>
        private static void AtribuirCliqueRecursivo(Control raiz, EventHandler manipulador)
        {
            raiz.Cursor = Cursors.Hand;
            raiz.Click += manipulador;

            foreach (Control filho in raiz.Controls)
            {
                AtribuirCliqueRecursivo(filho, manipulador);
            }
        }

        private static void ArredondarControle(Control controle, int raio)
        {
            var caminho = new GraphicsPath();
            int diametro = raio * 2;
            var limites = new Rectangle(0, 0, controle.Width, controle.Height);

            caminho.AddArc(limites.X, limites.Y, diametro, diametro, 180, 90);
            caminho.AddArc(limites.Right - diametro, limites.Y, diametro, diametro, 270, 90);
            caminho.AddArc(limites.Right - diametro, limites.Bottom - diametro, diametro, diametro, 0, 90);
            caminho.AddArc(limites.X, limites.Bottom - diametro, diametro, diametro, 90, 90);
            caminho.CloseFigure();

            controle.Region = new Region(caminho);
        }

        private static void ArredondarCirculo(Control controle)
        {
            var caminho = new GraphicsPath();
            caminho.AddEllipse(0, 0, controle.Width, controle.Height);
            controle.Region = new Region(caminho);
        }

        /// <summary>
        /// Liga o efeito de hover (clareia o fundo) em um item de menu e em
        /// todos os seus controles filhos (ícone e texto), já que o mouse
        /// sobre o filho tecnicamente "sai" do painel pai.
        /// </summary>
        private void ConfigurarHoverMenu(Panel item)
        {
            EventHandler aoEntrar = (s, e) =>
            {
                if (item != itemMenuAtivo)
                {
                    item.BackColor = CorMenuHover;
                }
            };

            EventHandler aoSair = (s, e) =>
            {
                if (item != itemMenuAtivo)
                {
                    item.BackColor = CorMenuNormal;
                }
            };

            item.MouseEnter += aoEntrar;
            item.MouseLeave += aoSair;

            foreach (Control filho in item.Controls)
            {
                filho.MouseEnter += aoEntrar;
                filho.MouseLeave += aoSair;
            }
        }

        private void MarcarItemMenuAtivo(Panel item)
        {
            if (itemMenuAtivo != null)
            {
                itemMenuAtivo.BackColor = CorMenuNormal;
            }

            item.BackColor = CorMenuHover;
            itemMenuAtivo = item;

            pnlIndicadorAtivo.Visible = (item == btnDashboard);
        }

        private void btnConfiguracoes02_Click(object sender, EventArgs e)
        {
            CarregarTela(new UcConfiguracoes());
        }

        private void btnLanches_Click(object sender, EventArgs e)
        {
            MarcarItemMenuAtivo(btnLanches);
            CarregarTela(new UcLanches());
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            MarcarItemMenuAtivo(btnBebidas);
            CarregarTela(new UcBebidas());
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            MarcarItemMenuAtivo(btnMesas);
            CarregarTela(new UcMesas());
        }
    }
}