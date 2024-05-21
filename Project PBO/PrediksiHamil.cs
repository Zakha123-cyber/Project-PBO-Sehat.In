using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO
{
    public partial class PrediksiHamil : Form
    {
        public PrediksiHamil()
        {
            InitializeComponent();
        }

        private void PrediksiHamil_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KalenderHamil hamil = new KalenderHamil();
            hamil.Show();
            this.Hide();
            hamil.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsProfil profil = new UsProfil();
            profil.Show();
            this.Hide();
            profil.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsArtikel artikel = new UsArtikel();
            artikel.Show();
            this.Hide();
            artikel.FormClosed += (s, args) => this.Close();
        }
    }
}
