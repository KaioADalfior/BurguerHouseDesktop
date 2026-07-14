using Lanchonete001.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lanchonete001.Mesas
{
    /// <summary>
    /// Diálogo para escolher uma mesa livre como destino de transferência.
    /// Uso: new FrmEscolherMesa(mesasLivres); dlg.ShowDialog(); se OK,
    /// o resultado está em dlg.MesaEscolhida.
    /// </summary>
    public partial class FrmEscolherMesa : Form
    {
        private readonly List<Mesa> _mesasLivres;

        public Mesa MesaEscolhida { get; private set; }

        public FrmEscolherMesa(List<Mesa> mesasLivres)
        {
            _mesasLivres = mesasLivres;
            InitializeComponent();
        }

        private void FrmEscolherMesa_Load(object sender, EventArgs e)
        {
            MontarCards();
        }

        private void MontarCards()
        {
            flpMesas.SuspendLayout();
            flpMesas.Controls.Clear();

            foreach (var mesa in _mesasLivres)
            {
                flpMesas.Controls.Add(CriarCardMesa(mesa));
            }

            flpMesas.ResumeLayout();
        }

        private RoundedPanel CriarCardMesa(Mesa mesa)
        {
            var card = new RoundedPanel
            {
                Size = new Size(90, 70),
                Margin = new Padding(0, 0, 12, 12),
                BackColor = AppColors.SuccessLight,
                BorderColor = AppColors.Success,
                BorderThickness = 1,
                CornerRadius = 12,
                Cursor = Cursors.Hand,
                Tag = mesa
            };

            var lblNumero = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 12F, FontStyle.Bold),
                ForeColor = AppColors.TextDark,
                BackColor = Color.Transparent,
                Text = mesa.Numero.ToString("00"),
                Location = new Point(28, 14)
            };

            var lblLegenda = new Label
            {
                AutoSize = true,
                Font = new Font("Poppins", 8F),
                ForeColor = AppColors.Success,
                BackColor = Color.Transparent,
                Text = "Livre",
                Location = new Point(26, 44)
            };

            card.Controls.Add(lblNumero);
            card.Controls.Add(lblLegenda);

            EventHandler aoClicar = (s, e) => Escolher(mesa);
            card.Click += aoClicar;
            lblNumero.Click += aoClicar;
            lblLegenda.Click += aoClicar;
            lblNumero.Cursor = Cursors.Hand;
            lblLegenda.Cursor = Cursors.Hand;

            return card;
        }

        private void Escolher(Mesa mesa)
        {
            MesaEscolhida = mesa;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}