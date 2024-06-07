using Project_PBO.App.Context;
using Project_PBO.App.dtos.responses;
using System;
using System.Collections;
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
    public partial class Kalori : Form
    {
        public Kalori()
        {
            InitializeComponent();
            DataTable makanan = KaloriContext.getAllMakanan();
            ListMakanan.DataSource = makanan;
            ListMakanan.DisplayMember = "nama_makanan";
            ListMakanan.ValueMember = "nama_makanan";
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
            UsUmum umum = new UsUmum();
            umum.Show();
            this.Hide();
            umum.FormClosed += (s, args) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string namaMakanan = ListMakanan.Text;
            int beratMakanan = Int32.Parse(textBox2.Text);
            int hasilKalori = KaloriContext.countKalori(namaMakanan, beratMakanan);
            HitungKalori hitung = new HitungKalori(hasilKalori);
            hitung.Show();
            this.Hide();
            hitung.FormClosed += (s, args) => this.Close();
        }

        private void TambahButton_Click(object sender, EventArgs e)
        {
            List<TambahKaloriResponse> arrayMakanan = new List<TambahKaloriResponse>();
            string namaMakanan = ListMakanan.Text;
            int beratMakanan = Int32.Parse(textBox2.Text);
            TambahKaloriResponse tambahKaloriResponse = new TambahKaloriResponse();
            tambahKaloriResponse.nama_makanan = namaMakanan;
            tambahKaloriResponse.berat = beratMakanan;
            tambahKaloriResponse.kandungan = 100;

            arrayMakanan.Add(tambahKaloriResponse);
            
            ArrayMakanan.DataSource = arrayMakanan;

            textBox2.Text = "";
        }
    }
}
