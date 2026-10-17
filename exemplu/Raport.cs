using System;
using System.Windows.Forms;

namespace ExempluDesign
{
    public partial class Raport : Form
    {
        public Raport()
        {
            InitializeComponent();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "RaportMisiune.jpg";
            dialog.Filter = "Imagine JPG|*.jpg";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            MessageBox.Show("Raportul se salveaza in:\n" + dialog.FileName, "Raport",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
