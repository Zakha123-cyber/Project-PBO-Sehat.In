using Npgsql;
using Project_PBO.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.App.Context
{
    public class KaloriContext : dataconn
    {
        public static DataTable getAllMakanan()
        {
            string query = "SELECT nama_makanan FROM kalori_makanan";
            DataTable dt = queryExecutor(query);
            return dt;
        }

        public static int countKalori(string name, int berat)
        {
            string query = "SELECT * from kalori_makanan WHERE nama_makanan = @nama_makanan";
            NpgsqlParameter[] param =
            {
                new NpgsqlParameter("@nama_makanan", DbType.String){Value = name},
            };
            DataTable dt = queryExecutor(query, param);
            string kandunganMakanan = dt.Rows[0]["kandungan"].ToString();
            int kandunganMakananInteger = Int32.Parse(kandunganMakanan);
            int totalKalori = (berat / 100) * kandunganMakananInteger;
            return totalKalori;
        }
    }
}
