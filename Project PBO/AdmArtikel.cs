using Project_PBO.App.Context;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project_PBO
{
    public partial class AdmArtikel : Form
    {
        public AdmArtikel()
        {
            InitializeComponent();
            this.Load += new EventHandler(AdmArtikel_Load);
        }

        private void AdmArtikel_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonColors(button2);
        }

        private void LoadData()
        {
            try
            {
                //menampilkan data dari database ke datagridview
                DataTable artikel = Artikelcontext.all();
                if (artikel != null)
                {
                    dataGridView1.DataSource = artikel;
                    dataGridView1.Columns[0].HeaderText = "Action";
                    dataGridView1.Columns[1].HeaderText = "Id Artikel";
                    dataGridView1.Columns[2].HeaderText = "Judul";
                    dataGridView1.Columns[3].HeaderText = "Sumber";
                    dataGridView1.Columns[4].HeaderText = "Penyakit";
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
                    btn.BackColor = btn == activeButton ? activeColor : defaultColor;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdmFaskes admfaskes = new AdmFaskes();
            admfaskes.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdmObat admobat = new AdmObat();
            admobat.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdmKritik admkritik = new AdmKritik();
            admkritik.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Add your event handling code here, if needed
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //hapus data
            if (e.ColumnIndex == 0)
            {
                try
                {
                    int idArtikel = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Hapus Data", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Artikelcontext.delete(idArtikel);
                        MessageBox.Show("Data berhasil dihapus");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting data: {ex.Message}");
                }
            }

        }

    private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text change if needed
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Handle text change if needed
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Handle text change if needed
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Data tidak boleh kosong");
                return;
            }

            try
            {
                // Insert into database
                Artikelcontext.insert(textBox1.Text, textBox2.Text);
                MessageBox.Show("Data berhasil ditambahkan");

                // Refresh the DataGridView after inserting data
                LoadData();

                // Clear text boxes after insertion
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting data: {ex.Message}");
            }
        }
    }
}
