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
    public partial class AdmObat : Form
    {
        private string email;
        public AdmObat()
        {
            InitializeComponent();
            this.Load += new EventHandler(AdmObat_Load);
            email= Login.UserEmail;
        }
        private void AdmObat_Load(object sender, EventArgs e)

        {
            LoadData();
            SetButtonColors(button4);
        }

        // Load data
        private void LoadData()
        {
            
            //menampilkan nama admin
            DataTable dt = datadiricontext.getdatadirinama(email);
            if (dt != null && dt.Rows.Count > 0)
            {
                string nama = dt.Rows[0]["nama"].ToString();
                namaadminubat.Text = nama;
               
                Console.WriteLine("Nama data loaded successfully.");
            }
            else
            {
                Console.WriteLine(dt == null ? "DataTable dt is null." : "No data found for datadirinama.");
            }
        }
        private void SetButtonColors(Button activeButton)
        {
            Color defaultColor = ColorTranslator.FromHtml("#F5F6F8");
            Color activeColor = ColorTranslator.FromHtml("#E13D65");

            // Loop melalui semua kontrol di form
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    // Mengatur warna untuk setiap button
                    if (btn == activeButton)
                    {
                        btn.BackColor = activeColor;
                    }
                    else
                    {
                        btn.BackColor = defaultColor;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdmArtikel artikel = new AdmArtikel();
            artikel.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdmFaskes admfaskes = new AdmFaskes();
            admfaskes.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdmKritik admkritik = new AdmKritik();
            admkritik.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
