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
    public partial class Login : Form 
    {
        public Login()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM profil where email = {tbemail} and password = {tbpass}";
            DataTable dt = ProfilContext.queryExecutor(query);
            if (dt.Rows.Count > 0)
            {
                if (radioButton1.Checked)
                {
                    Admin newForm = new Admin();
                    newForm.Show();
                    this.Hide();
                    newForm.FormClosed += (s, args) => this.Close();
                }
                if (radioButton2.Checked)
                {
                    User newForm = new User();
                    newForm.Show();
                    this.Hide();
                    newForm.FormClosed += (s, args) => this.Close();
                }
            }

            else
            {
                MessageBox.Show("Email atau Password anda salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
