using System;
using System.Windows.Forms;

namespace ExempluDesign
{
    public partial class PanouMisiune : Form
    {
        private const int OxigenPeZi = 2;
        private const int ZileDeMisiune = 30;
        private const int GreutateAstronaut = 90;

        public PanouMisiune(int astronauti)
        {
            InitializeComponent();

            int oxigen = OxigenPeZi * astronauti * ZileDeMisiune;
            int probe = 0;
            int incarcatura = GreutateAstronaut * astronauti + oxigen + probe;

            lblAstronauti.Text = astronauti.ToString();
            lblOxigen.Text = oxigen.ToString();
            lblProbe.Text = probe.ToString();
            lblIncarcatura.Text = incarcatura.ToString();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanouMisiune_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                return;
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                Raport raport = new Raport();
                raport.ShowDialog();
            }
        }

        private void PanouMisiune_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
