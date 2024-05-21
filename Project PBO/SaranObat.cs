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
    public partial class SaranObat : Form
    {
        public SaranObat()
        {
            InitializeComponent();
        }

        private void SaranObat_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Farmasi farmasi = new Farmasi();
            farmasi.Show();
            this.Hide();
            farmasi.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsArtikel artikel = new UsArtikel();
            artikel.Show();
            this.Hide();
            artikel.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsProfil profil = new UsProfil();
            profil.Show();
            this.Hide();
            profil.FormClosed += (s, args) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JenisObat jenis = new JenisObat();
            jenis.Show();
            this.Hide();
            jenis.FormClosed += (s, args) => this.Close();
        }
    }
}
