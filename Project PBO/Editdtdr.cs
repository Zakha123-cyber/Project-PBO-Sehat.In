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
    public partial class Editdtdr : Form
    {
        public Editdtdr()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Datadiri data = new Datadiri();
            data.Show();
            this.Hide();
            data.FormClosed += (s, args) => this.Close();
        }
    }
}
