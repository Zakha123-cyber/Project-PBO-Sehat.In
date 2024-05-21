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
    public partial class Datadiri : Form
    {
        public Datadiri()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            Editdtdr edit = new Editdtdr();
            edit.Show();
            this.Hide();
            edit.FormClosed += (s, args) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsKritik kritik = new UsKritik();
            kritik.Show();
            this.Hide();
            kritik.FormClosed += (s, args) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }
    }
}
