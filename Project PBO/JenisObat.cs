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
    public partial class JenisObat : Form
    {
        public JenisObat()
        {
            InitializeComponent();
            this.Load += new EventHandler(Admin_Load);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Menampilkan data dari database ke DataGridView
                DataTable obat = obatContext.All();
                if (obat != null && obat.Rows.Count > 0)
                {
                    dataGridView1.DataSource = obat;

                    // Mengatur header kolom sesuai dengan kebutuhan
                    dataGridView1.Columns[0].HeaderText = "id"; // Nomor urut
                    dataGridView1.Columns[2].HeaderText = "nama";
                    dataGridView1.Columns[3].HeaderText = "fungsi";
                    dataGridView1.Columns[4].HeaderText = "Dosis";
                    dataGridView1.Columns[5].HeaderText = "Jenis Obat";

                    // Menyesuaikan kolom agar mengisi lebar DataGridView
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No data retrieved from the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            SaranObat saran = new SaranObat();
            saran.Show();
            this.Hide();
            saran.FormClosed += (s, args) => this.Close();
        }

        private void JenisObat_Load(object sender, EventArgs e)
        {

        }
    }
}