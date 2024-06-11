using Project_PBO.App.Context;
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
    public partial class UsKritik : Form
    {
        private int get_id;
        public UsKritik(int get_id)
        {
            InitializeComponent();
            this.get_id = get_id;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //saran
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
            user.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsArtikel artikel = new UsArtikel();
            artikel.Show();
            this.Hide();
            artikel.FormClosed += (s, args) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datadiri data = new Datadiri();
            data.Show();
            this.Hide();
            data.FormClosed += (s, args) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //kritik
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //insert kritik saran
            this.Close();
            string kritik = tbkritik.Text;
            string saran = tbsaran.Text;
            kritikSaranContext.insert(kritik, saran, get_id);

        }
    }
}
