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

namespace Lanchonete001
{
    public partial class Form1 : Form
    {
        private static readonly Color CorMenuNormal = Color.FromArgb(3, 22, 52);
        private static readonly Color CorMenuHover = Color.FromArgb(14, 44, 82);

        private Panel itemMenuAtivo;

        public Form1()
        {
            InitializeComponent();


            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.pictureBox12.Click += new System.EventHandler(this.btnSair_Click);
            this.label13.Click += new System.EventHandler(this.btnSair_Click);


            CarregarDadosTeste();
            AtualizarDataHora();
            AplicarEstiloModerno();
        }

        private void CarregarDadosTeste()
        {
            lblCargo.Text = "Cargo: Gerente";
            lblUsuario.Text = "Usuário: Kaio Andrião Dalfior";
            lblUsuarioConectado.Text = "Usuário: Kaio Andrião Dalfior";

            lblValorCardTotalVendas.Text = "R$ 1.000,00";
            lblValorCardPedidos.Text = "38";
            lblValorCardMesas.Text = "12/32";
            lblValorEstoque.Text = "5 Itens";


            lblDescricaoCardTotalVendas.Text = "Hoje!";
            lblDescricaoMesas.Text = "50% Ocupação";
            lblDescricaoEstoque.Text = "Baixo Estoque";
            lblTituloCardPedidos.Text = "+12% vs Ontem";


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
            ArredondarControle(pnlBusca, 15);

            ArredondarControle(panel13, 14);
            ArredondarControle(panel16, 14);
            ArredondarControle(lvlValorMesas, 14);
            ArredondarControle(panel18, 14);

            ArredondarCirculo(pnlIconVendas);
            ArredondarCirculo(pnlIconPedidos);
            ArredondarCirculo(pnlIconMesas);
            ArredondarCirculo(pnlIconEstoque);

            var itensMenu = new[]
            {
                panel2, panel3, panel4, btnEstoque, panel6, panel7,
                panel8, panel9, panel10, panel11, btnConfiguracoes, btnSair
            };

            foreach (var item in itensMenu)
            {
                ConfigurarHoverMenu(item);
            }

            MarcarItemMenuAtivo(panel2);
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

           
            pnlIndicadorAtivo.Visible = (item == panel2);
        }

        private void btnConfiguracoes02_Click(object sender, EventArgs e)
        {
            CarregarTela(new UcConfiguracoes());
        }
    }
}
