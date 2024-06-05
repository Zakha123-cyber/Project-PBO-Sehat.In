using Project_PBO.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.App.Context
{
    public class faskescontext : dataconn
    {
        //cari faskes terdekat dari inputan user
        public static DataTable cariFaskes(string namaKota)
        {
            string query = $@"
    SELECT 
        id_faskes, 
        nama_faskes AS Nama, 
        alamat AS Alamat, 
        no_telfon AS ""No. Telfon"",  -- Menggunakan tanda kutip ganda untuk delimeter
        kota AS Kota, 
        website AS Website, 
        jam_operasional AS ""Jam Operasional"" -- Menggunakan tanda kutip ganda untuk delimeter
    FROM faskes
    WHERE kota = '{namaKota}'";
            return queryExecutor(query);
        }





    }
}

