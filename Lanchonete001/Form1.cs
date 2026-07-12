using Lanchonete001.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //btnSair
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.pictureBox12.Click += new System.EventHandler(this.btnSair_Click);
            this.label13.Click += new System.EventHandler(this.btnSair_Click);


            CarregarDadosTeste();
            AtualizarDataHora();
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
            CarregarTela(new UcEstoque());
        }
    }
}
