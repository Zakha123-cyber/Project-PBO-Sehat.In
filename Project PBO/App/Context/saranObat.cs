using Project_PBO.App.Core;
using System.Data;

namespace Project_PBO.App.Context
{
    public class obatContext : dataconn
    {
        private static string table = "obat";

        public static DataTable All()
        {
            // Query untuk mengambil semua data obat dengan informasi jenis obat
            string query = @"
                SELECT o.nama_obat AS NamaObat, o.fungsi AS Fungsi, o.dosis AS Dosis, jo.jenis AS NamaJenisObat
                FROM obat o
                JOIN jenis_obat jo ON o.id_jenis = jo.id_jenis";

            // Mengeksekusi query dan mengembalikan hasilnya
            return queryExecutor(query);
        }
    }
}