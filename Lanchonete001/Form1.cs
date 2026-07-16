using Lanchonete001.BancoDados;
using Lanchonete001.Bebidas;
using Lanchonete001.Cardapio;
using Lanchonete001.Configuracoes;
using Lanchonete001.Estoque;
using Lanchonete001.Lanches;
using Lanchonete001.Mesas;
using Lanchonete001.Produtos;
using Lanchonete001.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete001
{
    public partial class Form1 : Form
    {
        // Paleta do menu lateral
        private static readonly Color CorMenuNormal = Color.FromArgb(3, 22, 52);
        private static readonly Color CorMenuHover = Color.FromArgb(14, 44, 82);
        private System.Windows.Forms.Timer timerDashboard;


        // Paleta "app de lanchonete" para os cards do dashboard.
        // Pedidos deixou de usar o mesmo azul-marinho do menu lateral
        // (ficava sem contraste) e passou a usar um laranja, cor clássica
        // de comida rápida, reforçando a identidade visual do app.
        private static readonly Color CorAccentVendas = Color.FromArgb(46, 139, 87);   // verde (dinheiro)
        private static readonly Color CorAccentPedidos = Color.FromArgb(230, 126, 34);  // laranja (lanchonete)
        private static readonly Color CorAccentMesas = Color.FromArgb(205, 179, 128); // dourado/madeira
        private static readonly Color CorAccentEstoque = Color.FromArgb(198, 40, 40);   // vermelho (alerta)

        private Panel itemMenuAtivo;

        /// <summary>Usuário autenticado que está usando o sistema (vindo do FrmLogin).</summary>
        private readonly Usuario usuarioLogado;

        /// <summary>
        /// Menus (por chave interna) liberados para cada cargo.
        /// "Dono" e "Gerente" têm acesso igual ao "Admin", exceto que não
        /// podem cadastrar outro usuário com cargo Admin (isso é tratado
        /// em FrmNovoUsuario/UcUsuarios, não aqui no menu).
        /// </summary>
        private static readonly Dictionary<string, string[]> PermissoesPorCargo =
            new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
            {
                ["Admin"] = new[] { "Dashboard", "Lanches", "Bebidas", "Estoque", "Pedidos", "Mesas", "Delivery", "Clientes", "Financeiro", "Relatorios", "Configuracoes", "Usuarios" },
                ["Dono"] = new[] { "Dashboard", "Lanches", "Bebidas", "Estoque", "Pedidos", "Mesas", "Delivery", "Clientes", "Financeiro", "Relatorios", "Configuracoes", "Usuarios" },
                ["Gerente"] = new[] { "Dashboard", "Lanches", "Bebidas", "Estoque", "Pedidos", "Mesas", "Delivery", "Clientes", "Financeiro", "Relatorios", "Configuracoes", "Usuarios" },
                ["Financeiro"] = new[] { "Dashboard", "Estoque", "Pedidos", "Relatorios" },
                ["Garçom"] = new[] { "Mesas", "Pedidos", "Lanches", "Bebidas" },
                ["Cozinha"] = new[] { "Lanches", "Bebidas", "Pedidos", "Mesas", "Delivery" },
            };

        public Form1() : this(null)
        {
        }

        public Form1(Usuario usuarioLogado)
        {
            InitializeComponent();

            this.usuarioLogado = usuarioLogado;

            // Obs.: o clique do btnSair (painel, ícone e label) já é vinculado
            // diretamente no Designer (btnSair, picMenuSair, lblMenuSair),
            // então não é necessário religar aqui.

            CarregarDadosUsuario();
            AtualizarDataHora();
            AplicarEstiloModerno();
            AplicarPermissoesPorCargo();
        }

        /// <summary>
        /// Preenche os labels do cabeçalho/menu com os dados reais do usuário
        /// logado (nome, cargo) e o status atual da conexão com o banco.
        /// Os cards do dashboard (vendas, pedidos, mesas, estoque) continuam
        /// com dados de exemplo por enquanto.
        /// </summary>
        private void CarregarDadosUsuario()
        {
            string nomeExibido = usuarioLogado?.Nome ?? "Desconhecido";
            string cargoExibido = usuarioLogado?.CargoNome ?? "-";

            lblCargo.Text = "Cargo: " + cargoExibido;
            lblUsuario.Text = "Usuário: " + nomeExibido;
            lblUsuarioConectado.Text = "Usuário: " + nomeExibido;

            AtualizarCardsDashboard();
            AtualizarStatusBanco();
        }

        private void AtualizarCardsDashboard()
        {
            try
            {
                var resumo = DashboardRepositorio.ObterResumo();

                lblValorCardVendas.Text = resumo.VendasHoje.ToString("C2", new CultureInfo("pt-BR"));
                lblValorCardPedidos.Text = resumo.PedidosHoje.ToString();
                lblValorCardMesas.Text = $"{resumo.MesasOcupadas}/{resumo.TotalMesas}";
                lblValorCardEstoque.Text = $"{resumo.ItensEstoqueBaixo} Itens";

                lblDescricaoCardVendas.Text = "Hoje!";
                lblDescricaoCardMesas.Text = $"{resumo.PercentualOcupacao}% Ocupação";
                lblDescricaoCardEstoque.Text = resumo.ItensEstoqueBaixo > 0 ? "Baixo Estoque" : "Estoque OK";
                lblDescricaoCardPedidos.Text = "Total do dia";
            }
            catch (Exception ex)
            {
                lblValorCardVendas.Text = "--";
                lblValorCardPedidos.Text = "--";
                lblValorCardMesas.Text = "--/--";
                lblValorCardEstoque.Text = "--";

                lblDescricaoCardVendas.Text = "Sem conexão";
                lblDescricaoCardMesas.Text = "Sem conexão";
                lblDescricaoCardEstoque.Text = "Sem conexão";
                lblDescricaoCardPedidos.Text = "Sem conexão";

                System.Diagnostics.Debug.WriteLine("Erro ao carregar dashboard: " + ex.Message);
            }
        }

        /// <summary>Testa a conexão com o banco agora e reflete o resultado em lblStatusBanco.</summary>
        private void AtualizarStatusBanco()
        {
            bool conectado = ConexaoBanco.TestarConexao(out string mensagemErro);

            lblStatusBanco.Text = conectado
                ? "Banco de Dados: Conectado"
                : "Banco de Dados: Desconectado";

            lblStatusBanco.ForeColor = conectado
                ? Color.FromArgb(46, 139, 87)
                : Color.FromArgb(196, 69, 54);
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
            AtualizarCardsDashboard(); // <-- adicionado: recarrega os números do banco

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
            ConfigurarAutoAtualizacaoDashboard();

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

        private void ConfigurarAutoAtualizacaoDashboard()
        {
            timerDashboard = new System.Windows.Forms.Timer { Interval = 20000 }; // 20s
            timerDashboard.Tick += (s, e) =>
            {
                if (itemMenuAtivo == btnDashboard)
                    AtualizarCardsDashboard();
            };
            timerDashboard.Start();
        }

        /// <summary>
        /// Ajusta o menu lateral conforme o cargo do usuário logado, de
        /// acordo com o dicionário PermissoesPorCargo. Itens não permitidos
        /// NÃO são escondidos: continuam visíveis no menu, porém ficam
        /// bloqueados (sem clique) e com uma aparência esmaecida, deixando
        /// claro que aquele recurso existe mas não está disponível para o
        /// cargo atual. Se o cargo não for encontrado (nulo, vazio ou não
        /// cadastrado), libera apenas o Dashboard por segurança.
        /// </summary>
        private void AplicarPermissoesPorCargo()
        {
            string cargo = usuarioLogado?.CargoNome;

            // Relaciona cada painel de menu (btnX) à sua chave de permissão
            var mapaMenu = new Dictionary<string, Panel>(StringComparer.OrdinalIgnoreCase)
            {
                ["Dashboard"] = btnDashboard,
                ["Lanches"] = btnLanches,
                ["Bebidas"] = btnBebidas,
                ["Estoque"] = btnEstoque,
                ["Pedidos"] = btnPedidos,
                ["Mesas"] = btnMesas,
                ["Delivery"] = btnDelivery,
                ["Clientes"] = btnClientes,
                ["Financeiro"] = btnFinanceiro,
                ["Relatorios"] = btnRelatorios,
                ["Configuracoes"] = btnConfiguracoes,
                ["Usuarios"] = btnUsuarios,
            };

            string[] permitidos;

            if (string.IsNullOrWhiteSpace(cargo) || !PermissoesPorCargo.TryGetValue(cargo, out permitidos))
            {
                // Cargo desconhecido/nulo: por segurança, libera só o Dashboard
                permitidos = new[] { "Dashboard" };
            }

            foreach (var par in mapaMenu)
            {
                bool liberado = permitidos.Contains(par.Key, StringComparer.OrdinalIgnoreCase);
                AplicarEstadoItemMenu(par.Value, liberado);
            }

            // btnSair fica sempre liberado, independente do cargo
        }

        /// <summary>
        /// Aplica o estado visual/funcional de um item do menu lateral:
        /// - Liberado: aparência normal, clicável, cursor de "mão".
        /// - Bloqueado: continua visível (não desaparece do menu), mas com
        ///   cor esmaecida, texto acinzentado, cursor de "bloqueado" e
        ///   Enabled = false, o que já impede clique nele e em seus filhos
        ///   (ícone/label) automaticamente.
        /// </summary>
        private void AplicarEstadoItemMenu(Panel item, bool liberado)
        {
            item.Enabled = liberado;
            item.Cursor = liberado ? Cursors.Hand : Cursors.No;
            item.BackColor = liberado ? CorMenuNormal : TomBloqueado(CorMenuNormal);

            EsmaecerFilhosRecursivo(item, liberado);
        }

        /// <summary>
        /// Percorre recursivamente os filhos de um item de menu (ícone e
        /// label) ajustando a cor do texto para um tom acinzentado quando o
        /// item está bloqueado, mantendo tudo visível na tela.
        /// </summary>
        private static void EsmaecerFilhosRecursivo(Control raiz, bool liberado)
        {
            foreach (Control filho in raiz.Controls)
            {
                if (filho is Label lbl)
                {
                    lbl.ForeColor = liberado ? Color.White : Color.FromArgb(120, 128, 140);
                }

                EsmaecerFilhosRecursivo(filho, liberado);
            }
        }

        /// <summary>
        /// Gera um tom "apagado"/acinzentado a partir da cor normal do menu,
        /// usado no fundo dos itens bloqueados para indicar visualmente que
        /// aquele recurso não está disponível para o cargo do usuário.
        /// </summary>
        private static Color TomBloqueado(Color cor)
        {
            int r = (cor.R + 110) / 2;
            int g = (cor.G + 110) / 2;
            int b = (cor.B + 110) / 2;
            return Color.FromArgb(r, g, b);
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

            // Botão de atualizar manual, ancorado à direita do cabeçalho
            var lblAtualizar = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins SemiBold", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(3, 22, 52),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Text = "⟳  Atualizar"
            };
            lblAtualizar.Location = new Point(pnlAreaConteudo.ClientSize.Width - lblAtualizar.PreferredWidth - 24, 8);
            lblAtualizar.Click += (s, e) => AtualizarCardsDashboard();

            pnlAreaConteudo.Controls.Add(lblSubtitulo);
            pnlAreaConteudo.Controls.Add(lblTitulo);
            pnlAreaConteudo.Controls.Add(lblAtualizar);

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

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            MarcarItemMenuAtivo(btnPedidos);
            CarregarTela(new UcPedidos());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MarcarItemMenuAtivo(btnUsuarios);
            CarregarTela(new UcUsuarios(usuarioLogado));
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            MarcarItemMenuAtivo(btnFinanceiro);
            //CarregarTela(new UcFinanceiro());

        }
    }
}