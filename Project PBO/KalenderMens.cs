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
    public partial class KalenderMens : Form
    {
        public KalenderMens()
        {
            InitializeComponent();
        }

        private void KalenderMens_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mens mens = new Mens();
            mens.Show();
            this.Hide();
            mens.FormClosed += (s, args) => this.Close();
        }
    }
}
