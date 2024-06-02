using Project_PBO.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.App.Context
{
    public class Artikelcontext : dataconn
    {
        public static DataTable GetAllArtikel()
        {
            string query = "SELECT * FROM artikel"; // Query untuk mengambil semua data artikel
            return queryExecutor(query); // Eksekusi query menggunakan metode dari kelas dataconn dan kembalikan hasilnya
        }
    }
}
