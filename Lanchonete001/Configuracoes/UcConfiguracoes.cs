using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete001.Configuracoes
{
    public partial class UcConfiguracoes : UserControl
    {
        public UcConfiguracoes()
        {
            InitializeComponent();
            CarregarTela(new UcConfiguracoesSobre());

        }

        private void CarregarTela(UserControl tela)
        {
            pnlConfiguracoes.Controls.Clear();
            tela.Dock = DockStyle.Fill;
            pnlConfiguracoes.Controls.Add(tela);
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            CarregarTela(new UcConfiguracoesSobre());
        }

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pnlMenuConfig_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
