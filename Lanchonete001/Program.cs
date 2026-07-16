using Lanchonete001.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete001
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var frmLogin = new FrmLogin())
            {
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1(frmLogin.UsuarioLogado));
                }
            }
        }
    }
}