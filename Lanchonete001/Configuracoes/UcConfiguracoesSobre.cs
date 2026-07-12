using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete001.Configuracoes
{
    public partial class UcConfiguracoesSobre : UserControl
    {

        public UcConfiguracoesSobre()
        {
            InitializeComponent();
            CarregarInformacoes();

        }

        private void CarregarInformacoes()
        {
            lblNomeSistema.Text = "BURGUER HOUSE";

            // Pega a versão direto do assembly (Project → Properties → versão)
            var versao = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersaoSistema.Text = $"Versão {versao.Major}.{versao.Minor}.{versao.Build}";

            lblDescricaoSistema.Text = "Sistema de gestão para lanchonetes — controle de lanches, estoque e pedidos.";
            lblDesenvolvedor.Text = "Desenvolvido por Kaio Andrião Dalfior";
            lblCopyright.Text = $"© {DateTime.Now.Year} — Todos os direitos reservados";

            // Se você tiver um ícone/logo em Properties.Resources, descomente e ajuste o nome:
            // pictureBoxLogoSobre.BackgroundImage = global::Lanchonete001.Properties.Resources.logo_lanchonete;
        }
    }
}
